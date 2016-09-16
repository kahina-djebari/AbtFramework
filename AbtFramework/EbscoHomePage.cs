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
                    GoToUrl("https://search.ebscohost.com/login.aspx?authtype=sso&custid=aspengreg");
                    SingleSignOnProvider = "Okta";
                    Environment = "Test";
                    break;
                case WebEnvironment.ProductionEnvironment:
                    GoToUrl("http://search.ebscohost.com/login.aspx?authtype=sso&custid=s1139472&profile=eds");
                    SingleSignOnProvider = "Simieo";
                    Environment = "Production";
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

        public bool isAt()
        {
            wait.Until(e => EDSLink.Displayed);
            StopTimer();
            Console.WriteLine("Ebsco ("+Environment+") Home Page Took: " + LoadTime + " to load using "+SingleSignOnProvider);
            Console.WriteLine("</br>");
            return true;
        }
    }
}