using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework.ERP
{
   public class ERPNavigation : PageModel
    {
        //JAMIS login 
        [FindsBy(How = How.ClassName, Using = "login_user")]
        internal IWebElement email;

        [FindsBy(How = How.ClassName, Using = "login_pass")]
        internal  IWebElement password;

        [FindsBy(How = How.Id, Using = "cmbCompany")]
        internal  IWebElement company;

        [FindsBy(How = How.Id, Using = "btnLogin")]
        internal  IWebElement submit;

        //TOP Navigation
        [FindsBy(How = How.CssSelector, Using = "#panelT_systemsBar_ul > li:nth-child(3) > div > div")]
        internal  IWebElement TNFinance;

        [FindsBy(How = How.CssSelector, Using = "#panelT_systemsBar_ul > li:nth-child(1) > div > div")]
        internal IWebElement TNMyPrimeERP;

        //Secondary Navigation
        [FindsBy(How = How.CssSelector, Using = "#panelT_modulesBar_ul > li:nth-child(23) > div > div")]
        internal  IWebElement SNAccountsPayable;

        [FindsBy(How = How.CssSelector, Using = "#panelT_modulesBar_ul>li:nth-child(7) > div > div")]
        internal IWebElement SNTimeAndExpenses;

        //LeftPanel Navigation
        [FindsBy(How = How.CssSelector, Using = "#panelL_menuPanel_sp2_tree2_node_0_0 > span")] //#panelL_menuPanel_sp0_tree0_node_0_0 > span
        internal  IWebElement LNBillsAndAdjustsments;

        [FindsBy(How = How.CssSelector, Using = "#panelL_menuPanel_sp2_tree2_node_2_0 >span")]
        internal IWebElement LNExpenseReports;

        [FindsBy(How = How.ClassName, Using = "treeNode")]
        internal IList<IWebElement> expenseNodes;
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
                    email.SendKeys("frometaguerraj");
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

        public bool TimeAndExpensesSideMenu(string section)
        {
            if (TNMyPrimeERP != null)
            {
                //make time expenses Side Menu options available
                 TNMyPrimeERP.Click();
                 SNTimeAndExpenses.Click();
                // Thread.Sleep(500);
                switch (section)
                {
                    case "ExpenseReports":
                        foreach(var el in expenseNodes)
                        {
                            Console.WriteLine("nodes on expense reports:"+el.Text);
                        }
                        var expenseReports = expenseNodes.Single(e => e.Text.Equals("Expense Reports"));
                        expenseReports.Click();
                       // LNExpenseReports.Click();
                        return true;

                    case "ChecksAndPayments":
                        // LNBillsAndAdjustsments.Click();
                        return true;
                }

            }
            return false;
        }

    }
}
