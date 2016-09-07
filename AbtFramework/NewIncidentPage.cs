using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class NewIncidentPage : PageModel
    {
        [FindsBy(How = How.Id, Using = "IO:0e3c32749c224200615ec5391ae8d840")]
        private IWebElement ImpactDropdown;
        [FindsBy(How = How.Id, Using = "IO:863c32749c224200615ec5391ae8d841")]
        private IWebElement ShortDescriptionInput;
        [FindsBy(How = How.Id, Using = "IO:023c32749c224200615ec5391ae8d842")]
        private IWebElement Descripton;
        [FindsBy(How = How.Id, Using = "submit_button")]
        private IWebElement Submitbtn;


        public void NewIncident(string impact,string shortdescription ,string description)
        {
           
            ImpactDropdown.SendKeys(impact);
            ShortDescriptionInput.SendKeys(shortdescription);
            Descripton.SendKeys(description);
            Submitbtn.Click();
        }
    }
}