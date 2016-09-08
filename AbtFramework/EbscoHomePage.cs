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

        public void Go(WebEnvironment link)
        {
            switch (link)
            {
                case WebEnvironment.TestEnvironment:
                    GoToUrl("http://search.ebscohost.com/login.aspx?authtype=sso&custid=aspengreg");
                   
                    break;
                case WebEnvironment.ProductionEnvironment:
                    break;
                default:
                    break;
            }
        }

        private void GoToUrl(string url)
        {
            StartTimer();
            Driver.seleniumdriver.Navigate().GoToUrl(url);
           
        }

        public bool isAt()
        {
            wait.Until(e => EDSLink.Displayed);
            StopTimer();
            Console.WriteLine("Ebsco (Test) Home Page Took: " + LoadTime + " to load using Okta");
            Console.WriteLine("</br>");
            return true;
        }
    }
}