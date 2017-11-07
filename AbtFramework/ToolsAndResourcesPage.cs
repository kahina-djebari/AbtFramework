using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using AbtFramework.Utils_Classes.SeleniumUtils;

namespace AbtFramework
{
    public class ToolsAndResourcesPage : PageModel
    {
        [FindsBy(How=How.Id,Using = "WebPartCaptionWPQ4")]
        private IWebElement LibrariesHeader;

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

        [FindsBy(How = How.LinkText, Using = "RepCap Planner")]
        private IWebElement RepCapLink;

        [FindsBy(How = How.LinkText, Using = "Reputational Capital Database")]
        private IWebElement repCapDBPageLink;

        private void goTo(Abtlinks Page)
        {
            switch (Page)
            {
                case Abtlinks.Oracle: 
                  
                    OpenWindowFor(Oracle);
                    StopTimer();
                    break;

                case Abtlinks.Abt_Talent_Learning_and_Support:

                   // StartTimer();
                    OpenWindowFor(Atlas);
                    SingleSignOnProvider = "Simieo";
                    _Environment = "Production";
                   
                  

                    break;

                case Abtlinks.AbtKnowledge: 
                    StartTimer();
                    wait.Until(d => this.AbtKnowledge.Displayed);
                    AbtKnowledge.Click();
                    wait.Until(d => SeleniumDriver.DriverInstance.WindowHandles.Count >= 2);
                    SeleniumDriver.DriverInstance.Close();
                    SeleniumDriver.DriverInstance.SwitchTo().Window(SeleniumDriver.DriverInstance.WindowHandles.Last());
                    SeleniumDriver.DriverInstance.FindElement(By.Id("submitbutton")).Click(); //a windows pop up with a btn "continue to abtKnowledge" finding the element withouth page factory 
                    StopTimer(); 

                    break;

                case Abtlinks.AbtTravel:  
                    StartTimer();
                    wait.Until(d => this.AbtTravel.Displayed);
                    AbtTravel.Click();
                    wait.Until(d => SeleniumDriver.DriverInstance.WindowHandles.Count >= 2);
                    SeleniumDriver.DriverInstance.Close();
                    SeleniumDriver.DriverInstance.SwitchTo().Window(SeleniumDriver.DriverInstance.WindowHandles.Last());
                    StopTimer();
                    break;

                case Abtlinks.ISMS:

                    Isms.Click();
                    StartTimer();
                    break;

                case Abtlinks.Outlook: 
                    StartTimer();
                    OpenWindowFor(OutlookWeb);

                    //StopTimer();
                    break;

                case Abtlinks.RepCapPlanner: 
                    StartTimer();
                    RepCapLink.Click();
                    wait.Until(d => SeleniumDriver.DriverInstance.WindowHandles.Count >= 2);
                    SeleniumDriver.DriverInstance.Close();
                    SeleniumDriver.DriverInstance.SwitchTo().Window(SeleniumDriver.DriverInstance.WindowHandles.Last());
                    StopTimer();
                    break;

                case Abtlinks.ReputationalCapitalDB: 
                    StartTimer();
                    OpenWindowFor(repCapDBPageLink);
                    try
                    {
                        AbtPages.AbtKnowledgePage.ContinueToAbtKnowledge();
                    }
                    catch (Exception e)
                    {

                    }
                    break;

            }

        }

        public void GoTo_OWA()
        {

            goTo(Abtlinks.Outlook);
           /*
            finder = new PopupWindowFinder(SeleniumDriver.DriverInstance);

          popupWindowHandle = finder.Click(OutlookWeb);
            StartTimer();
            wait.Until(e=>SeleniumDriver.DriverInstance.WindowHandles.Count() >= 2);
            SeleniumDriver.Close();
            SeleniumDriver.DriverInstance.SwitchTo().Window(popupWindowHandle);
            */

        }

        public void GoToRepCapDB()
        {
            goTo(Abtlinks.ReputationalCapitalDB);
        }

        public void GoToIsms()
        {
            goTo(Abtlinks.ISMS);
        }

        private void OpenWindowFor(IWebElement link)
        {
            finder = new PopupWindowFinder(SeleniumDriver.DriverInstance);
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Until(e => link.Displayed);
            popupWindowHandle = finder.Click(link);
         //   var currentHandler = SeleniumDriver.DriverInstance.CurrentWindowHandle;
         //   Console.WriteLine("This is the first popwindowHandle:");
          //  Console.WriteLine(currentHandler);
            wait.Until(d => SeleniumDriver.DriverInstance.WindowHandles.Count >= 2);
            StartTimer();
            SeleniumDriver.DriverInstance.SwitchTo().Window(popupWindowHandle);
            SeleniumDriver.DriverInstance.Manage().Window.Maximize();
        }

        public void GoToAtlas()
        {
            goTo(Abtlinks.Abt_Talent_Learning_and_Support);
        }

        public bool isAt()
        {
            
                if (LibrariesHeader.Enabled)
                {
                   
                    return true;
                }
                        
            return false;
        }

        public void Goto_Oracle()
        {
            goTo(Abtlinks.Oracle);
        }
    }
}