using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class IsmsPage : PageModel
    {
        [FindsBy(How=How.Id,Using = "pageTitle")]
        private IWebElement ismsHeader;

        /*
        public IsmsPage()
        {
            Environment = "Production";
            SingleSignOnProvider = "Simieo";
        }*/

        public bool isAt()
        {
            if (ismsHeader.Displayed)
            {
                StopTimer();
                PrintResponseTime("ISMS");
                return true;

            }

            return false;
        }

        public bool IsUserLoggedIn()
        {
            if (isAt())
            {
              
              string User= AbtPages.SharePointTopNavigation.GetCurrentUser();

                if (User.Equals(SSOCrendentials.CurrentUser))
                {
                    return true;
                }
                            
            }

            return false;
        }
    }
}