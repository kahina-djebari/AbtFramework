using System;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AbtFramework
{
    public class EbscoHomePage : PageModel
    {
        [FindsBy(How=How.LinkText,Using = "EDS")]
        private IWebElement EDSLink;
        [FindsBy(How=How.Id,Using = "SearchTerm1")]
        private IWebElement HomeSearchBar;
        [FindsBy(How=How.LinkText,Using ="Update My Account")]
        private IWebElement UpdateMyAccountLink;

        //ctl00_ctl00_MainContentArea_MainContentArea_EmailAddressTBox
        public void Go(WebEnvironment link)
        {
            switch (link)
            {
                case WebEnvironment.TestEnvironment:
                    GoToUrl("https://search.ebscohost.com/login.aspx?authtype=sso&custid=aspengreg&profile=eds");
                    SingleSignOnProvider = "Okta";
                    Environment = "Test";
                    isAt();
                    break;
                case WebEnvironment.ProductionEnvironment:
                    GoToUrl("http://search.ebscohost.com/login.aspx?authtype=sso&custid=s1139472&profile=eds");
                    SingleSignOnProvider = "Simieo";
                    Environment = "Production";
                    isAt();
                    break;
                default:
                    break;
            }
        }

        private void GoToUrl(string url)
        {
            StartTimer();
            SeleniumDriver.FiringDriver.Navigate().GoToUrl(url);
           
        }

        public void GoToMyAccount()
        {
            UpdateMyAccountLink.Click();
        }

        public bool isAt()
        {
            wait.Until(e => HomeSearchBar.Displayed);
            StopTimer();
            Console.WriteLine("Ebsco ("+Environment+") Home Page Took: " + LoadTime + " to load using "+SingleSignOnProvider);
            Console.WriteLine("</br>");
            return true;
        }
    }
}