using System;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AbtFramework
{
    public class ITServiceRequestpage : PageModel
    {
        [FindsBy(How=How.Id,Using = "item_link_023c32749c224200615ec5391ae8d83e")]
        private IWebElement Incident;


        public void NewIncident(string priority, string shortdescription, string description)
        {
            Driver.seleniumdriver.SwitchTo().Frame("gsft_main");
            Incident.Click();
            AbtDriver.NewIncidentPage.NewIncident(priority,shortdescription,description);
           
        }
    }
}