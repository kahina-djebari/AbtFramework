using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class ServiceHubHomepage : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="New HR Request")]
        private IWebElement  HRServiceRequest;

        [FindsBy(How = How.LinkText, Using = "New IT Request or Incident")]
        private IWebElement ITServiceRequest;

        [FindsBy(How = How.LinkText, Using = "New OS Request")]
        private IWebElement OfficeServiceRequest;

        public void NewRequest(ServiceHubRequest request)
        {
            switch (request)
            {
                case ServiceHubRequest.HRServiceRequest:
                    HRServiceRequest.Click();
                    break;

                case ServiceHubRequest.ITServiceRequest:
                    ITServiceRequest.Click();
                    break;

                case ServiceHubRequest.OfficeServiceRequest:
                    OfficeServiceRequest.Click();
                    break;

            }
           
        }
    }
}