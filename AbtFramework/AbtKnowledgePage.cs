using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
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

  
        public bool isAt()
        {
           string username=divUserInfo.Text.Split('\n')[0].Split(',')[1].Trim();
            Console.WriteLine("AbtKnowledge Page loaded in :" + LoadTime);
            if (username.Equals(SSOCrendentials.CurrentUser))
            {
                return true;
            }
            return false;
        }
    }
}