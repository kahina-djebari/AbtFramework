using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AbtFramework.ERP
{
   public class ERPExpenseReports : ERPNavigation
    {
        [FindsBy(How = How.CssSelector, Using = "#ctlHeader_lblUserName")]
        private IWebElement topSaveRecord;

    }
}
