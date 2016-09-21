using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

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
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("body")));
            if (RepCapLink.Displayed)
            {
                StopTimer();
                Console.WriteLine("AbtKnowledge Page loaded in :" + LoadTime);
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
            SeleniumDriver.FiringDriver.Navigate().GoToUrl("http://abtknowledge.corp.abtassoc.com/");
            ContinueToAbtKnowledge();
            

        }

        internal void ContinueToAbtKnowledge()
        {
            wait.Until(e => continuebtn.Displayed);
            continuebtn.Click();

        }
    }
}