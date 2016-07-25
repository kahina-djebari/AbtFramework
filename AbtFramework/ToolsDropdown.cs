using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class ToolsDropdown : PageModel
    {
        [FindsBy(How = How.LinkText, Using = "ATLAS (Abt Talent, Learning, and Support)")]    
        private IWebElement Atlas;

       
        [FindsBy(How = How.LinkText, Using = "AbtKnowledge")]
        private IWebElement AbtKnowledge;

        [FindsBy(How = How.LinkText, Using = "AbtTravel Portal")]
        private IWebElement AbtTravel;

        [FindsBy(How = How.LinkText, Using = "Oracle")]
        private IWebElement Oracle;

        [FindsBy(How = How.LinkText, Using = "ISMS")]
        private IWebElement Isms;

        [FindsBy(How = How.LinkText, Using = "Outlook Web Access")]
        private IWebElement OutlookWeb;

        internal void AbtTravelLink()
        {
            AbtTravel.Click();

        }

        internal void AbtKnowledgeLink()
        {
            AbtKnowledge.Click();
        }

        internal void AtlasLink()
        {
           
            Atlas.Click();
        }

        internal void OracleLink()
        {
            Oracle.Click();
        }

        internal void IsmsLink()
        {
            Isms.Click();
        }

        internal void OutlookLink()
        {
            OutlookWeb.Click();
        }

    }
}