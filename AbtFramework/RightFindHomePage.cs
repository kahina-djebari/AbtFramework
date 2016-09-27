using System;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AbtFramework
{
    public class RightFindHomePage : PageModel
    {
        [FindsBy(How=How.Id,Using = "RightHeaderToolbar")]
        private IWebElement RightHeaderToolbar;
        [FindsBy(How=How.CssSelector,Using = "#RightHeaderToolbar > div > div > div > ul > li:nth-child(1) > a > span > span > span > span.rtbText")]
        private IWebElement User;

        public void Go(WebEnvironment environment)
        {
            switch (environment)
            {
                case WebEnvironment.TestEnvironment:
                    Environment = "Test";
                    SingleSignOnProvider = "Okta";
                  //  GoToUrl("https://rfetest.infotrieve.com/vlib/logon.aspx?clientid=11397");
                    GoToUrl("https://abtassociates.okta.com/home/abtassociatesinc_rightfindtest_1/0oa7irrou8UflAXZJ0x7/aln7irw3gcNMEvNG60x7");
                    break;
                case WebEnvironment.ProductionEnvironment:
                    Environment = "Production";
                    SingleSignOnProvider = "Simieo";
                    GoToUrl("https://www.rightfind.com/vlib/logon.aspx?clientid=11397");
                    break;
                default:
                    break;
            }
        }

        private void GoToUrl(string url)
        {
            StartTimer();
            SeleniumDriver.Instance.Navigate().GoToUrl(url);
        }

        public bool IsUserLoggedIn()
        {
            if (IsAt())
            {
                //  if (User.Text.Equals(SSOCrendentials.CurrentUser))
                if (User.Text.Equals("David Acuna"))
                {
                    //PrintSuccesfullLogin(User.Text);
                    return true;
                }
                               
            }


            return false;
        }

        private bool IsAt()
        {
            if (RightHeaderToolbar.Displayed)
            {
                StopTimer();
                PrintResponseTime("RightFind");
                
                return true;
            }


            return false;
        }
    }
}