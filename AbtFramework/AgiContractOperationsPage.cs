using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiContractOperationsPage : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Contract Operations Service Center")]
        private IWebElement ContractOperationsLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Contract Operations Service Center"));
            if (ContractOperationsLink.Displayed)
            {
                Console.WriteLine("Contract Operations Link Opened Succesfully");
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}