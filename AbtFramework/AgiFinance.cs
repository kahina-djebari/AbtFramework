using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiFinance : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Finance Service Center")]
        private IWebElement FinanceLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Finance Service Center"));
            if (FinanceLink.Displayed)
            {
                Console.WriteLine("Finance Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}