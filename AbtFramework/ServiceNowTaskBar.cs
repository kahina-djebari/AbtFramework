﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using AbtFramework.SeleniumUtils;

namespace AbtFramework
{
    public class ServiceNowTaskBar : PageModel
    {
 
        [FindsBy(How=How.Id,Using ="sysverb_new")]
        private IWebElement NewBtn;
        [FindsBy(How=How.Id,Using = "sysverb_insert")]
        private IWebElement SubmitBtn;
        [FindsBy(How=How.ClassName,Using ="navbar-header")]
        private IWebElement navBar;
        [FindsBy(How=How.ClassName,Using ="context_item")]
        private IList<IWebElement> contextItems;
        [FindsBy(How=How.Id,Using = "u_incident_response_hide_search")]
        private IWebElement FilterWrapper;
        [FindsBy(How=How.Id,Using = "sysverb_update")]
        private IWebElement UpdateBtn;

        public IWebElement IR_item { get { return contextItems.Single(e => e.Text.Equals("Create IR Report")); } }

        public IWebElement IRRFilterDropdwn { get { return FilterWrapper.FindElement(By.TagName("select")); } }
        public IWebElement IRRSearchBar { get { return FilterWrapper.FindElement(By.TagName("input")); } }

        public void New()
        {
            SeleniumDriver.DriverInstance.SwitchTo().ParentFrame();
            SeleniumDriver.DriverInstance.SwitchTo().Frame("gsft_main");
            NewBtn.Click();
        }

        public void Submit()
        {
            SubmitBtn.Click();
        }

        public bool CreateIncReport()
        {
            try
            {
                action.ContextClick(navBar).Perform();
                IR_item.Click();
                return true;
            }



           catch
            {
                return false;
            }
        }

        public void PullIRRWithState(string state)
        {
            SeleniumDriver.DriverInstance.SwitchTo().ParentFrame();
            SeleniumDriver.DriverInstance.SwitchTo().Frame("gsft_main");
            IRRFilterDropdwn.SelectOption("State").Click();
            IRRFilterSearch(state);
        }

        private void IRRFilterSearch(string ToSearch)
        {
            //Hardcode a open ticket number for testing purposes
            //IRRSearchBar.SendKeys("INCRES0001227");
            IRRSearchBar.SendKeys(ToSearch);
            action.SendKeys(Keys.Enter).Perform();
        }

        public void Update()
        {
            SeleniumDriver.DriverInstance.SwitchTo().ParentFrame();
            SeleniumDriver.DriverInstance.SwitchTo().Frame("gsft_main");
            
            UpdateBtn.Click();
        }

        public void PullIRRWithNumber(string incidentReportId)
        {
            SeleniumDriver.DriverInstance.SwitchTo().ParentFrame();
            SeleniumDriver.DriverInstance.SwitchTo().Frame("gsft_main");
            IRRFilterDropdwn.SelectOption("Number").Click();
            IRRFilterSearch(incidentReportId);
        }
    }
}