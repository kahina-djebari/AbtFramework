using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        [FindsBy(How = How.CssSelector, Using = ".stack-h.stack-pout-h div.cell-ph2 #ctl00_phF_form_s0_s1_s0_s0")]
        private IWebElement vendorout;

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
                    //company.Click();
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

        public bool isAt()
        {
            if (TNFinance!=null)
            {
                TNFinance.Click();
                SNAccountsPayable.Click();
                LNBillsAndAdjustsments.Click();

                int iFrames = SeleniumDriver.Instance.FindElements(By.TagName("iframe")).Count;
                SeleniumDriver.Instance.SwitchTo().Frame("main");
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
            wait.Until(e => addDocumentRecord.Displayed);
            action.MoveToElement(addDocumentRecord).Click().Perform();
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
