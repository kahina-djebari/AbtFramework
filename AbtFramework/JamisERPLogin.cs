using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AbtFramework
{
   public class JamisERPLogin : PageModel
    {
        //JAMIS login 
        [FindsBy(How = How.ClassName, Using = "login_user")]
        private IWebElement email;

        [FindsBy(How = How.ClassName, Using = "login_pass")]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "cmbCompany")]
        private IWebElement company;

        [FindsBy(How = How.Id, Using = "btnLogin")]
        private IWebElement submit;

        //General Navigation
        [FindsBy(How = How.CssSelector, Using = "#panelT_systemsBar_ul > li:nth-child(3) > div > div")]
        private IWebElement TNFinance;

        [FindsBy(How = How.CssSelector, Using = "#panelT_modulesBar_ul > li:nth-child(23) > div > div")]
        private IWebElement SNAccountsPayable;

        [FindsBy(How = How.CssSelector, Using = "#panelL_menuPanel_sp2_tree2_node_0_0 > span")]
        private IWebElement LNBillsAndAdjustsments;

        //bills And Adjustsments
        [FindsBy(How = How.CssSelector, Using = "#ctl00_phDS_ds_ToolBar_ul>li:nth-of-type(3)>div")]
        private IWebElement topAddNewRecord;
        
        [FindsBy(How = How.CssSelector, Using = "#ctl00_phG_tab_t0_grid_at_tlb_ul > li:nth-child(2) > div > div")]
        private IWebElement addDocumentRecord;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phF_form_edDocType > div.editorCont > div")]
        private IWebElement billType;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phF_form_edVendorID_text")]
        private IWebElement vendor;

        [FindsBy(How = How.CssSelector, Using = "#_ctl00_phG_tab_t0_grid_lv0_edUsrJobCostRecID_text")]
        private IWebElement jobCode;

        [FindsBy(How = How.CssSelector, Using = "#_ctl00_phG_tab_t0_grid_lv0_PXSelector2_text")]
        private IWebElement costElement;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phG_tab_t0_grid_scrollDiv > table.RowNavigator > tbody > tr > td:nth-child(10)")]
        private IWebElement laborCategory;

        public void Go()
        {
            SeleniumDriver.Instance.Navigate().GoToUrl("https://abt.jamisprime.com/");
           // SeleniumDriver.Instance.Navigate().GoToUrl("https://abt.jamisprime.com/?CompanyID=Business+Process+Overview&ScreenId=AP301000");
        }

        public void AttemptToLogin()
        {
            //in case the user is prompted with username and password
            try
            {
                if (email != null)
                {
                    email.SendKeys("jfrometaguerra");
                    password.SendKeys("321654jJ.");
                    SelectElement se = new SelectElement(company); //Locating select list
                    se.SelectByText("Business Process Overview"); //Select item from list having option text as "Item1"
                    
                   submit.Click();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("User and Password field not found");
                Console.WriteLine(e.Message);
            }
        }

        public bool isAt(string window)
        {
            switch (window)
            {
                case "BillsAndAdjustsments":
                //    Assert.True(LNBillsAndAdjustsments.Displayed);
                    return true;

                case "ChecksAndPayments":
                    // LNBillsAndAdjustsments.Click();
                    return true;
            }
            return false;
        }

        public bool AccountsPayableSideMenu(string section)
        {
            if (TNFinance != null)
            {
                //makes Accounts Payable Side Menu options available
                TNFinance.Click();
                SNAccountsPayable.Click();

                switch (section)
                {
                    case "BillsAndAdjustsments":
                        LNBillsAndAdjustsments.Click();
                        return true;

                    case "ChecksAndPayments":
                       // LNBillsAndAdjustsments.Click();
                        return true;
                }

            }
            return false;
        }

        public bool SwitchToFrame(string frame)
        {
            try
            {
                SeleniumDriver.Instance.SwitchTo().Frame(frame);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("did not find Frame: " +frame+ "\n " + e.Message);
            }
            return false;
        }

        public bool dropDownSelect(int itemIndex, IWebElement element)
        {
            try
            {
                SelectElement se = new SelectElement(element); //Locating select list
                se.SelectByIndex(itemIndex); //Select item from list having option text as "Item1"
                submit.Click();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Clicking: " + element + "\n " + e.Message);
            }
            return false;
        }

        public void HandleBrowserAlert(string action)
        {
            wait.Until(ExpectedConditions.AlertIsPresent());
            IAlert alert = SeleniumDriver.Instance.SwitchTo().Alert();

            switch (action)
            {
                case "accept":
                    alert.Accept();
                    break;
            }
        }

        public bool InputVendor(string country)
        {
            switch (country)
            {
                case "uganda":
                    vendor.SendKeys("V000007\n");
                    return true;

                case "us":
                    vendor.SendKeys("V000014\n");
                    return true;
            }
            return false;
         //   Thread.Sleep(10000);
        }

        public void ClickAddDocumentRecord()
        {
            //SeleniumDriver.Instance.SwitchTo().DefaultContent();
            //SeleniumDriver.Instance.SwitchTo().Frame("main");
            Thread.Sleep(1000);
            wait.Until(e => addDocumentRecord.Displayed);
            action.MoveToElement(addDocumentRecord).Click().Perform();
           // action.Release().Perform();

        }

        public void FillDocumentDetails(string type)
        {
            //Thread.Sleep(1000);
            jobCode.SendKeys("10001-0001-004-00001\n");
            wait.Until(e => addDocumentRecord.Displayed);
            Thread.Sleep(500);
            costElement.SendKeys("1000\n");
            Thread.Sleep(500);
            laborCategory.SendKeys("PM01\n");
            Thread.Sleep(5000);
        }

        public void ClickTopFrameAddNewRecord()
        {
            //SeleniumDriver.Instance.SwitchTo().DefaultContent();
            //SeleniumDriver.Instance.SwitchTo().Frame("main");

            wait.Until(e => topAddNewRecord.Displayed);
            action.MoveToElement(topAddNewRecord).Click().Perform();
        }

    }
}
