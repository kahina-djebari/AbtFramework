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
            AbtPages.JamisERPLogin.Go();
            AbtPages.JamisERPLogin.AttemptToLogin();
         }

        [Then(@"i click save the status its updated to Open")]
        public void ThenIClickSaveTheStatusItsUpdatedToOpen()
        {
            AbtPages.JamisERPLogin.SaveBill();
        }


        [Then(@"click on Finance, Click Account Payable Then under Enter Bills And Adjustments")]
        public void ThenClickOnFinanceClickAccountPayableThenUnderEnterBillsAndAdjustments()
        {
            AbtPages.JamisERPLogin.isAt("BillsAndAdjustsments");
            AbtPages.JamisERPLogin.AccountsPayableSideMenu("BillsAndAdjustsments");
     
        }
        [Then(@"Fill the international Vendor information")]
        public void ThenFillTheInternationalVendorInformation()
        {
            AbtPages.JamisERPLogin.SwitchToFrame("main");
            AbtPages.JamisERPLogin.InputVendor("uganda");
        }

        [Then(@"Add New Record")]
        public void ThenAddNewRecord()
        {
            AbtPages.JamisERPLogin.ClickAddDocumentRecord();
        }
        
        [Then(@"fill the Document information")]
        public void ThenFillTheDocumentInformation()
        {
            AbtPages.JamisERPLogin.FillDocumentDetails("bill");
        }
        [When(@"a reference nbr is generated i release the bill")]
        public void WhenAReferenceNbrIsGeneratedIReleaseTheBill()
        {
            AbtPages.JamisERPLogin.CheckBillinHoldButton();
            AbtPages.JamisERPLogin.ReleaseTheBill();
        }

    }
}
