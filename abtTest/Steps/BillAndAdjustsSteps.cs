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
            SeleniumDriver.init(Browser.IE);
            AbtPages.ERPBillAndAdjustsments.Go();
            AbtPages.ERPBillAndAdjustsments.AttemptToLogin();
         }

        [Then(@"i click save the status its updated to Open")]
        public void ThenIClickSaveTheStatusItsUpdatedToOpen()
        {
            AbtPages.ERPBillAndAdjustsments.SaveBill();
        }


        [Then(@"click on Finance, Click Account Payable Then under Enter Bills And Adjustments")]
        public void ThenClickOnFinanceClickAccountPayableThenUnderEnterBillsAndAdjustments()
        {
            AbtPages.ERPBillAndAdjustsments.isAt("BillsAndAdjustsments");
            AbtPages.ERPBillAndAdjustsments.AccountsPayableSideMenu("BillsAndAdjustsments");
     
        }
        [Then(@"Fill the international Vendor information")]
        public void ThenFillTheInternationalVendorInformation()
        {
            AbtPages.ERPBillAndAdjustsments.SwitchToFrame("main");
            AbtPages.ERPBillAndAdjustsments.InputVendor("us");
        }

        [Then(@"Add New Record")]
        public void ThenAddNewRecord()
        {
            AbtPages.ERPBillAndAdjustsments.ClickAddDocumentRecord();
        }
        
        [Then(@"fill the Document information")]
        public void ThenFillTheDocumentInformation()
        {
            AbtPages.ERPBillAndAdjustsments.FillDocumentDetails("bill","us");
        }
        [When(@"a reference nbr is generated i release the bill")]
        public void WhenAReferenceNbrIsGeneratedIReleaseTheBill()
        {
            AbtPages.ERPBillAndAdjustsments.CheckBillinHoldButton();
            AbtPages.ERPBillAndAdjustsments.ReleaseTheBill();
        }

    }
}
