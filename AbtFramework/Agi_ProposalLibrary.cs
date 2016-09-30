using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class Agi_ProposalLibrary : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Interim Proposal Resume Library")]
        private IWebElement ProposalLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Proposal Resume Library"));
            if (ProposalLink.Displayed)
            {
                Console.WriteLine("Proposal Resume Library Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}