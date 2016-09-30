using System;
using OpenQA.Selenium;

namespace AbtFramework
{
    public class NewsDropdown : PageModel
    {
        public IWebElement Announcements { get { return SeleniumDriver.Instance.FindElement(By.LinkText("Announcements")); } }

        public IWebElement NewsLink { get { return SeleniumDriver.Instance.FindElement(By.LinkText("News")); } }

        public IWebElement EventsLink { get { return SeleniumDriver.Instance.FindElement(By.LinkText("Events")); } }

        public IWebElement NewsArchiveLink { get { return SeleniumDriver.Instance.FindElement(By.LinkText("News Archive")); } }

        private void GoTo(Abtlinks announcements)
        {
            switch (announcements)
            {

                case Abtlinks.NewsArchive:
                    while (SeleniumDriver.Instance.Title.Equals("Home"))
                    {
                        try
                        {
                            action.MoveToElement(NewsLink).Perform();
                            action.MoveToElement(Announcements).Perform();
                            NewsArchiveLink.Click();

                        }

                        catch
                        {

                        }

                    }

                    Console.WriteLine("Clicking on AGI Top Navigation ->News->News Archive");
                    Console.WriteLine("</br>");

                    break;

                case Abtlinks.Events:
                    while (SeleniumDriver.Instance.Title.Equals("Home"))
                    {
                        try
                        {
                            action.MoveToElement(NewsLink).Perform();
                            action.MoveToElement(Announcements).Perform();
                            EventsLink.Click();

                        }

                        catch
                        {

                        }

                    }

                    Console.WriteLine("Clicking on AGI Top Navigation ->News->Events");
                    Console.WriteLine("</br>");

                    break;
                case Abtlinks.Announcements:

                    while (SeleniumDriver.Instance.Title.Equals("Home"))
                    {
                        try
                        {
                            action.MoveToElement(NewsLink).Perform();
                            Announcements.Click();

                        }

                        catch
                        {

                        }

                    }

                    Console.WriteLine("Clicking on AGI Top Navigation ->News->Announcements");
                    Console.WriteLine("</br>");
                    break;
             
            }
        }



        public void GoTo_Announcements()
        {
            GoTo(Abtlinks.Announcements);
        }

        public void GoTo_Events()
        {
            GoTo(Abtlinks.Events);
        }

        public void GoTo_NewsArchive()
        {
            GoTo(Abtlinks.NewsArchive);
        }
    }
}