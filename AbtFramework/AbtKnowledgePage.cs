using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using AbtFramework.SeleniumUtils;

namespace AbtFramework
{
    public class AbtKnowledgePage : PageModel
    {
       
        [FindsBy(How = How.TagName, Using = "h1")]
        private IList<IWebElement> abtKnowledgeText;
        [FindsBy(How=How.ClassName,Using ="akHeaderGreeting")]
        private IWebElement divUserInfo;
        [FindsBy(How=How.LinkText,Using = "Reputational Capital")]
        private IWebElement RepCapLink;
        [FindsBy(How=How.Id,Using = "submitbutton")]
        private IWebElement continuebtn;

        public bool isAt()
        {
            wait.Until(e => e.Title.Equals("AbtKnowledge: AbtKnowledge"));
            StopTimer();
            PrintResponseTime("AbtKnowledge");
            if (RepCapLink.Displayed)
            {                             
                return true;
            }

           
            return false;
        }


        public bool IsUserLoggedIn()
        {
            if (isAt())
            {
                string username = GetUsername(); 

                if (username.Equals(SSOCrendentials.CurrentUser))
                {

                    return true;
                }
               
            }

            return false;
        }

        internal string GetUsername()
        {
           return  divUserInfo.Text.Split('\n')[0].Split(',')[1].Trim();
        }

        public void Go()
        {
            StartTimer();
            SeleniumDriver.DriverInstance.Navigate().GoToUrl("http://abtknowledge.corp.abtassoc.com/");
            ContinueToAbtKnowledge();
            

        }

        internal void ContinueToAbtKnowledge()
        {
            wait.Until(e => continuebtn.Displayed);
            continuebtn.Click();

        }

        public bool isAtRepCapDB()
        {
            wait.Until(e => e.Title.Equals("Reputational Capital Database: Reputational Capital Database"));
            StopTimer();
            PrintResponseTime("Reputational Capital Database");
            if (RepCapLink.Displayed)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}