using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class OfficeServiceRequestpage : PageModel
    {
        [FindsBy(How = How.LinkText, Using = "Office Services Request")]
        private IWebElement OfficeRequest;

        public void NewOfficeRequest(string location, string category,string subcategory, string shortdescription, string comments)
        {
            SeleniumDriver.FiringDriver.SwitchTo().Frame("gsft_main");
            OfficeRequest.Click();
           
            AbtPages.OfficeRequestFormPage.NewOfficeRequest(location, category,subcategory,shortdescription, comments);


        }
    }
}