using System;
using AbtFramework;
using AbtFramework.Utils_Classes;
using TechTalk.SpecFlow;

namespace abtTest.Steps.Oracle
{
    [Binding]
    public sealed class OracleSteps
    {
        private static String gUser = "user";
        // kill all the selenium drivers after a successfull test.
        [AfterScenario]
        public void CleanUp()
        {
            SeleniumDriver.Quit();
        }
        
        [Given(@"I have Open IE Test")]
        public void GivenIHaveOpenIETest()
        {
            SeleniumDriver.init(Browser.IE);
        }

        [Given(@"I have Open Chrome")]
        public void GivenIHaveOpenChromeTest()
        {
            SeleniumDriver.init(Browser.Chrome);
        }

        [Given(@"I have navigated to Oracle Dev")]
        public void GivenIHaveNavigatedToOracleDev()
        {
            AbtPages.OraclePage.GoToOracleDev();
        }

        [Given(@"i login as ""(.*)""")]
        public void GivenILoginAs(string user)
        {
            gUser = user;          
            AbtPages.OraclePage.inputUserName(gUser);
            AbtPages.OraclePage.inputPasswordField(gUser);
            AbtPages.OraclePage.clickSubmitButton();
        }
        [Then(@"click iProcurement request and then Non-Catalog Req")]
        public void ThenClickIProcurementRequestAndThenNon_CatalogReq()
        {
            AbtPages.OraclePage.clickIProcurementRequest();
        }
        [Then(@"click the ""(.*)"" option")]
        public void ThenClickTheOption(string p0)
        {
            AbtPages.OraclePage.ClickMainMenuTableOption(p0);
        }
        [Then(@"browse to ""(.*)""")]
        public void ThenBrowseTo(string p0)
        {
            AbtPages.OraclePage.ClickUserOptions(p0);
        }
        [Then(@"go to time entry")]
        public void ThenGoToTimeEntry()
        {
            AbtPages.OraclePage.clickTimeCard();
        }

        [Then(@"fill the TimeCard")]
        public void ThenFillTheTimeCard()
        {
            AbtPages.OraclePage.fillTimeCard();
        }
        [Then(@"close complete the timeCard request")]
        public void ThenCloseCompleteTheTimeCardRequest()
        {
            AbtPages.OraclePage.completeTimeCardRequest();
        }

        [Then(@"fill the request form")]
        public void ThenFillTheRequestForm()
        {
            AbtPages.OraclePage.fillNonCatalogRequestForm();
        }
        [Then(@"Checkout the cart")]
        public void ThenCheckoutTheCart()
        {
            AbtPages.OraclePage.clickCheckOut();
        }
        [Then(@"Fill Requisition Information")]
        public void ThenFillRequisitionInformation()
        {
            AbtPages.OraclePage.fillRequisitionInformation();
        }
        [Then(@"Submit after approvers")]
        public void ThenSubmitAfterApprovers()
        {
            AbtPages.OraclePage.SubmitAfterApprovers();
        }
        [Then(@"Click Manage Approvals")]
        public void ThenClickManageApprovals()
        {
            AbtPages.OraclePage.clickManageGraphButton();
        }
        [Then(@"complete the order")]
        public void ThenCompleteTheOrder()
        {
            AbtPages.OraclePage.SelectAndApproveOrder();
        }

        [Then(@"assign ""(.*)"" before requisition and submit")]
        public void ThenAssignBeforeRequisitionAndSubmit(string p0)
        {
            AbtPages.OraclePage.addBeforeApproverAndSubmit(p0);
        }

        [Then(@"Then assign ""(.*)"" after requisition and submit")]
        public void ThenThenAssignAfterRequisitionAndSubmit(string p0)
        {
            AbtPages.OraclePage.addAfterApprover(p0);

        }

        [When(@"i hit submit the request is done")]
        public void WhenIHitSubmitTheRequestIsDone()
        {
            AbtPages.OraclePage.submitApproval();
        }

        [Then(@"browse to Requisitions under Buyer Work Center")]
        public void ThenBrowseToRequisitionsUnderBuyerWorkCenter()
        {
            AbtPages.OraclePage.openRequisitionsBuyerWorkCenter();
        }

        [Then(@"browse to Requisitions under Requisitions")]
        public void ThenBrowseToRequisitionsUnderRequisitions()
        {
            AbtPages.OraclePage.openRequisitionsRequisitions();       
        }


        [Then(@"select a requisition to add")]
        public void ThenSelectARequisitionToAdd()
        {
            AbtPages.OraclePage.selectRequisitionToBeAdded();
        }

        [Then(@"click Add")]
        public void ThenClickAdd()
        {
            AbtPages.OraclePage.addRequisition();
        }

        [Then(@"click Create")]
        public void ThenClickCreate()
        {
            AbtPages.OraclePage.clickCreate();
        }

        [Then(@"click ""(.*)"" option")]
        public void ThenClickOption(string p0)
        {
            AbtPages.OraclePage.ClickRightSideMenuTableOptions(p0);
        }

        [Then(@"navigate to ""(.*)""")]
        public void ThenNavigateTo(string p0)
        {
            AbtPages.OraclePage.ClickUserOptions1(p0);
        }

        [Then(@"click on People")]
        public void ThenClickOnPeople()
        {
            AbtPages.OraclePage.clickPeople();
        }

        [Then(@"click on Entries")]
        public void ThenClickOnEntries()
        {
            AbtPages.OraclePage.clickEntries();
        }

        [Then(@"click on Salary")]
        public void ThenClickOnSalary()
        {
            AbtPages.OraclePage.clickSalary();
        }

        [Then(@"click on SalaryB")]
        public void ThenClickOnSalaryB()
        {
            AbtPages.OraclePage.clickSalaryB();
        }


        [Then(@"click on Values")]
        public void ThenClickOnValues()
        {
            AbtPages.OraclePage.clickValues();
        }

        [Then(@"click on Absence")]
        public void ThenClickOnAbsence()
        {
            AbtPages.OraclePage.clickAbsence();
        }

        [Then(@"click on Description Payroll")]
        public void ThenClickOnDescriptionPayroll()
        {
            AbtPages.OraclePage.clickDescriptionPayroll();
        }

        [Then(@"click on Description Grade")]
        public void ThenClickOnDescriptionGrade()
        {
            AbtPages.OraclePage.clickDescriptionGrade();
        }

        [Then(@"click on Description Job")]
        public void ThenClickOnDescriptionJob()
        {
            AbtPages.OraclePage.clickDescriptionJob();
        }

        [Then(@"click on Description Organization")]
        public void ThenClickOnDescriptionOrganization()
        {
            AbtPages.OraclePage.clickDescriptionOrganization();
        }

        [Then(@"click on Description Position")]
        public void ThenClickOnDescriptionPosition()
        {
            AbtPages.OraclePage.clickDescriptionPosition();
        }


        [Then(@"I do discoverer books for multiple sheets")]
        public void ThenDoDiscovererWorkbboksForMultipleSheets()
        {
            AbtPages.OraclePage.DoDiscovererWorkbookMultipleSheets();
        }

        [Then(@"I do discoverer books for one sheet")]
        public void ThenDoDiscovererWorkbboksForOneSheet()
        {
            AbtPages.OraclePage.DoDiscovererWorkbookOneSheet();
        }


        [Then(@"I fill the Oracle Forms")]
        public void ThenIFillTheOracleForms()
        {
            AbtPages.OraclePage.FillOracleFroms();
        }

        [Then(@"I fill the Grade Rate Oracle Forms")]
        public void ThenIFillTheGradeRateOracleForms()
        {
            AbtPages.OraclePage.FillTheGradeRateOracleForms();
        }

        [Then(@"I choose veteran status")]
        public void ThenIChooseVeteranStatus()
        {
            AbtPages.OraclePage.chooseVeteranStatus();
        }

        [Then(@"I update information on the oracle form")]
        public void ThenIUpdateInformationOnTheOracleForm()
        {
            AbtPages.OraclePage.UpdateInformationOnOracleForm();
        }

        [Then(@"I go to the oracle form")]
        public void ThenIGoToTheOracleForm()
        {
            AbtPages.OraclePage.GoToOracleForm();
        }

        [Then(@"change timecard approver")]
        public void ThenChangeTimecardApprover()
        {
            AbtPages.OraclePage.ChangeTimecardApprover();
        }

        [Then(@"I change the employee hours")]
        public void ThenIChangeTheEmployeeHours()
        {
            AbtPages.OraclePage.ChangeEmployeeHours();
        }

        [Then(@"I approve the changes")]
        public void ThenIApproveTheChanges()
        {
            AbtPages.OraclePage.ApproveChanges();
        }

        [Then(@"I confirm default process runs")]
        public void ThenIConfirmDefaultProcessRuns()
        {
            AbtPages.OraclePage.ConfirmDefaultProcess();
        }

        [Then(@"I enter involuntary offboarding")]
        public void ThenEnterInvoluntaryOffboarding()
        {
            AbtPages.OraclePage.DoOffboardEmployee();
        }


        [Then(@"I enter Spot Bonus")]
        public void ThenEnterSpotBonus()
        {
            AbtPages.OraclePage.DoSpotBonus();
        }

        [Then(@"I add life event and enroll in benefits")]
        public void ThenIAddLifeEventAndEnrollInBenefits()
        {
            AbtPages.OraclePage.LifeEventEnrollBenefits();
        }



    }
}
