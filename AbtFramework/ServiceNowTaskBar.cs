using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class ServiceNowTaskBar : PageModel
    {
 
        [FindsBy(How=How.Id,Using ="sysverb_new")]
        private IWebElement NewBtn;
        [FindsBy(How=How.Id,Using = "sysverb_insert")]
        private IWebElement SubmitBtn;

        public void New()
        {
            SeleniumDriver.Instance.SwitchTo().ParentFrame();
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
            NewBtn.Click();
        }

        public void Submit()
        {
         
            SubmitBtn.Click();


        }
    }
}