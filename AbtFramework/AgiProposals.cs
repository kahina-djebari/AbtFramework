using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiProposals : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Proposals")]
        private IWebElement ProposalsLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Proposals Home"));
            if (ProposalsLink.Displayed)
            {
                Console.WriteLine("Proposals Link Opened Succesfully");
                return true;
            }


            return false;
        }
    }
}