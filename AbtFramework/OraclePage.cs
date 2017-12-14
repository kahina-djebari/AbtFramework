using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AbtFramework.Utils_Classes.SeleniumUtils;
using AbtFramework.Sikuli;
using AbtFramework.Sikuli.SikuliPatternObjects.OracleForms;
using AbtFramework.Sikuli.SikuliPatternObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbtFramework.PageObjects.Oracle;

namespace AbtFramework
{
    public class OraclePage : PageModel
    {
        static String gUser = "user";

        //sikuli objects
        private OracleFormsPatternObject patterns;
        private CommonPaternObjects commonPatterns;
        private GradeRatePatternObject gradePatterns;
        private AbtHRMSManagerObject HRMSManagerPatterns;
        private ConfDefaultProcessRunsObjects ConfDefaultProcessRunsPatterns;
        private SikuliHelper sikuliHelper;

        //page objects
        private LoginPagePO loginPagePO;
        private CommonPO commonPO = new CommonPO();
        private TimeCardPO timeCardPO = new TimeCardPO();
        private iProcurementPO iprocurementPO = new iProcurementPO();
        private BuyerWorkRequisitionPO buyerRequisitionPO = new BuyerWorkRequisitionPO();
        private HRFormsVeteranStatusPO veteranStatusPO = new HRFormsVeteranStatusPO();
        private OracleDiscovererViewerPO discovererPO = new OracleDiscovererViewerPO();
        private AbtHROperationsSelfServicePO operationsSelfPO = new AbtHROperationsSelfServicePO();
        private WorkflowUserWebAppPO workFlowPO = new WorkflowUserWebAppPO();

        public const string MyAccountPageTitle = "My Account";
        private int counter = 11;
        private int counter1 = 8;

    

        //HRSS Transactions: Enter Spot Bonus – Actor: HRSC
        [FindsBy(How = How.XPath, Using = "//span[text()='Payment Type']/parent::td/following-sibling::td//input")]
        private IWebElement paymentTypeInput;

        [FindsBy(How = How.XPath, Using = "//span[text()='Payment Date']/parent::td/following-sibling::td//input")]
        private IWebElement paymentDateInput;

        [FindsBy(How = How.XPath, Using = "//span[text()='Payment Amount']/parent::td/following-sibling::td//input")]
        private IWebElement paymentAmountInput;

        [FindsBy(How = How.XPath, Using = "//img[@title='Search for Bonus Awarded By']")]
        private IWebElement paymentBonusAwardedByIcon;

        [FindsBy(How = How.XPath, Using = "//span[text()='Comments']/parent::td/following-sibling::td//input")]
        private IWebElement paymentCommentsInput;

        [FindsBy(How = How.XPath, Using = "//input[@title='Search Term']")]
        private IWebElement bonusAwardedBySearchInput;

        [FindsBy(How = How.XPath, Using = "//input[@title='Select']")]
        private IWebElement bonusAwardedSelecRadioBtn;

        [FindsBy(How = How.Id, Using = "HrNext")]
        private IWebElement applyOrNextBonusBtn; //this works for apply and next in Bonus Spot section

        //this will be simplified with the refactor, but at this point need to call 
        //index to get a single button, this is because same button is twice. too lazy to get
        //unique path :)
        [FindsBy(How = How.XPath, Using = "//button[text() = 'Select']")]
        private IList<IWebElement> selectBtnsList;


        /// <summary>
        /// Goes to Oracle Link
        /// </summary>
        public void GoToOracleDev()
        {
            StartTimer();
            SeleniumDriver.GoTo("https://abterp2.coresys.com/OA_HTML/AppsLocalLogin.jsp");

        }


        /// <summary>
        /// Login in Oracle Page
        /// </summary>
        /// <param name="user"></param>
        public void Login(string user)
        {
      
            loginPagePO = new LoginPagePO();
            SeleniumDriver.SetValue(loginPagePO.GetUserNameInput(), user);
            SeleniumDriver.SetValue(loginPagePO.GetPasswordInput(), "test123456");
            SeleniumDriver.ClickElement(loginPagePO.GetLoginBtn());

        }



        private IWebElement getLinkFromMainMenuTable(string link)
        {
            IWebElement element = null;
            Console.WriteLine(gUser);
            // structure to the text -> table/tbody/tr[index]/td[4]/a
            if (gUser.Equals("Valerie Hennessey"))
            {

                ICollection<IWebElement> rows = commonPO.GetHomeMenuTable().FindElements(By.TagName("tr"));

                try
                {
                    foreach (var row in rows)
                    {
                        element = row.FindElement(By.XPath("td[4]/a"));
                        if (element.GetAttribute("textContent").Equals(link))
                        {
                            return element;
                        }
                    }
                }
                catch (NoSuchElementException)
                {
                    //couldnot find 
                }
            }
            else
            {
                ICollection<IWebElement> rows = commonPO.GetHomeMenuTable().FindElements(By.TagName("tr"));

                try
                {
                    foreach (var row in rows)
                    {
                        element = row.FindElement(By.XPath("td[4]/a"));
                        if (element.GetAttribute("textContent").Equals(link))
                        {
                            return element;
                        }
                    }
                }
                catch (NoSuchElementException)
                {
                    //couldnot find 
                }
            }

            return element;
        }

        private IWebElement getLinkFromUserOptions(string link)
        {
            IWebElement element = null;
            Console.WriteLine(gUser);

            ICollection<IWebElement> rows = commonPO.GetUserBrowsingOptions().FindElements(By.TagName("tr"));

            try
            {
                foreach (var row in rows)
                {

                    if (row.GetAttribute("textContent").Equals(link))
                    {
                        element = row.FindElement(By.XPath("td[3]/a"));
                        return element;
                    }
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("could not find: " + link);
            }


            return element;
        }

        /// <summary>
        /// Clicks on the Home Page folder list specify by the option.
        /// can work on any "a" element of the DOM
        /// </summary>
        /// <param name="option"></param>
        public void ClickMainMenuTableOption(string option)
        {
            SeleniumDriver.ClickElement(commonPO.GetSelectHomePageLinkFolder(option));
        

        }

        /// <summary>
        /// Clicks and goes back
        /// </summary>
        /// <param name="option"></param>
        public void ClickRightSideMenuTableOptions(string option)
        {
            SeleniumDriver.ClickElement(commonPO.GetSelectHomePageLinkFolder(option));
            SeleniumDriver.NavigateBack();

        }



        public void ClickUserOptions(string option)
        {
            Thread.Sleep(1000);
            IWebElement test = getLinkFromUserOptions(option);
            test.Click();
            Thread.Sleep(1000);
            SeleniumDriver.Instance.Navigate().Back();
        }

        public void ClickUserOptions1(string option)
        {
            Thread.Sleep(1000);
            IWebElement test = getLinkFromUserOptions(option);
            test.Click();
        }


        public void clickIProcurementRequest()
        {
            SeleniumDriver.ClickElement(timeCardPO.GetNonCatalogRequest());
       
        }

        public void clickTimeCard()
        {
            SeleniumDriver.ClickElement(timeCardPO.GetTimeEntry());
            SeleniumDriver.ClickElement(timeCardPO.GetCreateTimeCards());
        }

        public void fillTimeCard()
        {
            SeleniumDriver.SetValue(timeCardPO.GetProjectTimeCardInput(), "10000");
            SeleniumDriver.ClickElement(timeCardPO.GetTasktTimeCardInput());
            SeleniumDriver.SetValue(timeCardPO.GetTasktTimeCardInput(), "1011");
            SeleniumDriver.ClickElement(timeCardPO.GetTypeTimeCardInput());
            SeleniumDriver.SetValue(timeCardPO.GetTypeTimeCardInput(), "Vacation");

            List<IWebElement> inputList = timeCardPO.GetTimeInputList();
            for(int i = 0; i < inputList.Count; i++)
            {
                if(i < 2)
                {
                    SeleniumDriver.SetValue(inputList[i], "0");
                }
                else
                {
                    SeleniumDriver.SetValue(inputList[i], "8");
                }
                
            }

            SeleniumDriver.ClickElement(timeCardPO.GetReviewThenSavebutton());
      
        }
        public void completeTimeCardRequest()
        {
            SeleniumDriver.ClickElement(timeCardPO.GetCompleteSaveTimeCardProcess());
            SeleniumDriver.ClickElement(timeCardPO.GetReturnToTimeEntryButtonTimeCard());
            SeleniumDriver.ClickElement(timeCardPO.GetTimecardBeginSubmit());
            SeleniumDriver.ClickElement(timeCardPO.GetTimecardSubmit());

        }
        public void SelectAndApproveOrder()
        {
            SeleniumDriver.ClickElement(timeCardPO.GetTimeCardToBeApproved());
            SeleniumDriver.ClickElement(timeCardPO.GetButtonApproveTimeCard());
         
        }
        public void fillNonCatalogRequestForm()
        {
            SeleniumDriver.SetValue(iprocurementPO.GetItemDescription(), "Test Description");
            SeleniumDriver.SetValue(iprocurementPO.GetQuantity(), "160");
            SeleniumDriver.SetValue(iprocurementPO.GetUnitOfMeasure(), "Hour");

            SeleniumDriver.ClickElement(iprocurementPO.GetUnitPrice());
            SeleniumDriver.SetValue(iprocurementPO.GetUnitPrice(), "20");

            SeleniumDriver.SetValue(iprocurementPO.GetSupplierName(), "Think Forward Consulting");

            SeleniumDriver.ClickElement(iprocurementPO.GetContactName());
            SeleniumDriver.SetValue(iprocurementPO.GetContactName(), "Test Contant Name");

            SeleniumDriver.ClickElement(iprocurementPO.GetPhone());
            SeleniumDriver.SetValue(iprocurementPO.GetContactName(), "8099880000");

            SeleniumDriver.ClickElement(iprocurementPO.GetAddToCart());
            SeleniumDriver.ClickElement(iprocurementPO.GetViewCartAndCheckout());

        }
        public void clickCheckOut()
        {
            SeleniumDriver.ClickElement(iprocurementPO.GetCheckout_uixr());
       
        }

        public void fillRequisitionInformation()
        {
            SeleniumDriver.SetValue(iprocurementPO.GetProject(), "21553");

            SeleniumDriver.ClickElement(iprocurementPO.GetTask());
            SeleniumDriver.SetValue(iprocurementPO.GetTask(), "1100");

            SeleniumDriver.ClickElement(iprocurementPO.GetExpenditureType());
            SeleniumDriver.SetValue(iprocurementPO.GetExpenditureType(), "Misc Professional Sv");

            SeleniumDriver.ClickElement(iprocurementPO.GetExpenditureItemDate());
            //Console.WriteLine(DateTime.Today.ToString("dd-MMMM-yyyy"));
            SeleniumDriver.SetValue(iprocurementPO.GetExpenditureItemDate(), string.Format("{0:dd-MMM-yyyy}", DateTime.Today));

            SeleniumDriver.ClickElement(iprocurementPO.GetNextButtons());
    
        }
        public void clickManageGraphButton()
        {
            SeleniumDriver.ClickElement(iprocurementPO.GetManageApprovals());
       
        }
        public void addBeforeApproverAndSubmit(string approver)
        {
            SeleniumDriver.SetValue(iprocurementPO.GetNewApproverText(), approver);
            SeleniumDriver.SelectDropDownByText(iprocurementPO.GetNewApproverText(), "Before Requisition Approver Controller");
           
            SeleniumDriver.ClickElement(commonPO.GetSubmitButton_uixr());
         
        }
        public void addAfterApprover(string approver)
        {
            SeleniumDriver.ClickElement(iprocurementPO.GetManageApprovals());
            SeleniumDriver.SetValue(iprocurementPO.GetNewApproverText(), approver);

            SeleniumDriver.SelectDropDownByText(iprocurementPO.GetNewApproverText(), "After Requisition Approver Controller");
           
            SeleniumDriver.ClickElement(commonPO.GetSubmitButton_uixr());
      
        }
        public void SubmitAfterApprovers()
        {
            SeleniumDriver.ClickElement(iprocurementPO.GetApprovalNextButton());
        }

        public void submitApproval()
        {
            SeleniumDriver.ClickElement(commonPO.GetSubmitButton_uixr());
            SeleniumDriver.ClickElement(iprocurementPO.GetContinueShoppingButton());
        }

        public void openRequisitionsBuyerWorkCenter()
        {
            SeleniumDriver.ClickElement(buyerRequisitionPO.GetRequisitionsBuyerWorkCenter());
       
        }

        public void openRequisitionsRequisitions()
        {
            SeleniumDriver.ClickElement(buyerRequisitionPO.GetRequisitionsRequisitions());
         
        }

        public void selectRequisitionToBeAdded()
        {

            SeleniumDriver.ClickElement(buyerRequisitionPO.GetRequisitionToBeAdded());
      
        }

        public void addRequisition()
        {
            SeleniumDriver.ClickElement(buyerRequisitionPO.GetAddRequisitionButton());
      
        }

        public void clickCreate()
        {
            SeleniumDriver.ClickElement(buyerRequisitionPO.GetCreateButton());
 
        }

     
    
        public void clickEntries()
        {
            SeleniumDriver.ClickElement(commonPO.GetEntriesNavigationLink());
  
        }

        public void clickSalary()
        {
            SeleniumDriver.ClickElement(commonPO.GetSalaryNavigationLink());

        }

        public void clickSalaryB()
        {
            SeleniumDriver.ClickElement(commonPO.GetSalaryBNavigationLink());
   
        }

        public void clickValues()
        {
            SeleniumDriver.ClickElement(commonPO.GetValuesNavigationLink());
         
        }

        public void clickAbsence()
        {
            SeleniumDriver.ClickElement(commonPO.GetAbsenceNavigationLink());
         
        }

        public void clickDescriptionPayroll()
        {
            SeleniumDriver.ClickElement(commonPO.GetDescriptionPayrollNavigationLink());
   
        }

        public void clickDescriptionGrade()
        {
            SeleniumDriver.ClickElement(commonPO.GetDescriptionGradeNavigationLink());
   
        }

        public void clickDescriptionJob()
        {
            SeleniumDriver.ClickElement(commonPO.GetDescriptionJobNavigationLink());
 
        }

        public void clickDescriptionOrganization()
        {
            SeleniumDriver.ClickElement(commonPO.GetDescriptionOrganizationNavigationLink());
       
        }

        public void clickDescriptionPosition()
        {
            SeleniumDriver.ClickElement(commonPO.GetDescriptionPositionNavigationLink());
   
        }


        public static bool IsAt()
        {
            return SeleniumDriver.Instance.Title.Equals("Search");
        }


        public void chooseVeteranStatus()
        {
            SeleniumDriver.ClickElement(commonPO.GetUpdateBtn());

            SeleniumDriver.ClickElement(veteranStatusPO.GetSearchVeteranStatusBtn());
            // Store all the opened window into the 'list' 
            List<string> lstWindow = SeleniumDriver.Instance.WindowHandles.ToList();
            SeleniumDriver.Instance.SwitchTo().Window(lstWindow[1]);
            SeleniumDriver.Instance.SwitchTo().Frame(0);

            SeleniumDriver.ClearValue(veteranStatusPO.GetSearchVeteranStatusInputBox());
            SeleniumDriver.ClickElement(commonPO.GetGoBtn());
            SeleniumDriver.ClickElement(veteranStatusPO.GetQuickSelect2());
   
            SeleniumDriver.Instance.SwitchTo().Window(lstWindow[0]);
            SeleniumDriver.ClearValue(veteranStatusPO.GetDateInput());
            SeleniumDriver.SetValue(veteranStatusPO.GetDateInput(), string.Format("{0:dd-MMM-yyyy}", DateTime.Today));
            SeleniumDriver.ClickElement(veteranStatusPO.GetApplyBtn());
            SeleniumDriver.ClickElement(veteranStatusPO.GetNextBtn());
            SeleniumDriver.ClickElement(veteranStatusPO.GetSubmitBtn());
            SeleniumDriver.ClickElement(commonPO.GetGoHomeBtn());
      

        }

        public void DoDiscovererWorkbookMultipleSheets()
        {
            SeleniumDriver.ClickElement(discovererPO.GetDetailActiveEmployeeOptn());
            ClickMainMenuTableOption("Modified Detail Active Emp Listing");

        }

        public void DoDiscovererWorkbookOneSheet()
        {
            int count = 0;
            List<IWebElement> list = discovererPO.GetSelectToExpandIcons();
            //to expand all menus first
            while (list != null && list.Count != 0)
            {
                SeleniumDriver.ClickElement(list[0]);
                list = discovererPO.GetSelectToExpandIcons();

            }

            List<IWebElement> expList = discovererPO.GetExpandedOptionToClick();
            //to click on the expanded links
            while (count < expList.Count)
            {
                SeleniumDriver.ClickElement(expList[count]);
                count++;
            }

        }


        /// <summary>
        /// Accepts Java alerts to run Oracle application
        /// </summary>
        private void AcceptJavaAlert()
        {
            patterns = new OracleFormsPatternObject();
            commonPatterns = new CommonPaternObjects();
            sikuliHelper = SikuliHelper.GetInstance();

            //there is another alert, verify if present or not
            if (commonPatterns.GetAcceptCheckBoxSecurityWarning != null)
            {
                sikuliHelper.ClickPattern(commonPatterns.GetAcceptCheckBoxSecurityWarning);
                sikuliHelper.ClickPattern(commonPatterns.GetRunOracleSecurityWarning);
            }

            //sometimes it shows twice
            if (commonPatterns.GetRunOracleBtn != null)
                sikuliHelper.ClickPattern(commonPatterns.GetRunOracleBtn);

            if (commonPatterns.GetRunOracleBtn != null)
                sikuliHelper.ClickPattern(commonPatterns.GetRunOracleBtn);


        }


        public void FillOracleFroms()
        {


            patterns = new OracleFormsPatternObject();
            commonPatterns = new CommonPaternObjects();

            AcceptJavaAlert();

            sikuliHelper.SetInputValue(patterns.GetDescriptionInput1, "test");

            sikuliHelper.ClickPattern(patterns.GetNum);

            sikuliHelper.ClickPattern(patterns.GetType);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectGoods);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetCategory);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn2);

            sikuliHelper.ClickPattern(patterns.GetSelectFunding);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn3);

            sikuliHelper.ClickPattern(patterns.GetSelectIncrease);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetOkBtn2);

            sikuliHelper.SetInputValue(patterns.GetDescriptionInput2, "test");

            sikuliHelper.ClickPattern(patterns.GetUOM);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn4);

            sikuliHelper.ClickPattern(patterns.GetSelectEach);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.SetInputValue(patterns.GetQuantity, "100");

            while (counter > 0)
            {
                sikuliHelper.ClickPattern(patterns.GetRightArrow);
                counter--;
            }

            sikuliHelper.SetInputValue(patterns.GetPrice, "50");

            sikuliHelper.ClickPattern(patterns.GetNeedBy);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectDate);

            sikuliHelper.ClickPattern(patterns.GetOkBtn3);

            sikuliHelper.ClickPattern(patterns.GetOrganization);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectOrganization);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetLocation);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.SetInputValue(patterns.GetFindLocation, "bethesda");

            sikuliHelper.ClickPattern(patterns.GetFindBtn);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetDistributions);

            sikuliHelper.ClickPattern(patterns.GetProjectBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.SetInputValue(patterns.GetFindLocation, "21553");

            sikuliHelper.ClickPattern(patterns.GetFindBtn);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.SetInputValue(patterns.GetFindLocation, "1100");

            sikuliHelper.ClickPattern(patterns.GetFindBtn);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.SetInputValue(patterns.GetFind2, "misc");

            sikuliHelper.ClickPattern(patterns.GetFindBtn);

            sikuliHelper.ClickPattern(patterns.GetProjectType);

            sikuliHelper.ClickPattern(patterns.GetOkBtn);

            sikuliHelper.ClickPattern(patterns.GetDate);

            sikuliHelper.ClickPattern(patterns.GetSelectBtn);

            sikuliHelper.ClickPattern(patterns.GetSelectDate);

            sikuliHelper.ClickPattern(patterns.GetOkBtn3);

            sikuliHelper.ClickPattern(patterns.GetSaveIcon);

            sikuliHelper.ClickPattern(patterns.GetCloseWindow);

            sikuliHelper.ClickPattern(patterns.GetApproveBtn);

            sikuliHelper.ClickPattern(patterns.GetOkBtn4);

        }

        public void FillTheGradeRateOracleForms()
        {

            gradePatterns = new GradeRatePatternObject();
            commonPatterns = new CommonPaternObjects();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(gradePatterns.GetNoBtn);

            sikuliHelper.ClickPattern(gradePatterns.GetView);

            sikuliHelper.ClickPattern(gradePatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(gradePatterns.GetEnter);

            sikuliHelper.SetInputValue(gradePatterns.GetNameField, "%");

            sikuliHelper.ClickPattern(gradePatterns.GetView);

            sikuliHelper.ClickPattern(gradePatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(gradePatterns.GetRun);

            sikuliHelper.ClickPattern(gradePatterns.GetGradeNameField);

            sikuliHelper.ClickPattern(gradePatterns.GetView);

            sikuliHelper.ClickPattern(gradePatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(gradePatterns.GetEnter);

            sikuliHelper.SetInputValue(gradePatterns.GetGradeNameInputField, "%Can%");

            sikuliHelper.ClickPattern(gradePatterns.GetView);

            sikuliHelper.ClickPattern(gradePatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(gradePatterns.GetRun);

            sikuliHelper.ClickPattern(gradePatterns.GetView);

            sikuliHelper.ClickPattern(gradePatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(gradePatterns.GetEnter);

            sikuliHelper.SetInputValue(gradePatterns.GetGradeNameInputField, "%Mex%");

            sikuliHelper.ClickPattern(gradePatterns.GetView);

            sikuliHelper.ClickPattern(gradePatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(gradePatterns.GetRun);
        }

        public void UpdateInformationOnOracleForm()
        {
            HRMSManagerPatterns = new AbtHRMSManagerObject();
            commonPatterns = new CommonPaternObjects();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetNoBtn);

            sikuliHelper.SetInputValue(HRMSManagerPatterns.GetFullName, "oumsalem");

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetFindBtn);

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetOfficeDetails);

            sikuliHelper.SetInputValue(HRMSManagerPatterns.GetOfficeInputField, "test");

            sikuliHelper.PressEnter();

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetCorrectionBtn);

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetSaveIcon);

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetCloseOracleForm);

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetOkBtn);

        }

        public void GoToOracleForm()
        {
            HRMSManagerPatterns = new AbtHRMSManagerObject();
            commonPatterns = new CommonPaternObjects();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetNoBtn);

            sikuliHelper.SetInputValue(HRMSManagerPatterns.GetFullName, "oumsalem");

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetFindBtn);

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetCloseOracleForm);

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetOkBtn);

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetCloseWindow);
        }

        public void ChangeTimecardApprover()
        {
            SelectEmployeeInPeopleHierarchy();

            SeleniumDriver.SetValue(operationsSelfPO.GetEffectiveDateInput(), "09-Dec-2017");

            SeleniumDriver.ClickElement(operationsSelfPO.GetContinueChangeHoursBtn());
         
            SeleniumDriver.ClearValue(operationsSelfPO.GetSupervisorNameInput());
            SeleniumDriver.SetValue(operationsSelfPO.GetSupervisorNameInput(), "poodts");
            SeleniumDriver.SetValue(operationsSelfPO.GetSupervisorNameInput(), Keys.Tab);

            SeleniumDriver.ClickElement(operationsSelfPO.GetNextBtnValidateChangeManagerBtn());
     
            SeleniumDriver.ClearValue(operationsSelfPO.GetTimecardApproverInput());
            SeleniumDriver.SetValue(operationsSelfPO.GetTimecardApproverInput(), "poodts");
            SeleniumDriver.SetValue(operationsSelfPO.GetTimecardApproverInput(), Keys.Tab);

            SeleniumDriver.SelectDropDownByText(operationsSelfPO.GetChangeReasonSelect(), "Supervisor & Timecard Approver Change");
            SeleniumDriver.ClickElement(operationsSelfPO.GetNextBtnValidateAssignmentBtn());
            SeleniumDriver.ClickElement(operationsSelfPO.GetSubmitChangeTimecardApproverSupervisorBtn());
            SeleniumDriver.ClickElement(commonPO.GetGoHomeBtn());
        
        }

        public void ChangeEmployeeHours()
        {
            SelectEmployeeInPeopleHierarchy();

            SeleniumDriver.SetValue(operationsSelfPO.GetEffectiveDateInput(), "09-Dec-2017");
            SeleniumDriver.ClickElement(operationsSelfPO.GetContinueChangeHoursBtn());

            SeleniumDriver.ClearValue(operationsSelfPO.GetWorkHoursInputField());
            SeleniumDriver.SetValue(operationsSelfPO.GetWorkHoursInputField(), "32");

            SeleniumDriver.SelectDropDownByText(operationsSelfPO.GetAssignmentCategorySelect(), "Parttime-Standard");
            SeleniumDriver.ClickElement(operationsSelfPO.GetNextBtnValidateWorkSchedule());

            SeleniumDriver.ClickElement(operationsSelfPO.GetProposePayChangeBtn());
  
            SeleniumDriver.SelectDropDownByText(operationsSelfPO.GetReasonForPayChangeSelect(), "Status Change");

            SeleniumDriver.SetValue(operationsSelfPO.GetActualPayAmountInput(), "50000");
            SeleniumDriver.ClickElement(operationsSelfPO.GetApplyPayDetailsButton());
            SeleniumDriver.ClickElement(operationsSelfPO.GetApplyPayDetailsButton());

            SeleniumDriver.ClickElement(operationsSelfPO.GetNextBtnValidatePayChangeProposal());
            SeleniumDriver.ClickElement(operationsSelfPO.GetSubmitChangeHoursBtn());

        }

        /// <summary>
        /// Performs a offboarding (termination) to an employee
        /// </summary>
        public void DoOffboardEmployee()
        {
            SelectEmployeeInPeopleHierarchy();

            SeleniumDriver.SelectDropDownByText(operationsSelfPO.GetChangeReasonSelect(), "Employee Transfer");
         
    
            commentsTextArea.SendKeys("For Testing");
            nextBtnAfterReason.Click();

            AddAttachmentsAdditionalInfo();

            submitInReviewConfirmationBtn.Click();


        }
        /// <summary>
        /// Performs Spot Bonus action against an employee.
        /// </summary>
        public void DoSpotBonus()
        {
            SelectEmployeeInPeopleHierarchy();

            SeleniumDriver.ClickElement(commonPO.GetAddBtn());
       
            if (!paymentTypeInput.GetAttribute("value").Equals("SP"))
                Assert.Fail("Error: SP value not present in Payment Input");

            string nextSaturday = GetNextWeekDay(DateTime.Today.AddDays(1), DayOfWeek.Saturday);
            paymentDateInput.SendKeys(nextSaturday);
            paymentAmountInput.SendKeys("100");
            paymentBonusAwardedByIcon.Click();

            Thread.Sleep(1000);
            // Store all the opened window into the 'list' 
            List<string> lstWindow = SeleniumDriver.Instance.WindowHandles.ToList();
            SeleniumDriver.Instance.SwitchTo().Window(lstWindow[1]);
            SeleniumDriver.Instance.SwitchTo().Frame(0);
            bonusAwardedBySearchInput.SendKeys("oumsalem, sofiane");

            SeleniumDriver.ClickElement(commonPO.GetGoBtn());
            bonusAwardedSelecRadioBtn.Click();
            selectBtnsList[0].Click();

            SeleniumDriver.Instance.SwitchTo().Window(lstWindow[0]);
            paymentCommentsInput.SendKeys("For testing");
            applyOrNextBonusBtn.Click();
            applyOrNextBonusBtn.Click();

            AddAttachmentsAdditionalInfo();
            submitInReviewConfirmationBtn.Click();
        }


        /// <summary>
        /// Adds attachment and fills Attachment Summary with Text option
        /// as define attachment
        /// </summary>
        private void AddAttachmentsAdditionalInfo()
        {
            SeleniumDriver.ClickElement(commonPO.GetAddBtn());
            titleAttachmentInput.SendKeys("Test");
            descrptionAttachmentTextArea.SendKeys("For Testing");
            defineAttachmentTextRadioBtn.Click();
            descriptionTextAreaAttachment.SendKeys("For Testing");
            applyAttachmentBtn.Click();
        }

        /// <summary>
        /// Selects an employee in People Hierarchy to then perform an especific
        /// action against that employee.
        /// </summary>
        private void SelectEmployeeInPeopleHierarchy()
        {
            SeleniumDriver.SetValue(commonPO.GetNameSearchInputField(), "laidoson");
            SeleniumDriver.ClickElement(commonPO.GetGoBtn());
            SeleniumDriver.ClickElement(commonPO.GetSelectNameInputCheckBox());
            SeleniumDriver.ClickElement(commonPO.GetDoActionIcon());

        }

        /// <summary>
        /// Utils: Gets an specific day of the week based on today's date
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="day"></param>
        /// <returns>date wanted</returns>
        private string GetNextWeekDay(DateTime startDate, DayOfWeek day)
        {
            int daysToAdd = ((int)day - (int)startDate.DayOfWeek + 7) % 7;
            return startDate.AddDays(daysToAdd).Date.ToString("dd-MMM-yyyy");
        }

        public void ApproveChanges()
        {
            SeleniumDriver.SelectDropDownByText(workFlowPO.GetOpenNotificationsSelect(), "All Notifications");
            SeleniumDriver.ClickElement(workFlowPO.GetGoNotificationsBtn());
            SeleniumDriver.ClickElement(workFlowPO.GetSubjectLink());
        }

        public void ConfirmDefaultProcess()
        {
            ConfDefaultProcessRunsPatterns = new ConfDefaultProcessRunsObjects();
            commonPatterns = new CommonPaternObjects();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetNoBtn);

            sikuliHelper.SetInputValue(ConfDefaultProcessRunsPatterns.GetFullName, "oumsalem");

            sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetFindBtn);

            sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetName);

            while (counter1 > 0)
            {
                sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetDownArrow);
                counter1--;
            }

            sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetNewHire);

            sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetDesktopActivities);

            sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetEnrollmentResults);

        }



    }

}