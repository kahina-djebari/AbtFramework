using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;

namespace AbtFramework
{
    public class HomePage : PageModel
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

                    _quicklinks.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(10));
                _quicklinks.action = new OpenQA.Selenium.Interactions.Actions(Driver.seleniumdriver);
                    return _quicklinks;
                }
            }

        public void Go()
        {
            StartTimer();
            Driver.seleniumdriver.Navigate().GoToUrl("http://agi.abtassociates.com");
            wait.Until(e => Driver.seleniumdriver.Title.Equals("Home"));
            StopTimer();
            Console.WriteLine("Agi Home Page Loaded in: " + LoadTime);
            Console.WriteLine("</br>");

        }

        public bool isUserLoggedin()
        {
            userCard.Click();
                            
            if (username.Text.Equals(SSOCrendentials.CurrentUser))
            {
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
            wait.Until((e) =>
            {
                if (Driver.seleniumdriver.Title != title)
                {
                    element.Click();
                }

                else
                {
                    
                    return true;
                }

                return false;
            });
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