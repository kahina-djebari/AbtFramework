using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class Agi_PolicyLibraryPage : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Company Policies Simple View")]
        private IWebElement CompanyPoliciesLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("CompanyPolicies - Company Policies Simple View"));
            if (CompanyPoliciesLink.Displayed)
            {
                Console.WriteLine("Policy Library link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}