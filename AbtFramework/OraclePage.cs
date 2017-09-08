using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AbtFramework
{
    public class OraclePage : PageModel
    {

        [FindsBy(How=How.Id,Using ="PageLayoutRN")]
        private IWebElement headerInfo;
        [FindsBy(How = How.CssSelector, Using = "#PageLayoutRN > div > div:nth-child(5) > div > div.x63 > table > tbody > tr > td > h1")]
        private IWebElement OracleWelcome;
        [FindsBy(How = How.Id, Using = "usernameField")]
        private IWebElement usernameField;
        [FindsBy(How = How.Id, Using = "passwordField")]
        private IWebElement passwordField;
        [FindsBy(How = How.Id, Using = "SubmitButton")]
        private IWebElement submitButtond;
        [FindsBy(How = How.XPath, Using = "//*[@id='region1']/tbody/tr[4]/td/table/tbody/tr/td/div/div[2]/table/tbody/tr/td[1]/table/tbody/tr[2]/td[4]/a")]
        private IWebElement iProcurementRequest;
        [FindsBy(How = How.Id, Using = "ICXPOR_NONCATALOG")]
        private IWebElement nonCatalogRequest;
        [FindsBy(How = How.Id, Using = "ItemDescription")]
        private IWebElement itemDescription;
        [FindsBy(How = How.Id, Using = "Quantity")]
        private IWebElement quantity;
        [FindsBy(How = How.Id, Using = "UnitOfMeasureTl")]
        private IWebElement unitOfMeasureTl;
        [FindsBy(How = How.Id, Using = "UnitPrice")]
        private IWebElement unitPrice;
        [FindsBy(How = How.Id, Using = "SupplierOnNonCat")]
        private IWebElement supplierOnNonCat;
        [FindsBy(How = How.Id, Using = "SupplierContact")]
        private IWebElement supplierContact;
        [FindsBy(How = How.Id, Using = "SupplierContactPhone")]
        private IWebElement supplierContactPhone;
        [FindsBy(How = How.Id, Using = "AddToCart_uixr")]
        private IWebElement addToCart;
        [FindsBy(How = How.Id, Using = "Checkout")]
        private IWebElement checkout;
        [FindsBy(How = How.Id, Using = "Checkout_uixr")]
        private IWebElement checkout_uixr;
        [FindsBy(How = How.Id, Using = "ProjectOnSummaryExpense")]
        private IWebElement projectOnSummaryExpense;
        [FindsBy(How = How.Id, Using = "ExpenditureTypeOnSummary")]
        private IWebElement expenditureTypeOnSummary;
        [FindsBy(How = How.Id, Using = "TaskExpense")]
        private IWebElement taskExpense;

        public void GoToOracleDev()
        {
            StartTimer();
            //since its a clean session we go to agi to make o
            SeleniumDriver.Instance.Navigate().GoToUrl("http://ows2.cam.abtassoc.com:8004/OA_HTML/RF.jsp?function_id=24317&resp_id=-1&resp_appl_id=-1&security_group_id=0&lang_code=US&params=zuyf3HSa5SE5TW4skJCoR.tQktlyFm-Wf-QTiw1Fiis&oas=VEWpQaO79GovcNYh3cWiFw..");
        }

        public bool isAt()
        {
            //Thread.Sleep(2000);
            SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.Instance.WindowHandles.Last());
            try
            {

                AbtFramework.AutoIT.AutoITDriver.init();
                AbtFramework.AutoIT.AutoITDriver.AceptCertificate();

            }
            catch (NoAlertPresentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (wait.Until(e => OracleWelcome.Displayed))
            {
                StopTimer();
                return true;
            }

            else
            {
                return false;
            }
        }
        private string GetCurrentUser()
        {
            return headerInfo.FindElement(By.TagName("div")).FindElements(By.TagName("table"))[0].FindElements(By.TagName("span"))[1].Text;
        }
        private IWebElement getHeader()
        {
           return  headerInfo.FindElements(By.TagName("h1")).Single(e => e.Text.Equals("Oracle Applications Home Page"));
        }
        public void inputUserName()
        {
            usernameField.SendKeys("FROMETAJ");
        }
        public void inputPasswordField()
        {
            passwordField.Clear();
            passwordField.SendKeys("321654jJ.");
        }
        public void clickSubmitButton()
        {
            submitButtond.Click();
        }
        public void clickIProcurementRequest()
        {
            Thread.Sleep(2000);
            iProcurementRequest.Click();
            Thread.Sleep(1000);
            nonCatalogRequest.Click();
        }
        public void fillNonCatalogRequestForm()
        {
            Thread.Sleep(2000);
            itemDescription.SendKeys("Test Description");
            quantity.SendKeys("160");
            unitOfMeasureTl.SendKeys("Hour");
            unitPrice.Click();
            Thread.Sleep(5000);
            unitPrice.SendKeys("20");
            supplierOnNonCat.SendKeys("Think Forward Consulting");
            supplierContact.Click();
            Thread.Sleep(5000);
            supplierContact.SendKeys("Test Contant Name");
            supplierContactPhone.Click();
            supplierContactPhone.SendKeys("8099880000");
            Thread.Sleep(1000);
            addToCart.Click();
            Thread.Sleep(2000);
            checkout.Click();

        }
        public void clickCheckOut()
        {
            checkout_uixr.Click();
        }
        public void fillRequisitionInformation()
        {
            Thread.Sleep(1000);
            projectOnSummaryExpense.SendKeys("21553");
            taskExpense.Click();
            Thread.Sleep(5000);
            taskExpense.SendKeys("1100");
            Thread.Sleep(2000);
            expenditureTypeOnSummary.SendKeys("Misc Professional Sv");
            expenditureTypeOnSummary.Click();
        }
    }
}