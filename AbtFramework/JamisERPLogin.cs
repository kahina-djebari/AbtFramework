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
        [FindsBy(How = How.CssSelector, Using = "#ctl00_phDS_ds_ToolBar_ul>li:nth-of-type(1)>div")]
        private IWebElement topSaveRecord;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phDS_ds_ToolBar_ul>li:nth-of-type(3)>div")]
        private IWebElement topAddNewRecord;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phDS_ds_ToolBar_ul>li:nth-of-type(13)>div")]
        private IWebElement topReleaseRecord;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phF_form_chkHold")]
        private IWebElement holdCheckBox;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phG_tab_t0_grid_at_tlb_ul > li:nth-child(2) > div > div")]
        private IWebElement addDocumentRecord;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phF_form_edDocType > div.editorCont > div")]
        private IWebElement billType;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phF_form_edRefNbr_text")]
        private IWebElement referenceNbr;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phF_form_edVendorID_text")]
        private IWebElement vendor;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phF_form_edFinPeriodID_text")]
        private IWebElement postPeriod;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phF_form_edInvoiceNbr")]
        private IWebElement vendorRef;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phF_form_edDocDesc")]
        private IWebElement description;

        [FindsBy(How = How.CssSelector, Using = "#ctl00_phF_form_edCuryOrigDocAmt")]
        private IWebElement amount;

        [FindsBy(How = How.CssSelector, Using = "#_ctl00_phG_tab_t0_grid_lv0_edUsrJobCostRecID_text")]
        private IWebElement jobCode;

        [FindsBy(How = How.CssSelector, Using = "#_ctl00_phG_tab_t0_grid_lv0_PXSelector2_text")]
        private IWebElement costElement;

        [FindsBy(How = How.CssSelector, Using = "#_ctl00_phG_tab_t0_grid_lv0_PXSelector4")]
        private IWebElement laborCategory;

        [FindsBy(How = How.XPath, Using = ".//*[@id='_ctl00_phG_tab_t0_grid_lv0_PXSelector4']/div/div[2]")]
        private IWebElement laborCategoryHoover;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_phG_tab_t0_grid_lv0_PXSelector4_pnl_tlb_fb_text']")]
        private IWebElement laborCategorySelect;

        [FindsBy(How = How.CssSelector, Using = "#_ctl00_phG_tab_t0_grid_lv0_PXDateTimeEdit1_text")]
        private IWebElement incurDate;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_phG_tab_t0_grid_scrollDiv']/table[2]/tbody/tr/td[16]")]
        private IWebElement incurDateHoover;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_phG_tab_t0_grid_scrollDiv']/table[2]/tbody/tr/td[28]")]
        private IWebElement extCostHoover;

        [FindsBy(How = How.XPath, Using = ".//*[@id='_ctl00_phG_tab_t0_grid_lv0_edCuryLineAmt']")]
        private IWebElement extCost;


        private string referencenbr = "string";
        public string ReferenceNbr
        {
            get { return referencenbr; }
            set { referencenbr = value; }
        }


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
            //generate random venderoRef Number
            Random rnd = new Random();
            int num = rnd.Next(0000000, 9999999);
            string vendorref = num.ToString("0000000");
            //log Vref
            Console.WriteLine("Vendor Ref: "+vendorref);

            DateTime now = DateTime.Now;
            string format = "MM-yyyy";// Use this format.
            format = now.ToString(format);

            switch (country)
            {
                case "uganda":
                    vendor.Click();
                    vendor.SendKeys("V000007\r\n");
                    Thread.Sleep(1000);
                    postPeriod.Click();
                    postPeriod.SendKeys(format+ "\r\n");
                    Thread.Sleep(1000);
                    vendorRef.Click();
                    vendorRef.SendKeys(vendorref+ "\r\n");
                    Thread.Sleep(1000);
                    description.Click();
                    description.SendKeys("ERP Automation : International Bills\r\n");
                    amount.Click();
                    amount.SendKeys("4000\r\n");
                    return true;

                case "us":
                    vendor.SendKeys("V000014\n");
                    return true;
            }
            return false;
        }

        public void ClickAddDocumentRecord()
        {
            Thread.Sleep(1000);
            wait.Until(e => addDocumentRecord.Displayed);
            action.MoveToElement(addDocumentRecord).Click().Perform();
            action.Release().Perform();

        }

        public void FillDocumentDetails(string type)
        {
            Thread.Sleep(1000);
            jobCode.SendKeys("10001-0001-004-00001\r\n");
         
            costElement.SendKeys("1000");
          //  Thread.Sleep(500);
            costElement.SendKeys("\r\n");
            wait.Until(e => laborCategoryHoover.Displayed);
            laborCategory.SendKeys("\r\n");
      
            wait.Until(e => laborCategoryHoover.Displayed);
            laborCategoryHoover.Click();
          
            wait.Until(e => laborCategorySelect.Displayed);
            laborCategorySelect.SendKeys("PM01");
            Thread.Sleep(3000);
            laborCategorySelect.SendKeys("\r\n");

            Thread.Sleep(1000);
            DateTime now = DateTime.Now.AddDays(-7);
            string format = "MM/dd/yyyy";// Use this format.

            incurDateHoover.Click();
            wait.Until(e => incurDate.Displayed);
            format = now.ToString(format);

            //delete current text
            incurDate.SendKeys("\b\b\b\b\b\b\b\b");
            incurDate.SendKeys(format);
            incurDate.SendKeys("\r\n");

            //scrool to element
            action.MoveToElement(extCostHoover).Click();
            action.Perform();
            extCostHoover.Click();

            //delete current text
            extCostHoover.Click();
            extCost.SendKeys("\b\b\b\b\b\b\b\b");
            extCost.SendKeys("4000.00\r\n");

        }

        public bool SaveBill()
        {
            action.MoveToElement(topSaveRecord).Click();
            action.Perform();

            Thread.Sleep(1000);

          //  wait.Until(e => referenceNbr.Displayed);
            ReferenceNbr = referenceNbr.GetAttribute("value");

            if (!ReferenceNbr.Equals("<NEW>"))
            {
                Console.WriteLine("References number: " + ReferenceNbr);
                return true;
            }
            return false;
        }

        public bool CheckBillinHoldButton()
        {
            Thread.Sleep(500);
            holdCheckBox.Click();
            //add confirmation the status is now Open.
            //if ()
            //{
            //    return true;
            //}
        
            return false;
        }

        public bool ReleaseTheBill()
        {
            Thread.Sleep(1000);

            action.MoveToElement(topReleaseRecord).Click();
            action.Perform();
            topReleaseRecord.Click();

            

            return false;
        }

        public void ClickTopFrameAddNewRecord()
        {
            wait.Until(e => topAddNewRecord.Displayed);
            action.MoveToElement(topAddNewRecord).Click().Perform();
        }

        public bool CheckReferenceNBR()
        {
            if(!ReferenceNbr.Equals("<NEW>"))
            {
                Console.WriteLine("References number: "+ReferenceNbr);
                return true;
            }
            return false;
        }

    }
}
