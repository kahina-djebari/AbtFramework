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
        private OracleFormsPttnObj patterns;
        private CommonPttnObj commonPatterns;
        private GradeRatePttnObj gradePatterns;
        private AbtHRMSManagerPttnObj HRMSManagerPatterns;
        private ConfDefaultProcessRunsPttnObj ConfDefaultProcessRunsPatterns;
        private LifeEventPttnObj LifeEventPatterns;
        private ConfProcessPttnObj ConfProcessPatterns;
        private SubmitReportPttnObj submitReportPatterns;
        private SikuliHelper sikuliHelper;
        private AbtUSAPSuperUserPttnObj APSuperUserPatterns;

        //page objects
        private LoginPagePO loginPagePO;
        private CommonPO commonPO = new CommonPO();
        private TimeCardPO timeCardPO = new TimeCardPO();
        private iProcurementRequesterPO iprocurementRequesterPO = new iProcurementRequesterPO();
        private AbtUSPOBuyerPO buyerRequisitionPO = new AbtUSPOBuyerPO();
        private AbtUSEmployeeDirectAccessPO employeeDirectAccessPO = new AbtUSEmployeeDirectAccessPO();
        private AbtHRUserPO abtHRUserPO = new AbtHRUserPO();
        private AbtHROperationsSelfServicePO operationsSelfPO = new AbtHROperationsSelfServicePO();
        private WorkflowUserWebAppPO workFlowPO = new WorkflowUserWebAppPO();
        private AbtUSAPSuperUserPO APSuperUserPO = new AbtUSAPSuperUserPO();

        public const string MyAccountPageTitle = "My Account";
        private int counter = 11;
        private int counter1 = 15;



        /// <summary>
        /// Goes to Oracle Link
        /// </summary>
        public void GoToOracleDev()
        {
    
            StartTimer();
            SeleniumDriver.GoTo("https://abterp2.coresys.com/OA_HTML/AppsLocalLogin.jsp");
            SeleniumDriver.WaitForDOMready();
       

        }


        /// <summary>
        /// Login in Oracle Page
        /// </summary>
        /// <param name="user"></param>
        public void Login(string user)
        {

            loginPagePO = new LoginPagePO();
            SeleniumDriver.SetValue(loginPagePO.GetUserNameInput(), user);
            if (user.Contains("Jackson"))
                SeleniumDriver.SetValue(loginPagePO.GetPasswordInput(), "test123456789");
            else
                SeleniumDriver.SetValue(loginPagePO.GetPasswordInput(), "test123456");
            SeleniumDriver.ClickElement(loginPagePO.GetLoginBtn());
            SeleniumDriver.WaitForDOMready();

        }

        /// <summary>
        /// Clicks all links in Navigator home page
        /// </summary>
        public void ClickAllLinksInNavigator()
        {
            List<IWebElement> linksList = commonPO.GetAllLinksToClickInNavigator();

            for (int i = 0; i < linksList.Count; i++)
            {
                string att = linksList[i].GetAttribute("src");
                SeleniumDriver.ClickElement(linksList[i]);

                if (att.Contains("sswa"))
                {
                    SeleniumDriver.NavigateBack();
                    SeleniumDriver.WaitForDOMready();
                    linksList = commonPO.GetAllLinksToClickInNavigator();

                }
                else if (SeleniumDriver.GetCurrentBrowserName().Contains("explorer"))
                {
                    Thread.Sleep(10000);
                }
                else
                {
                    Thread.Sleep(3000);
                    SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.GetCurrentBrowserWindows()[1]);
                    SeleniumDriver.Close();
                    SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.GetCurrentBrowserWindows()[0]);
                }

            }

        }



        /// <summary>
        /// Clicks on the Home Page folder list specify by the option.
        /// can work on any "a" element of the DOM
        /// </summary>
        /// <param name="option"></param>
        public void ClickMainMenuTableOption(string option)
        {
            SeleniumDriver.ClickElement(commonPO.GetSelectHomePageLinkFolder(option));
            SeleniumDriver.WaitForDOMready();


        }

        /// <summary>
        /// Clicks and goes back
        /// </summary>
        /// <param name="option"></param>
        public void ClickRightSideMenuTableOptions(string option)
        {
            SeleniumDriver.ClickElement(commonPO.GetSelectHomePageLinkFolder(option));
            SeleniumDriver.WaitForDOMready();
            SeleniumDriver.NavigateBack();
            SeleniumDriver.WaitForDOMready();

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
            for (int i = 0; i < inputList.Count; i++)
            {
                if (i < 2)
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
            SeleniumDriver.WaitForDOMready();
            SeleniumDriver.SetValue(iprocurementRequesterPO.GetItemDescription(), "Test Description");
            SeleniumDriver.SetValue(iprocurementRequesterPO.GetQuantity(), "160");
            SeleniumDriver.SetValue(iprocurementRequesterPO.GetUnitOfMeasure(), "Hour");

            SeleniumDriver.SetValue(iprocurementRequesterPO.GetUnitPrice(), "20");

            SeleniumDriver.SetValue(iprocurementRequesterPO.GetSupplierName(), "Think Forward Consulting");

            Thread.Sleep(1000);
            SeleniumDriver.SetValue(iprocurementRequesterPO.GetContactName(), "Test Contant Name");

            SeleniumDriver.SetValue(iprocurementRequesterPO.GetPhone(), "8099880000");

            SeleniumDriver.ClickElement(iprocurementRequesterPO.GetAddToCart());
            SeleniumDriver.ClickElement(iprocurementRequesterPO.GetViewCartAndCheckout());

        }
        public void clickCheckOut()
        {
            SeleniumDriver.ClickElement(iprocurementRequesterPO.GetCheckout());

        }
        
        public void fillRequisitionInformation()
        {
            SeleniumDriver.SetValue(iprocurementRequesterPO.GetProject(), "21553");
            iprocurementRequesterPO.GetProject().SendKeys(Keys.Tab);
            Thread.Sleep(1000);

            SeleniumDriver.SetValue(iprocurementRequesterPO.GetTask(), "1100");
            Thread.Sleep(1000);

            SeleniumDriver.SetValue(iprocurementRequesterPO.GetExpenditureType(), "Misc Professional Sv");
            Thread.Sleep(1000);

            //Console.WriteLine(DateTime.Today.ToString("dd-MMMM-yyyy"));
            SeleniumDriver.SetValue(iprocurementRequesterPO.GetExpenditureItemDate(), string.Format("{0:dd-MMM-yyyy}", DateTime.Today));
            Thread.Sleep(1000);

            SeleniumDriver.ClickElement(iprocurementRequesterPO.GetNextButtons());

        }

        public void addAfterApprover(string approver)
        {
            SeleniumDriver.ClickElement(iprocurementRequesterPO.GetManageApprovals());
            SeleniumDriver.SetValue(iprocurementRequesterPO.GetNewApproverText(), approver);

            SeleniumDriver.ClickElement(commonPO.GetSubmitButton_uixr());

        }
        public void SubmitAfterApprovers()
        {
            SeleniumDriver.ClickElement(iprocurementRequesterPO.GetApprovalNextButton());
        }

        public void submitApproval()
        {
            SeleniumDriver.ClickElement(commonPO.GetSubmitButton_uixr());
            SeleniumDriver.ClickElement(iprocurementRequesterPO.GetContinueShoppingButton());
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

        public void addCreateRequisition()
        {
            SeleniumDriver.ClickElement(buyerRequisitionPO.GetAddRequisitionButton());
            SeleniumDriver.ClickElement(buyerRequisitionPO.GetCreateButton());

        }



        public static bool IsAt()
        {
            return SeleniumDriver.Instance.Title.Equals("Search");
        }


        public void chooseVeteranStatus()
        {
            SeleniumDriver.ClickElement(commonPO.GetUpdateBtn());

            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetSearchVeteranStatusBtn());
            Thread.Sleep(2000);
            // Store all the opened window into the 'list' 
            List<string> lstWindow = SeleniumDriver.Instance.WindowHandles.ToList();
            SeleniumDriver.Instance.SwitchTo().Window(lstWindow[1]);
            SeleniumDriver.Instance.SwitchTo().Frame(0);

            SeleniumDriver.ClearValue(employeeDirectAccessPO.GetSearchVeteranStatusInputBox());
            SeleniumDriver.ClickElement(commonPO.GetGoBtn());
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetSelectRadioBtn());
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetSelectStatusBtn());

            SeleniumDriver.Instance.SwitchTo().Window(lstWindow[0]);
            SeleniumDriver.ClearValue(employeeDirectAccessPO.GetDateInput());
            SeleniumDriver.SetValue(employeeDirectAccessPO.GetDateInput(), string.Format("{0:dd-MMM-yyyy}", DateTime.Today));
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetApplyBtn());
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetNextBtn());
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetSubmitBtn());
            SeleniumDriver.ClickElement(commonPO.GetGoHomeBtn());
          


        }

        public void DoDiscovererWorkbookMultipleSheets()
        {
            SeleniumDriver.ClickElement(abtHRUserPO.GetDetailActiveEmployeeOptn());
            ClickMainMenuTableOption("Modified Detail Active Emp Listing");

        }

        public void DoDiscovererWorkbookOneSheet()
        {
            int count = 0;
            List<IWebElement> list = abtHRUserPO.GetSelectToExpandIcons();
            //to expand all menus first
            while (list != null && list.Count != 0)
            {
                SeleniumDriver.ClickElement(list[0]);
                list = abtHRUserPO.GetSelectToExpandIcons();

            }

            List<IWebElement> expList = abtHRUserPO.GetExpandedOptionToClick();
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
            patterns = new OracleFormsPttnObj();
            commonPatterns = new CommonPttnObj();
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
            patterns = new OracleFormsPttnObj();
            commonPatterns = new CommonPttnObj();
            sikuliHelper = SikuliHelper.GetInstance();

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
            gradePatterns = new GradeRatePttnObj();
            commonPatterns = new CommonPttnObj();

            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(commonPatterns.GetOkNotificationsNote);

            sikuliHelper.ClickPattern(commonPatterns.GetNoBtn);

            sikuliHelper.ClickPattern(commonPatterns.GetView);

            sikuliHelper.ClickPattern(commonPatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(commonPatterns.GetEnter);

            sikuliHelper.SetInputValue(gradePatterns.GetNameField, "%");

            sikuliHelper.ClickPattern(commonPatterns.GetView);

            sikuliHelper.ClickPattern(commonPatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(commonPatterns.GetRun);

            sikuliHelper.ClickPattern(gradePatterns.GetGradeNameField);

            sikuliHelper.ClickPattern(commonPatterns.GetView);

            sikuliHelper.ClickPattern(commonPatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(commonPatterns.GetEnter);

            sikuliHelper.SetInputValue(gradePatterns.GetGradeNameInputField, "%Can%");

            sikuliHelper.ClickPattern(commonPatterns.GetView);

            sikuliHelper.ClickPattern(commonPatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(commonPatterns.GetRun);

            sikuliHelper.ClickPattern(commonPatterns.GetView);

            sikuliHelper.ClickPattern(commonPatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(commonPatterns.GetEnter);

            sikuliHelper.SetInputValue(gradePatterns.GetGradeNameInputField, "%Mex%");

            sikuliHelper.ClickPattern(commonPatterns.GetView);

            sikuliHelper.ClickPattern(commonPatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(commonPatterns.GetRun);
        }

        /// <summary>
        /// Oracle Form: Click No button (no need to change the date), type in Employee Name, and Click Find button
        /// </summary>
        /// <param name="employeeName"></param>
        /// 
        public void FindEmployeeName(string employeeName)
        {
            commonPatterns = new CommonPttnObj();
            sikuliHelper = SikuliHelper.GetInstance();

            sikuliHelper.ClickPattern(commonPatterns.GetNoBtn);

            sikuliHelper.SetInputValue(commonPatterns.GetFullName, employeeName);

            sikuliHelper.ClickPattern(commonPatterns.GetFindBtn);
        }

        public void UpdateInformationOnOracleForm()
        {
            HRMSManagerPatterns = new AbtHRMSManagerPttnObj();
            commonPatterns = new CommonPttnObj();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(commonPatterns.GetOkNotificationsNote);

            FindEmployeeName("oumsalem, sofiane");


            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetOfficeDetails);

            sikuliHelper.SetInputValue(HRMSManagerPatterns.GetOfficeInputField, "test");

            sikuliHelper.PressEnter();

            sikuliHelper.ClickPattern(HRMSManagerPatterns.GetCorrectionBtn);

            sikuliHelper.ClickPattern(commonPatterns.GetSaveIcon);

            sikuliHelper.ClickPattern(commonPatterns.GetCloseOracleForm);

            sikuliHelper.ClickPattern(commonPatterns.GetOkBtnCloseOracleForm);
        }



        /// <summary>
        /// Update the Office Details and confirm that there is no link 
        /// for Discoverer Viewer in the list of responsibilities.      
        /// </summary>
        /// 
        public void GoToOracleForm()
        {
            HRMSManagerPatterns = new AbtHRMSManagerPttnObj();
            commonPatterns = new CommonPttnObj();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(commonPatterns.GetOkNotificationsNote);

            FindEmployeeName("oumsalem, sofiane");

            sikuliHelper.ClickPattern(commonPatterns.GetCloseOracleForm);

            sikuliHelper.ClickPattern(commonPatterns.GetOkBtnCloseOracleForm);

            sikuliHelper.ClickPattern(commonPatterns.GetCloseWindow);

        }

        public void ChangeTimecardApprover()
        {
            SelectEmployeeInPeopleHierarchy();

            string nextSaturday = GetNextWeekDay(DateTime.Today.AddDays(1), DayOfWeek.Saturday);
            SeleniumDriver.SetValue(operationsSelfPO.GetEffectiveDateInput(), nextSaturday);

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

            string nextSaturday = GetNextWeekDay(DateTime.Today.AddDays(1), DayOfWeek.Saturday);
            SeleniumDriver.SetValue(operationsSelfPO.GetEffectiveDateInput(), nextSaturday);
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
            SeleniumDriver.SetValue(operationsSelfPO.GetCommentsTextArea(), "For Testing");
            SeleniumDriver.ClickElement(operationsSelfPO.GetNextBtnAfterReason());

            AddAttachmentsAdditionalInfo();

            SeleniumDriver.ClickElement(operationsSelfPO.GetSubmitInReviewConfirmationBtn());



        }
        /// <summary>
        /// Performs Spot Bonus action against an employee.
        /// </summary>
        public void DoSpotBonus()
        {
            SelectEmployeeInPeopleHierarchy();

            SeleniumDriver.ClickElement(commonPO.GetAddBtn());

            if (!operationsSelfPO.GetPaymentTypeInput().GetAttribute("value").Equals("SP"))
                Assert.Fail("Error: SP value not present in Payment Input");

            string nextSaturday = GetNextWeekDay(DateTime.Today.AddDays(1), DayOfWeek.Saturday);
            SeleniumDriver.SetValue(operationsSelfPO.GetPaymentDateInput(), nextSaturday);
            SeleniumDriver.SetValue(operationsSelfPO.GetPaymentAmountInput(), "100");
            SeleniumDriver.ClickElement(operationsSelfPO.GetPaymentBonusAwardedByIcon());

            Thread.Sleep(2000);
            // Store all the opened window into the 'list' 
            List<string> lstWindow = SeleniumDriver.Instance.WindowHandles.ToList();
            SeleniumDriver.Instance.SwitchTo().Window(lstWindow[1]);
            SeleniumDriver.Instance.SwitchTo().Frame(0);

            SeleniumDriver.SetValue(operationsSelfPO.GetBonusAwardedBySearchInput(), "oumsalem, sofiane");
            SeleniumDriver.ClickElement(commonPO.GetGoBtn());
            SeleniumDriver.ClickElement(operationsSelfPO.GetBonusAwardedSelecRadioBtn());
            SeleniumDriver.ClickElement(operationsSelfPO.GetSelectBtnsList());


            SeleniumDriver.Instance.SwitchTo().Window(lstWindow[0]);
            SeleniumDriver.SetValue(operationsSelfPO.GetPaymentCommentsInput(), "For testing");
            SeleniumDriver.ClickElement(operationsSelfPO.GetApplyOrNextBonusBtn());
            SeleniumDriver.ClickElement(operationsSelfPO.GetApplyOrNextBonusBtn());

            AddAttachmentsAdditionalInfo();
            SeleniumDriver.ClickElement(operationsSelfPO.GetSubmitInReviewConfirmationBtn());
        }


        /// <summary>
        /// Adds attachment and fills Attachment Summary with Text option
        /// as define attachment
        /// </summary>
        private void AddAttachmentsAdditionalInfo()
        {
            SeleniumDriver.ClickElement(commonPO.GetAddBtn());
            SeleniumDriver.SetValue(operationsSelfPO.GetTitleAttachmentInput(), "Testing");
            SeleniumDriver.SetValue(operationsSelfPO.GetDescrptionAttachmentTextArea(), "For Testing");
            SeleniumDriver.ClickElement(operationsSelfPO.GetDefineAttachmentTextRadioBtn());
            SeleniumDriver.SetValue(operationsSelfPO.GetDescriptionTextAreaAttachment(), "Testing");
            SeleniumDriver.ClickElement(operationsSelfPO.GetApplyAttachmentBtn());

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
            ConfDefaultProcessRunsPatterns = new ConfDefaultProcessRunsPttnObj();
            commonPatterns = new CommonPttnObj();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(commonPatterns.GetOkNotificationsNote);

            FindEmployeeName("oumsalem, sofiane");

            sikuliHelper.ClickPattern(commonPatterns.GetName);

            while (counter1 > 0)
            {
                sikuliHelper.ClickPattern(commonPatterns.GetDownArrow);
                counter1--;
            }

            sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetNewHire);

            sikuliHelper.ClickPattern(commonPatterns.GetDesktopActivities);

            sikuliHelper.ClickPattern(ConfDefaultProcessRunsPatterns.GetEnrollmentResults);

        }

        //To add a Life Event (LE) and enroll in benefits
        public void LifeEventEnrollBenefits()
        {
            LifeEventPatterns = new LifeEventPttnObj();
            commonPatterns = new CommonPttnObj();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(commonPatterns.GetOkNotificationsNote);

            FindEmployeeName("Poodts, Mauricio");

            sikuliHelper.ClickPattern(commonPatterns.GetDesktopActivities);

            sikuliHelper.ClickPattern(commonPatterns.GetViewPersonLifeEvents);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetPotentialLifeEventsTab);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetDownArrow);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetLastEventRecorded);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetNewIcon);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetSelectBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetAbtAdminLE);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetOkBtnValidateLEReason);
            Thread.Sleep(1000);
            sikuliHelper.ClickPattern(LifeEventPatterns.GetSelectBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetSelectLEDate);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetOkBtnValidateLEDate);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetSelectBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetUnprocessedField);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetSelectBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetSelectLEDate);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetOkBtnValidateLEDate);

            sikuliHelper.ClickPattern(commonPatterns.GetSaveIcon);

            sikuliHelper.ClickPattern(commonPatterns.GetCloseOracleWindows);

            sikuliHelper.ClickPattern(commonPatterns.GetDesktopActivities);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetProcessLifeEvents);

            if(LifeEventPatterns.GetYesToCloseActiveLE != null)
            {
                sikuliHelper.ClickPattern(LifeEventPatterns.GetYesToCloseActiveLE);
            }

            sikuliHelper.ClickPattern(LifeEventPatterns.GetCommitAndProceedBtn);

            sikuliHelper.ClickPattern(commonPatterns.GetCloseOracleWindows);

            sikuliHelper.ClickPattern(commonPatterns.GetDesktopActivities);

            sikuliHelper.ClickPattern(commonPatterns.GetViewPersonLifeEvents);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetLatestLE);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetEnrollmentOpportunitiesBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetEndDateInputField);

            sikuliHelper.SetInputValue(LifeEventPatterns.GetEndDateInputField, DateTime.Today.ToString("dd-MMM-yyyy"));

            sikuliHelper.ClickPattern(commonPatterns.GetSaveIcon);
            Thread.Sleep(1000);
            sikuliHelper.ClickPattern(commonPatterns.GetCloseOracleWindows);
            Thread.Sleep(1000);
            sikuliHelper.ClickPattern(commonPatterns.GetCloseOracleWindows);
            Thread.Sleep(1000);
            sikuliHelper.ClickPattern(commonPatterns.GetCloseOracleWindows);
            Thread.Sleep(1000);
            sikuliHelper.ClickPattern(LifeEventPatterns.GetSwitchResponsabilityIcon);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetAbtOAB);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetOkBtnValidateAbtOAB);
            Thread.Sleep(2000);
            sikuliHelper.DoubleClickPattern(LifeEventPatterns.GetBenefitsOption);

            sikuliHelper.ClickPattern(commonPatterns.GetMaximizeWindow);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetReturnToPeopleInHierarchyLink);

            sikuliHelper.SetInputValue(LifeEventPatterns.GetEmployeeNameInputField, "Poodts");

            sikuliHelper.ClickPattern(LifeEventPatterns.GetGoBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetActionIcon);
            
            sikuliHelper.ClickPattern(LifeEventPatterns.GetNextBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetAddAnotherPersonBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetSelectRelationship); 

            sikuliHelper.ClickPattern(LifeEventPatterns.GetSelectChild);

            sikuliHelper.SetInputValue(LifeEventPatterns.GetRelationshipStartDateInput, "11-Dec-2017");

            sikuliHelper.SetInputValue(LifeEventPatterns.GetFNameInputField, "Max");

            sikuliHelper.SetInputValue(LifeEventPatterns.GetLNameInputField, "Poodts");

            sikuliHelper.ClickPattern(LifeEventPatterns.GetSharedResidenceCheckBox);

            while (counter > 0)
            {
                sikuliHelper.ClickPattern(LifeEventPatterns.GetScrollDown);
                counter--;
            }

            sikuliHelper.ClickPattern(LifeEventPatterns.GetGenderSelect);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetMale);

            sikuliHelper.SetInputValue(LifeEventPatterns.GetDOBInputField, "11-Dec-2017");

            sikuliHelper.ClickPattern(LifeEventPatterns.GetApplyBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetNextBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetUpdateBenefitsBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetNextBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetCoverCheckBox);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetNextBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetNextBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetNextBtn);

            sikuliHelper.ClickPattern(LifeEventPatterns.GetFinishBtn);

            //Store all the opened window into the 'list' 
            //List<string> lstWindow = SeleniumDriver.Instance.WindowHandles.ToList();
            //SeleniumDriver.Instance.SwitchTo().Window(lstWindow[0]);
            //SeleniumDriver.ClickElement(operationsSelfPO.GetReturnToPeopleInHierarchyLink());       
            //SeleniumDriver.SetValue(commonPO.GetNameSearchInputField(), "Stinson");
            //SeleniumDriver.ClickElement(commonPO.GetGoBtn());
            //SeleniumDriver.ClickElement(commonPO.GetDoActionIcon());
            //SeleniumDriver.ClickElement(commonPO.GetNextChangeSessionDate());
            //SeleniumDriver.ClickElement(employeeDirectAccessPO.GetAddAnotherPersonBtn());
            //SeleniumDriver.SelectDropDownByText(employeeDirectAccessPO.GetSelectRelationship(), "Child");
            //SeleniumDriver.SetValue(commonPO.GetRelationshipStartDateInputField(), "11-Dec-2017");
            //SeleniumDriver.SetValue(employeeDirectAccessPO.GetBeneficiaryFirstName(), "Maxim");
            //SeleniumDriver.SetValue(employeeDirectAccessPO.GetBeneficiaryLastName(), "Stinson");
            //SeleniumDriver.ClickElement(employeeDirectAccessPO.GetSharedResidenceCheckBox());
            //SeleniumDriver.SelectDropDownByText(employeeDirectAccessPO.GetSelectGender(), "Male");
            //SeleniumDriver.SetValue(employeeDirectAccessPO.GetDOBInputField(), "11-Dec-2017");
            //SeleniumDriver.ClickElement(employeeDirectAccessPO.GetApplyNewBeneficiary());
            //SeleniumDriver.ClickElement(employeeDirectAccessPO.GetNextToUpdateBeneficiaries());
            //SeleniumDriver.ClickElement(employeeDirectAccessPO.GetUpdateBenefitsBtn());
            //SeleniumDriver.ClickElement(employeeDirectAccessPO.GetNextBtnUpdateEnrollments());
            //SeleniumDriver.ClickElement(employeeDirectAccessPO.GetCoverCheckBox());
            //SeleniumDriver.ClickElement(employeeDirectAccessPO.GetNextBtnCoverDependants());
            //SeleniumDriver.ClickElement(employeeDirectAccessPO.GetNextBtnUpdateBeneficiaries());
            //SeleniumDriver.ClickElement(employeeDirectAccessPO.GetNextBtnCareProviders());
            //SeleniumDriver.ClickElement(employeeDirectAccessPO.GetFinishBtnConfirmation());
        }

        public void UpdatePersonalInformation()
        {
            // Update Middle Name in Basic Details section
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetUpdateBasicDetails());
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetNextChooseBtn());
            SeleniumDriver.SetValue(employeeDirectAccessPO.GetMiddleNameInputField(), "Liam");
            SeleniumDriver.ClearValue(employeeDirectAccessPO.GetEffectiveDateBasicDetails());
            SeleniumDriver.SetValue(employeeDirectAccessPO.GetEffectiveDateBasicDetails(), string.Format("{0:dd-MMM-yyyy}", DateTime.Today.AddDays(1)));
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetNextChooseBtn());
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetCancelInfoChanges());
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetYesBtn());

            //Update phone number in Phone Numbers section
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetUpdatePhoneNumbers());
            SeleniumDriver.ClearValue(employeeDirectAccessPO.GetPhoneNumInputField());
            SeleniumDriver.SetValue(employeeDirectAccessPO.GetPhoneNumInputField(), "585-831-2417");
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetNextPhoneNumBtn());
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetCancelInfoChanges());
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetYesBtn());

            //Update Middle Name of the Emergency Contact
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetUpdateEmergencyContacts());
            SeleniumDriver.SetValue(employeeDirectAccessPO.GetMiddleNameInputField(), "Ania");
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetNextEmergencyContact());
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetCancelInfoChanges());
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetYesBtn());
        }

        public void AddBeneficiaries()
        {
            //to confirm that we can change the time period to see past elections
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetNextToUpdateBeneficiaries());
            SeleniumDriver.SelectDropDown(employeeDirectAccessPO.GetSelectElectionsDate(), 2);
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetGoToElections());
            SeleniumDriver.SelectDropDown(employeeDirectAccessPO.GetSelectElectionsDate(), 0);
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetGoToElections());

            //to add beneficiaries 
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetUpdateBeneficiariesBtn());
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetAddAnotherPersonBtn());
            SeleniumDriver.SelectDropDownByText(employeeDirectAccessPO.GetSelectRelationship(), "Child");
            SeleniumDriver.SetValue(employeeDirectAccessPO.GetBeneficiaryFirstName(), "Nina");
            SeleniumDriver.SetValue(employeeDirectAccessPO.GetBeneficiaryLastName(), "Oumsalem");
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetSharedResidenceCheckBox());
            SeleniumDriver.SelectDropDownByText(employeeDirectAccessPO.GetSelectGender(), "Female");
            SeleniumDriver.SetValue(employeeDirectAccessPO.GetDOBInputField(), "27-Nov-2017");
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetApplyNewBeneficiary());
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetNextToUpdateBeneficiaries());
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetNextToConfirmation()); 
            SeleniumDriver.ClickElement(employeeDirectAccessPO.GetFinishBtn());
           
        }

        /// <summary>
        /// Confirm that terminate process was run successfully
        /// </summary>

        public void ConfirmTerminateProcessSuccess()
        {
            ConfProcessPatterns = new ConfProcessPttnObj();
            commonPatterns = new CommonPttnObj();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(commonPatterns.GetOkNotificationsNote);

            FindEmployeeName("oumsalem, sofiane");

            sikuliHelper.ClickPattern(commonPatterns.GetName);

            while (counter1 > 0)
            {
                sikuliHelper.ClickPattern(commonPatterns.GetDownArrow);
                counter1--;
            }

            sikuliHelper.ClickPattern(commonPatterns.GetDesktopActivities);

            sikuliHelper.ClickPattern(commonPatterns.GetViewPersonLifeEvents);

        }

        /// <summary>
        /// Submit a 'Abt HSA Bi Weekly Employer Funding – STEP ONE Report' and make sure that 
        /// the log of requests was uploaded correctly and opens in IE. 
        /// </summary>
        public void submitReport()
        {
            submitReportPatterns = new SubmitReportPttnObj();
            commonPatterns = new CommonPttnObj();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(commonPatterns.GetOkNotificationsNote);

            sikuliHelper.ClickPattern(submitReportPatterns.GetOkBtnRequestType);

            sikuliHelper.ClickPattern(submitReportPatterns.GetSelectReportType);

            sikuliHelper.ClickPattern(submitReportPatterns.GetSelectReportType);

            while (counter1 > 0)
            {
                sikuliHelper.ClickPattern(submitReportPatterns.GetScrollDownArrow);
                counter1--;
            }

            sikuliHelper.ClickPattern(submitReportPatterns.GetReportTypeToChoose);

            sikuliHelper.ClickPattern(submitReportPatterns.GetOkBtnValidateReportType);

            sikuliHelper.ClickPattern(submitReportPatterns.GetSubmitReportBtn);

            sikuliHelper.ClickPattern(submitReportPatterns.GetOkToRequestSubmission);

            sikuliHelper.ClickPattern(submitReportPatterns.GetNoToSubmitAnotherRequest);

            ClickMainMenuTableOption("Abt HRMS Benefits User");

            ClickMainMenuTableOption("View Requests");

            sikuliHelper.ClickPattern(submitReportPatterns.GetFindRequestsBtn);

            sikuliHelper.ClickPattern(submitReportPatterns.GetViewLogBtn);

        }

        public void ExtractResults()
        {
            commonPatterns = new CommonPttnObj();
            sikuliHelper = SikuliHelper.GetInstance();

            AcceptJavaAlert();

            sikuliHelper.ClickPattern(commonPatterns.GetOkNotificationsNote);

            sikuliHelper.ClickPattern(commonPatterns.GetView);

            sikuliHelper.ClickPattern(commonPatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(commonPatterns.GetEnter);

            sikuliHelper.ClickPattern(commonPatterns.GetView);

            sikuliHelper.ClickPattern(commonPatterns.GetQueryByExample);

            sikuliHelper.ClickPattern(commonPatterns.GetRun);

            //sikuliHelper.ClickPattern(commonPatterns.GetDownArrowKey);  //using the on-screen keyboard

            //sikuliHelper.PressDownArrow();

        }

        /// <summary>
        /// Create and validate a quick invoice using the oracle form
        /// </summary>
        public void CreateQuickInvoice()
        {
            sikuliHelper = SikuliHelper.GetInstance();
            APSuperUserPatterns = new AbtUSAPSuperUserPttnObj();
           
            //We have to change the Batch Name and the Invoice Number every time we run the test
            SeleniumDriver.ClickElement(APSuperUserPO.GetQuickInvoicesLink());
            AcceptJavaAlert();
            Thread.Sleep(7000);
            sikuliHelper.SetInputValue(APSuperUserPatterns.GetBatchInputField, "Quick Invoices Test 2");
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetEnterBtn);
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetTypeField);
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetSelectBtn);
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetOkBtn);
            sikuliHelper.SetInputValue(APSuperUserPatterns.GetInvoiceNumInput, "07");
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetInvoiceDateField);
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetSelectBtn);
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetSelectedDate);
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetOkDate);
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetSupplierField);
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetSelectBtn);
            sikuliHelper.SetInputValue(APSuperUserPatterns.GetFindInputField, "test");
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetFindBtn);
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetOkBtn);
            sikuliHelper.SetInputValue(APSuperUserPatterns.GetInvoiceAmountInput, "3000");
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetLineNumInput);
            sikuliHelper.SetInputValue(APSuperUserPatterns.GetLineNumInput, "01");
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetLineTypeField);
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetSelectBtn);
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetOkBtn);
            sikuliHelper.SetInputValue(APSuperUserPatterns.GetAmountInputField, "3000");
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetCreateInvoicesBtn);
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetOkBtn);
            sikuliHelper.ClickPattern(APSuperUserPatterns.GetOkBtnProcessingInvoiceNote);

        }

    }

}