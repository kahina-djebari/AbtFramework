﻿using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;

namespace AbtFramework
{
    public class AgiHomePage : PageModel
    {
        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement HomeLink;
        private QuickLinksModel _quicklinks;

        [FindsBy(How=How.ClassName,Using = "o365cs-me-tileview-container")]
        private IWebElement userCard;

        [FindsBy(How = How.ClassName, Using = "o365cs-me-userDisplayName")]
        private IWebElement username;

        [FindsBy(How=How.Id,Using ="rotator519")]
        private IWebElement todayILearnedLink;

        [FindsBy(How=How.Id,Using = "MSOZoneCell_WebPartWPQ3")]
        private IWebElement newsdiv;

        [FindsBy(How=How.Id,Using = "MSOZoneCell_WebPartWPQ4")]
        private IWebElement DivEvent;

        [FindsBy(How=How.Id,Using = "zz7_RootAspMenu")]
        private IWebElement navlist;

        private IWebElement AboutLink
        {
            get
            {
                return navlist.FindElements(By.TagName("a"))
                    .Where(e => e.GetAttribute("href")
                    .Equals("https://abtassoc.sharepoint.com/aboutabt")).First();
            }
        }

        private IWebElement AbtEventsLink
        {
            get
            {
                return DivEvent.FindElements(By.TagName("a"))
                    .Where(e => e.GetAttribute("href")
                    .Equals("https://abtassoc.sharepoint.com/Happenings/Lists/AbtEvents")).First();

            }
        }

        private IWebElement NewsLink
        {
            get
            {
                return newsdiv.FindElements(By.LinkText("See More")).First();
            }
        }

        private IWebElement TodayILearnedLink
        {
            get
            {
                return todayILearnedLink.FindElements(By.TagName("li")).Single(e => e.Text.Equals("Today I Learned..."));
            }
        }

        public QuickLinksModel QuickLinks { get 
                {
                    _quicklinks = PageGenerator.GetPage<QuickLinksModel>();

                    _quicklinks.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(10));
                _quicklinks.action = new OpenQA.Selenium.Interactions.Actions(SeleniumDriver.Instance);
                    return _quicklinks;
                }
            }

        public void Go()
        {
            try
            {
                StartTimer();
                if (TestCaseGenerator.CurrentTestCase.StepExist("Navigate to Agi Home Page"))
                   TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Navigate to Agi Home Page");
                SeleniumDriver.Instance.Navigate().GoToUrl("http://agi.abtassociates.com");
                Console.WriteLine("Going to AGI Home Page...");
                Console.WriteLine("</br>");
                wait.Until(e => SeleniumDriver.Instance.Title.Equals("Home"));
                StopTimer();
               
                Console.WriteLine("AGI Home Page Loaded in: " + LoadTime);
                Console.WriteLine("</br>");
            }
            catch(Exception ex)
            {
                if (TestCaseGenerator.CurrentTestCase.StepExist("Navigate to Agi Home Page"))
                {
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Navigate to Agi Home Page",ex.Message);
                }

                throw ex;
                    
            }
      

        }

        public bool isUserLoggedin()
        {
            wait.Until(e => userCard.Displayed);
            StopTimer();
            PrintResponseTime("AGI Home Page");
            userCard.Click();
            string User = username.Text;           
            if (User.Equals(SSOCrendentials.CurrentUser))
            {
                Console.WriteLine("User: " + User + " has logged in.");
                return true;

            }
            return false;
        }

        public bool isAt()
        {
            
                if (HomeLink.Enabled)
                {
                    return true;
                }
           
         
            return false;
        }

        public void ClickUntilTitleIs(string title, IWebElement element)
        {
            wait.Until((Func<IWebDriver, bool>)((e) =>
            {
                if (SeleniumDriver.Instance.Title != title)
                {
                    element.Click();
                }

                else
                {
                    
                    return true;
                }

                return false;
            }));
        }

        public void Goto(homelinks link)
        {
            switch (link)
            {
                case homelinks.todayILearned:
                    TodayILearnedLink.Click();
                
                    break;
                case homelinks.News:
                    ClickUntilTitleIs("News Archive", NewsLink);
                    break;

                case homelinks.AbtEvents:

                    AbtEventsLink.Click();
                    break;

                case homelinks.aboutAbt:
                    ClickUntilTitleIs("About Abt", AboutLink);                    
                    break;


            }
        }

      
    }
}