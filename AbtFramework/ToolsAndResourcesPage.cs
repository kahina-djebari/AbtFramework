using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void Go()
        {
            
            AbtDriver.TopNavigation.ToolsLink();
        }
        
        public void goTo(AbtPages Page)
        {
            switch (Page)
            {
                case AbtPages.Oracle: 
                    StartTimer();
                    Oracle.Click();
                    wait.Until(d => Driver.seleniumdriver.WindowHandles.Count >= 2);
                    Driver.seleniumdriver.Close();
                    Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                    StopTimer();
                    break;

                case AbtPages.Abt_Talent_Learning_and_Support: 
                                                StartTimer();
                                                Atlas.Click();
                                                wait.Until(d => Driver.seleniumdriver.WindowHandles.Count >= 2);
                                                Driver.seleniumdriver.Close();
                                                Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                                                StopTimer(); break;

                case AbtPages.AbtKnowledge: 
                    StartTimer();
                    wait.Until(d => this.AbtKnowledge.Displayed);
                    AbtKnowledge.Click();
                    wait.Until(d => Driver.seleniumdriver.WindowHandles.Count >= 2);
                    Driver.seleniumdriver.Close();
                    Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                    Driver.seleniumdriver.FindElement(By.Id("submitbutton")).Click(); //a windows pop up with a btn "continue to abtKnowledge" finding the element withouth page factory 
                    StopTimer(); 

                    break;

                case AbtPages.AbtTravel:  
                    StartTimer();
                    wait.Until(d => this.AbtTravel.Displayed);
                    AbtTravel.Click();
                    wait.Until(d => Driver.seleniumdriver.WindowHandles.Count >= 2);
                    Driver.seleniumdriver.Close();
                    Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                    StopTimer();
                    break;

                case AbtPages.ISMS: Isms.Click(); break;

                case AbtPages.Outlook: 
                    StartTimer();
                    OutlookWeb.Click();
                    wait.Until(d => Driver.seleniumdriver.WindowHandles.Count >= 2);
                    Driver.seleniumdriver.Close();
                    Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                    StopTimer();
                    break;

                case AbtPages.RepCapPlanner: 
                    StartTimer();
                    RepCapLink.Click();
                    wait.Until(d => Driver.seleniumdriver.WindowHandles.Count >= 2);
                    Driver.seleniumdriver.Close();
                    Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                    StopTimer();
                    break;

                case AbtPages.ReputationalCapitalDB: 
                    StartTimer();
                    repCapDBPageLink.Click();
                    wait.Until(d => Driver.seleniumdriver.WindowHandles.Count >= 2);
                    Driver.seleniumdriver.Close();
                    Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                    StopTimer();
                    break;

            }

        }

        public bool isAt()
        {
            
                if (LibrariesHeader.Enabled)
                {
                   
                    return true;
                }
                        
            return false;
        }
    }
}