using System;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;
using AbtFramework.SeleniumUtils;

namespace AbtFramework
{
    public class HRServiceRequestpage : PageModel
    {
        [FindsBy(How=How.Id,Using = "IO:6ad1d64304db110008e999502af6ecf5")]
        private IWebElement IssueDropdown;
        [FindsBy(How = How.Id, Using = "IO:e9121e4304db110008e999502af6ec1c")]
        private IWebElement SubjectInput;
        [FindsBy(How = How.Id, Using = "IO:17329a4304db110008e999502af6eccd")]
        private IWebElement DescriptionInput;
        [FindsBy(How=How.Id,Using ="submit_button")]
        private IWebElement SubmitBtn;

    
        public void NewHRServiceRequest(HRIssueCategory issue, string subject, string description)
        {
            SeleniumDriver.DriverInstance.SwitchTo().Frame("gsft_main");
            SelectIssue(issue.ToString());
            SubjectInput.SendKeys(subject);
            DescriptionInput.SendKeys(description);
            SubmitBtn.Click();
        }

        private void SelectIssue(string issue)
        {
            SeleniumDriver.DriverInstance.FindElement(By.Id("IO:6ad1d64304db110008e999502af6ecf5"))
                                 .FindElements(By.TagName("option"))
                                 .Single(e => e.Text.Equals(issue))
                                 .Click();
        }
    }
}