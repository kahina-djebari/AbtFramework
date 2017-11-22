using System;
using AbtFramework;
using AbtFramework.Utils_Classes.SeleniumUtils;
using TechTalk.SpecFlow;

namespace abtTest.Steps.Oracle
{
    [Binding]
    public sealed class OracleSteps
    {
       

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



        [Then(@"I fill the Oracle Forms")]
        public void ThenIFillTheOracleForms()
        {
            AbtPages.OraclePage.FillOracleFroms();
        }


    }
}
