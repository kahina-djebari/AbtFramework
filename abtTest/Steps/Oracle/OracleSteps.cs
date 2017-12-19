using System;
using AbtFramework;
using AbtFramework.Utils_Classes.SeleniumUtils;
using TechTalk.SpecFlow;

namespace abtTest.Steps.Oracle
{
    [Binding]
    public sealed class OracleSteps
    {

        private static String gUser = "user";


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
            AbtPages.OraclePage.ClickRightSideMenuTableOptions(p0);
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

        [Then(@"click Add and Create")]
        public void ThenClickAddAndCreate()
        {
            AbtPages.OraclePage.addCreateRequisition();
        }


        [Then(@"click ""(.*)"" option")]
        public void ThenClickOption(string p0)
        {
            AbtPages.OraclePage.ClickRightSideMenuTableOptions(p0);
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

        [Then(@"I click on all links at the right side menu")]
        public void THenClickAllLinks()
        {
            AbtPages.OraclePage.ClickAllLinksInNavigator();
        }

        [Then(@"I confirm and update personal information")]
        public void ThenIConfirmAndUpdatePersonalInformation()
        {
            AbtPages.OraclePage.UpdatePersonalInformation();
        }


        [Then(@"I add life event and enroll in benefits")]
        public void ThenIAddLifeEventAndEnrollInBenefits()
        {
            AbtPages.OraclePage.LifeEventEnrollBenefits();
        }

        [Then(@"I confirm view and add beneficiaries")]
        public void ThenIConfirmViewAndAddBeneficiaries()
        {
            AbtPages.OraclePage.AddBeneficiaries();
        }

        [Then(@"I confirm termed employee benefit process success")]
         public void ThenIConfirmTermedEmployeeBenefitProcessSuccess()
        {
             AbtPages.OraclePage.ConfirmTerminateProcessSuccess();
         }
  
         [Then(@"I submit a report")]
         public void ThenISubmitAReport()
         {
             AbtPages.OraclePage.submitReport();
         }

    }
}
