using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace AbtFramework
{
    public class ServiceHubHomepage : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="New HR Request")]
        internal IWebElement  HRServiceRequest;

        [FindsBy(How = How.LinkText, Using = "New IT Request or Incident")]
        internal IWebElement ITServiceRequest;

        [FindsBy(How = How.LinkText, Using = "New OS Request")]
        internal IWebElement OfficeServiceRequest;
        internal ServiceHubTopNavigation _servicehubtopnavigation;
        [FindsBy(How=How.LinkText,Using ="My Open IT Incidents")]
        internal IWebElement MyOpenIncidents;

        [FindsBy(How = How.LinkText, Using = "My Open IT Requests")]
        internal IWebElement MyOpenITRequest;
        [FindsBy(How = How.LinkText, Using = "My Open HR Requests")]
        internal IWebElement MyOpenHR_Request;
        [FindsBy(How = How.LinkText, Using = "My Open OS Requests")]
        internal IWebElement MyOpenOSRequest;
        [FindsBy(How = How.LinkText, Using = "New OS Request")]
        internal IWebElement NewOSRequest;
        [FindsBy(How = How.LinkText, Using = "New HR Request")]
        internal IWebElement NewHR_Request;
        [FindsBy(How=How.LinkText,Using ="IT Knowledge Base")]
        internal IWebElement ITKnowledgeBase;
        [FindsBy(How = How.LinkText, Using = "My Closed IT Incidents")]
        internal IWebElement MyClosedITIncidents;
        [FindsBy(How=How.LinkText,Using ="My Closed IT Requests")]
        internal IWebElement MyClosedITRequest;
        [FindsBy(How = How.LinkText, Using = "Welcome to the Abt Service Hub! - IT/CTC Pilot")]
        internal IWebElement TodaysNews;
        [FindsBy(How = How.LinkText, Using = "My Closed HR Requests")]
        internal IWebElement MyClosedHRRequests;
        [FindsBy(How = How.LinkText, Using = "My Closed OS Requests")]
        internal IWebElement MyClosedOSRequests;
        [FindsBy(How=How.Id,Using = "sysparm_search")]
        private IWebElement SearchBar;

        public ServiceHubTopNavigation ServiceHubTopNavigation
        {
            get
            {
                _servicehubtopnavigation= PageGenerator.GetPage<ServiceHubTopNavigation>();
                _servicehubtopnavigation.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _servicehubtopnavigation.action = new Actions(Driver.seleniumdriver);
                return _servicehubtopnavigation;
            }
        }

        public void GoTo(ServiceHubLinks request)
        {
            switch (request)
            {
                case ServiceHubLinks.My_Open_Incidents:
                    MyOpenIncidents.Click();
                    break;
                case ServiceHubLinks.My_Open_IT_Request:
                    MyOpenITRequest.Click();
                    break;
                case ServiceHubLinks.My_Open_HR_Request:
                    MyOpenHR_Request.Click();
                    break;
                case ServiceHubLinks.My_Open_OS_Request:
                    MyOpenOSRequest.Click();
                    break;
                case ServiceHubLinks.New_IT_Request:
                    ITServiceRequest.Click();
                    break;
                case ServiceHubLinks.New_OS_Request:
                    NewOSRequest.Click();
                    break;
                case ServiceHubLinks.New_HR_Request:
                    NewHR_Request.Click();
                    break;
                case ServiceHubLinks.IT_Knowledge_Base:
                    ITKnowledgeBase.Click();
                    break;

                case ServiceHubLinks.My_Closed_IT_Incidents:
                    MyClosedITIncidents.Click();
                    break;
                case ServiceHubLinks.My_Closed_IT_Requests:
                    MyClosedITRequest.Click();
                    break;
                case ServiceHubLinks.TodaysNews:
                    TodaysNews.Click();
                    break;
                case ServiceHubLinks.My_Closed_HR_Requests:
                    MyClosedHRRequests.Click();
                    break;
                case ServiceHubLinks.My_Closed_OS_Requests:
                    MyClosedOSRequests.Click();
                    break;
                default:
                    break;
            }

        }

        public void Go()
        {
            ServiceHubTopNavigation.Go(ServiceHubTopNavLinks.Home);
        }

        public void Search(string text)
        {
            SearchBar.SendKeys(text);
            SearchBar.Submit();
        }
    }
}