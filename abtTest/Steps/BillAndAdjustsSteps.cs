using System;
using AbtFramework;
using AbtFramework.Utils_Classes;
using Xunit;
using TechTalk.SpecFlow;

namespace abtTest.Steps
{
    [Binding]
    public class BillAndAdjustsSteps
    {
        [Given(@"i Login to Jamis with a valid URL and User credentials")]
        public void GivenILoginToJamisWithAValidURLAndUserCredentials()
        {
            SeleniumDriver.init(Browser.Chrome);
            AbtPages.JamisERPLogin.Go();
            AbtPages.JamisERPLogin.AttemptToLogin();
            AbtPages.JamisERPLogin.isAt();
            AbtPages.JamisERPLogin.InputVendor();
        }
        
        [When(@"the Checks and Payment menu appears click Add New Record")]
        public void WhenTheChecksAndPaymentMenuAppearsClickAddNewRecord()
        {
            AbtPages.JamisERPLogin.InputVendor();
        }
        
        [When(@"i click save the status its updated to Open")]
        public void WhenIClickSaveTheStatusItsUpdatedToOpen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on Finance")]
        public void ThenClickOnFinance()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"then  Click Account Payable")]
        public void ThenThenClickAccountPayable()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"under Enter click Bills And Adjustments")]
        public void ThenUnderEnterClickBillsAndAdjustments()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"select Bill as type")]
        public void ThenSelectBillAsType()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the status should be on hold with the check box checked")]
        public void ThenTheStatusShouldBeOnHoldWithTheCheckBoxChecked()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Enter the bill date and check the post period text box")]
        public void ThenEnterTheBillDateAndCheckThePostPeriodTextBox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Select the Vendor the invoice is from")]
        public void ThenSelectTheVendorTheInvoiceIsFrom()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Enter the ref \# in Vendor Ref text box")]
        public void ThenEnterTheRefInVendorRefTextBox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Enter the description in the description text box")]
        public void ThenEnterTheDescriptionInTheDescriptionTextBox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"hit the plus icon under document details")]
        public void ThenHitThePlusIconUnderDocumentDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"i choose an incurDate_JobID_LaborCat_CostElem_Organization_CostElem_Loc")]
        public void ThenIChooseAnIncurDate_JobID_LaborCat_CostElem_Organization_CostElem_Loc()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
