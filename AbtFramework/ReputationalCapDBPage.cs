using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework
{
    public class ReputationalCapDBPage : PageModel
    {
       

        [FindsBy(How = How.TagName, Using = "h1")]
        private IList<IWebElement> headers;

        [FindsBy(How = How.Id, Using = "submitbutton")]
        private IWebElement continueBtn;

        

    

        public bool isAt()
        {
            if(headers.ElementWithTextExists("Reputational Capital Database (RepCapDB)"))
            {
                StopTimer();
                PrintResponseTime("Reputational Capital Database");
                return true;
            }

            return false;
        }

        public bool isUserLoggedIn()
        {
            if (isAt())
            {
                if (AbtPages.AbtKnowledgePage.GetUsername().Equals(SSOCrendentials.CurrentUser))
                {
                    return true;
                }
            }

            return false;
        }

        public void Go()
        {
            StartTimer();
            SeleniumDriver.Instance.Navigate().GoToUrl("http://abtknowledge.corp.abtassoc.com/tldb/main.cfm");
            try
            {
                AbtPages.AbtKnowledgePage.ContinueToAbtKnowledge();
            }
            catch(Exception e)
            {
                
            }
           
            
        }
    }
}