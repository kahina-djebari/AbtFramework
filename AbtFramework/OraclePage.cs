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

        public const string MyAccountPageTitle = "My Account";
        private int counter = 11;
        private int counter1 = 8;



       
        // 	Voluntary Disclosure of Veterans Status

        [FindsBy(How = How.XPath, Using = "//input[@title='Select'][value='0']")]
        private IWebElement selectStatus1;

        [FindsBy(How = How.XPath, Using = "//input[@title='Select'][value='1']")]
        private IWebElement selectStatus2;

        [FindsBy(How = How.XPath, Using = "//input[@title='Select'][value='2']")]
        private IWebElement selectStatus3;

        [FindsBy(How = How.XPath, Using = "//span[text()='Quick Select']/parent::th/parent::tr/following-sibling::tr[1]/child::td[2]/child::a/img")]
        private IWebElement quickSelect1;

        [FindsBy(How = How.XPath, Using = "//span[text()='Quick Select']/parent::th/parent::tr/following-sibling::tr[2]/child::td[2]/child::a/img")]
        private IWebElement quickSelect2;

        [FindsBy(How = How.XPath, Using = "//span[text()='Quick Select']/parent::th/parent::tr/following-sibling::tr[3]/child::td[2]/child::a/img")]
        private IWebElement quickSelect3;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Search and Select: Choose Your Veteran Status']/ancestor::div[1]/following-sibling::div[1]//button[text()='Select']")]
        private IWebElement selectBtn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Enter Your Name')]/parent::td/following-sibling::td[2]/input")]
        private IWebElement enterYourName;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Enter Your Name')]/parent::td/parent::tr/following-sibling::tr/child::td[3]//child::input")]
        private IWebElement date;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Voluntary Disclosure of Veterans Status']/ancestor::div[1]/following-sibling::div[1]//button[@title='Apply']")]
        private IWebElement applyBtn;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Extra Information']/ancestor::div[1]/following-sibling::div//descendant::button[text()='Save For Later']")]
        private IWebElement saveForLater;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Extra Information']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']")]
        private IWebElement nextBtn;

        [FindsBy(How = How.XPath, Using = "//button[@title='Add']")]
        private IWebElement addAttachments;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Review']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Submit']")]
        private IWebElement submitBtn;

        [FindsBy(How = How.XPath, Using = "//button[@title='Home']")]
        private IWebElement homeBtn;


        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Detail Active Employee')]/preceding-sibling::a//img")]
        private IWebElement detailActiveEmployeeOptn;

        [FindsBy(How = How.XPath, Using = "//img[@alt = 'Select to expand']")]
        private IList<IWebElement> selectToExpandIcons;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'javascript:discoOpen')]")]
        private IList<IWebElement> expandedOptionToClick;

        //Change timecard approver
        [FindsBy(How = How.XPath, Using = "//input[@title='Search Criteria']")]
        private IWebElement nameInputField;

        [FindsBy(How = How.XPath, Using = "//button[@title='Go']")]
        private IWebElement goButton;

        [FindsBy(How = How.XPath, Using = "//input[@title='Select']")]
        private IWebElement selectName;

        [FindsBy(How = How.XPath, Using = "//img[@title='Action']")]
        private IWebElement actionIcon;

        [FindsBy(How = How.XPath, Using = "//span[text()='Effective Date']/parent::td/following-sibling::td[2]//descendant::input")]
        private IWebElement effectiveDate;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Timecard Approver and Supervisor: Effective Date Options']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Continue']")]
        private IWebElement continueButton;

        [FindsBy(How = How.XPath, Using = "//input[@title='Manager']")]
        private IWebElement supervisorName;

        [FindsBy(How = How.XPath, Using = "//span[text()='Timecard Approver']/parent::td/following-sibling::td[2]//input")]
        private IWebElement timecardApprover;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Timecard Approver and Supervisor: Change Manager']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']")]
        private IWebElement nextBtnValidateChangeManager;

        [FindsBy(How = How.XPath, Using = "////span[contains(text(),'Reason')]/parent::td/following-sibling::td//select")]
        private IWebElement changeReasonSelect;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Timecard Approver and Supervisor: Assignment']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']")]
        private IWebElement nextBtnValidateAssignment;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Timecard Approver and Supervisor: Review']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Submit']")]
        private IWebElement submitChangeTimecardApproverSupervisor;

        //Change employee hours
        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Hours: Effective Date Options']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Continue']")]
        private IWebElement continueBtn;

        [FindsBy(How = How.XPath, Using = "//input[@title='Work Hours']")]
        private IWebElement workHoursInputField;

        [FindsBy(How = How.XPath, Using = "//span[text()='Assignment Category']/parent::td/following-sibling::td[2]//select")]
        private IWebElement assignmentCategory;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Hours: Work Schedule']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']")]
        private IWebElement nextBtnValidateWorkSchedule;

        [FindsBy(How = How.XPath, Using = "//button[@title='Propose Pay Change']")]
        private IWebElement proposePayChange;

        [FindsBy(How = How.XPath, Using = "//span[text()='Reason For Pay Change']/parent::td/following-sibling::td[2]//select")]
        private IWebElement reasonForPayChange;

        [FindsBy(How = How.XPath, Using = "//input[@title='Actual Pay Amount']")]
        private IWebElement actualPayAmount;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Hours: Pay Details']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Apply']")]
        private IWebElement applyButton;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Hours: Select A Pay Action']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']")]
        private IWebElement nextBtnValidatePayChangeProposal;

        [FindsBy(How = How.XPath, Using = "//h1[text()='Change Hours: Review']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Submit']")]
        private IWebElement submitChangeHours;

        //Approve changes of hours and timecard approver
        [FindsBy(How = How.XPath, Using = "//select[@title='Provides a series of worklist views available']")]
        private IWebElement openNotifications;

        [FindsBy(How = How.XPath, Using = "//button[@title='Launches some defined function']")]
        private IWebElement goNotifications;

        [FindsBy(How = How.XPath, Using = "//a[text()='Subject']/parent::th/parent::tr/following-sibling::tr[1]/child::td[4]/a")]
        private IWebElement subjectLink;

        //HRSS Transactions: Enter Voluntary Offboarding – Actor: HRBP
        [FindsBy(How = How.Name, Using = "Comments")]
        private IWebElement commentsTextArea;

        [FindsBy(How = How.Id, Using = "HrNext_uixr")]
        private IWebElement nextBtnAfterReason;


        [FindsBy(How = How.Name, Using = "FileName")]
        private IWebElement titleAttachmentInput;

        [FindsBy(How = How.Name, Using = "AkDescription")]
        private IWebElement descrptionAttachmentTextArea;

        [FindsBy(How = How.XPath, Using = "//span[text()= 'Text']//preceding-sibling::input")]
        private IWebElement defineAttachmentTextRadioBtn;

        [FindsBy(How = How.Id, Using = "Okay_uixr")]
        private IWebElement applyAttachmentBtn;

        [FindsBy(How = How.XPath, Using = "//textarea[@title='Attachment Text']")]
        private IWebElement descriptionTextAreaAttachment;

        [FindsBy(How = How.Id, Using = "HrSubmit")]
        private IWebElement submitInReviewConfirmationBtn; //works for any subit under review screen

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

            quickSelect2.Click();
            SeleniumDriver.Instance.SwitchTo().Window(lstWindow[0]);
            date.Clear();
            date.SendKeys(string.Format("{0:dd-MMM-yyyy}", DateTime.Today));
            applyBtn.Click();
            nextBtn.Click();
            submitBtn.Click();
            homeBtn.Click();

        }

        public void DoDiscovererWorkbookMultipleSheets()
        {
            Thread.Sleep(2000);
            detailActiveEmployeeOptn.Click();
            ClickMainMenuTableOption("Modified Detail Active Emp Listing");

        }

        public void DoDiscovererWorkbookOneSheet()
        {
            int count = 0;
            Thread.Sleep(1000);
            //to expand all menus first
            while (selectToExpandIcons.Count != 0)
            {
                selectToExpandIcons[0].Click();
                Thread.Sleep(1000);
                selectToExpandIcons = SeleniumDriver.Instance.FindElements(By.XPath("//img[@alt = 'Select to expand']"));

            }

            //to click on the expanded links
            while (count < expandedOptionToClick.Count)
            {
                expandedOptionToClick[count].Click();
                Thread.Sleep(1000);
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

            effectiveDate.SendKeys("09-Dec-2017");
            continueBtn.Click();
            supervisorName.Clear();
            supervisorName.SendKeys("poodts");
            supervisorName.SendKeys(Keys.Tab);
            nextBtnValidateChangeManager.Click();
            timecardApprover.Clear();
            timecardApprover.SendKeys("poodts");
            timecardApprover.SendKeys(Keys.Tab);
            Thread.Sleep(1000);
            SelectElement select = new SelectElement(changeReasonSelect);
            select.SelectByText("Supervisor & Timecard Approver Change");
            nextBtnValidateAssignment.Click();
            submitChangeTimecardApproverSupervisor.Click();
            homeBtn.Click();
        }

        public void ChangeEmployeeHours()
        {
            SelectEmployeeInPeopleHierarchy();

            effectiveDate.SendKeys("09-Dec-2017");
            continueBtn.Click();
            workHoursInputField.Clear();
            workHoursInputField.SendKeys("32");
            Thread.Sleep(1000);
            SelectElement select = new SelectElement(assignmentCategory);
            select.SelectByText("Parttime-Standard");
            nextBtnValidateWorkSchedule.Click();
            proposePayChange.Click();
            Thread.Sleep(1000);
            SelectElement selectReason = new SelectElement(reasonForPayChange);
            selectReason.SelectByText("Status Change");
            actualPayAmount.SendKeys("50000");
            applyButton.Click();
            applyButton.Click();
            nextBtnValidatePayChangeProposal.Click();
            submitChangeHours.Click();
        }

        /// <summary>
        /// Performs a offboarding (termination) to an employee
        /// </summary>
        public void DoOffboardEmployee()
        {
            SelectEmployeeInPeopleHierarchy();

            SelectElement select = new SelectElement(changeReasonSelect);
            select.SelectByText("Employee Transfer");

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
            addAttachments.Click();
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
            nameInputField.SendKeys("laidoson");
            goButton.Click();
            selectName.Click();
            actionIcon.Click();

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
            SelectElement select = new SelectElement(openNotifications);
            select.DeselectByText("All Notifications");
            goNotifications.Click();
            subjectLink.Click();
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