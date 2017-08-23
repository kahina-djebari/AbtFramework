using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Threading;

namespace AbtFramework
{
    public class AgiHomePage : PageModel
    {
        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement HomeLink;

        [FindsBy(How = How.CssSelector, Using = "p:nth-child(1) > a:nth-child(1) > img:nth-child(1)")]
        private IWebElement AbtXChangeImg;

        [FindsBy(How = How.LinkText, Using = "AbtTravel Online Booking Tool")]
        private IWebElement AbtTravelLink;

        private QuickLinksModel _quicklinks;

        [FindsBy(How=How.ClassName,Using = "o365cs-me-tileview-container")]
        private IWebElement userCard;

        [FindsBy(How = How.Id, Using = "quicklinks")]
        private IWebElement quicklinks;

        [FindsBy(How = How.ClassName, Using = "o365cs-me-userDisplayName")]
        private IWebElement username;

        public string GetResponseTime()
        {
            return LoadTime;
        }

        [FindsBy(How=How.ClassName,Using ="intro")]
        private IWebElement todayILearnedLink;

        [FindsBy(How=How.Id,Using = "MSOZoneCell_WebPartWPQ3")]
        private IWebElement newsdiv;

        [FindsBy(How=How.Id,Using = "MSOZoneCell_WebPartWPQ4")]
        private IWebElement DivEvent;

        [FindsBy(How=How.Id,Using = "zz7_RootAspMenu")]
        private IWebElement navlist;
        [FindsBy(How=How.ClassName,Using ="author")]
        private IWebElement _insightAuthor;
        [FindsBy(How=How.ClassName,Using ="title")]
        private IWebElement _insightTitle;
        [FindsBy(How=How.ClassName,Using ="headerlink")]
        private IList<IWebElement> _seeMoreLinks;

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

        public IWebElement SeeMoreEvents { get { return _seeMoreLinks.Single(e => e.GetAttribute("href").Equals("https://abtassoc.sharepoint.com/Happenings/Lists/AbtEvents")); } }

        public Insight OpenTodaysInsight()
        {
            Insight insight = new Insight();
            insight.Author = InsightAuthor;
            insight.Title = InsightTitle;
            todayILearnedLink.Click();
            return insight;

        }

        public QuickLinksModel QuickLinks { get 
                {
                    _quicklinks = PageGenerator.GetPage<QuickLinksModel>();

                    _quicklinks.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(10));
                _quicklinks.action = new OpenQA.Selenium.Interactions.Actions(SeleniumDriver.Instance);
                    return _quicklinks;
                }
            }

        public void OpenAbtEvents()
        {
            SeeMoreEvents.Click();
          
        }

        public void goToAbtXchange()
        {
            wait.Until(e => AbtXChangeImg.Displayed);
            AbtXChangeImg.Click();

        }

        public string InsightAuthor { get { return _insightAuthor.Text; } }

        public string InsightTitle { get { return _insightTitle.Text; } }

      

        public void Go()
        {
            StartTimer();
            SeleniumDriver.Instance.Navigate().GoToUrl("http://agiokta.abtassociates.com");
        }

        // use this method to avoid the mega menu shared point issues.
        public void GoToToolsNResources()
        {
            StartTimer();
            //since its a clean session we go to agi to make o
            SeleniumDriver.Instance.Navigate().GoToUrl("http://agiokta.abtassociates.com");
            Thread.Sleep(6000);
            SeleniumDriver.Instance.Navigate().GoToUrl("https://abtassoc.sharepoint.com/ToolsResources/Pages/ServiceCenters.aspx");
        }

        public void WaitForHomeToLoad()
        {
            wait.Until(e => HomeLink.Displayed);
            StopTimer();
        }

        public void WaitForAbtTravelToLoad()
        {
            wait.Until(e => AbtTravelLink.Displayed);
            AbtTravelLink.Click();
            StopTimer();
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
            try
            {
                //  StartTimer();
                wait.Until(e => HomeLink.Displayed);
                StopTimer();
                if (TestCaseGenerator.CurrentTestCase.StepExist("Check if Home TopNavigation Bar is Displayed"))
                {
                    if (TestCaseGenerator.CurrentTestCase.IsResponseTimeRequired)
                    {
                        TestCaseGenerator.CurrentTestCase.SetResponseTime(timer2 - timer1);
                        TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Check if Home TopNavigation Bar is Displayed");
                    }
                   


                }
                 
            //    SeleniumDriver.Instance.Navigate().GoToUrl("https:/agiokta.abtassociates.com");
              //  Console.WriteLine("Going to AGI Home Page...");
               // Console.WriteLine("</br>");
              //  wait.Until(e => SeleniumDriver.Instance.Title.Equals("Home"));

                

             //   Console.WriteLine("AGI Home Page Loaded in: " + LoadTime);
               // Console.WriteLine("</br>");
            }
            catch (Exception ex)
            {
                if (TestCaseGenerator.CurrentTestCase.StepExist("Check if Home TopNavigation Bar is Displayed"))
                {
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Check if Home TopNavigation Bar is Displayed", ex.Message);
                }

                throw ex;

            }


            return true;
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

        public void HoverOverQuickLinks()
        {
            action.MoveToElement(quicklinks).Perform();
        }
    }
}