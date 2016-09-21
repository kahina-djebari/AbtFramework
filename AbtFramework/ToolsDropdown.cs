using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AbtFramework
{
    public class ToolsDropdown : PageModel
    {
        [FindsBy(How = How.LinkText, Using = "Abt Talent, Learning and Support (ATLAS)")]    
        private IWebElement Atlas;

       
        [FindsBy(How = How.LinkText, Using = "AbtKnowledge")]
        private IWebElement AbtKnowledge;

        [FindsBy(How = How.LinkText, Using = "AbtTravel Portal")]
        public IWebElement AbtTravel;

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
  

        public void goTo(Abtlinks Page)
        {

            switch (Page)
            {
                case Abtlinks.Oracle:
                    AbtPages.AgiTopNavigation.HoverOverTools();
                    Oracle.Click();
                    wait.Until((d) =>

                    {
                        if (SeleniumDriver.FiringDriver.WindowHandles.Count < 2)
                        {
                            AbtPages.AgiTopNavigation.HoverOverTools();
                            Oracle.Click();
                        }
                        else
                        {
                            StartTimer();
                            return true;
                        }

                      
                        return false;
                        
                        });
                    SeleniumDriver.FiringDriver.Close();
                    SeleniumDriver.FiringDriver.SwitchTo().Window(SeleniumDriver.FiringDriver.WindowHandles.Last());
                    StopTimer();
                    break;

                case Abtlinks.Abt_Talent_Learning_and_Support:

                
                 
                    wait.Timeout = TimeSpan.FromSeconds(30);
                    wait.IgnoreExceptionTypes(typeof(ElementNotVisibleException));
                    wait.Until((e) =>

                    {
                        try
                        {
                            if (SeleniumDriver.FiringDriver.WindowHandles.Count < 2)
                            {
                                action.MoveToElement(AbtPages.AgiTopNavigation.ToolsLink).Perform();
                                Atlas.Click();
                            }
                            else
                            {
                                StartTimer();
                                SingleSignOnProvider = "Simieo";
                                Environment = "Production";
                                return true;
                            }
                        }

                        catch (Exception ex)
                        {

                        }
                        return false;


                    });
                   
                    SeleniumDriver.FiringDriver.Close();
                    SeleniumDriver.FiringDriver.SwitchTo().Window(SeleniumDriver.FiringDriver.WindowHandles.Last());
                    SeleniumDriver.FiringDriver.Manage().Window.Maximize();
                    StopTimer(); break;

                case Abtlinks.AbtKnowledge:

             
                    AbtPages.AgiTopNavigation.HoverOverTools();
                    AbtKnowledge.Click();
                    wait.Until((d) =>

                    {
                        if (SeleniumDriver.FiringDriver.WindowHandles.Count < 2)
                        {
                            AbtPages.AgiTopNavigation.HoverOverTools();
                            AbtKnowledge.Click();
                        }
                        else
                        {
                            StartTimer();
                            return true;
                        }


                        return false;

                    });
                                                                
                    SeleniumDriver.FiringDriver.Close();
                    SeleniumDriver.FiringDriver.SwitchTo().Window(SeleniumDriver.FiringDriver.WindowHandles.Last());
                    SeleniumDriver.FiringDriver.FindElement(By.Id("submitbutton")).Click(); //a windows pop up with a btn "continue to abtKnowledge" finding the element withouth page factory 
                    StopTimer();

                    break;

                case Abtlinks.AbtTravel:
                    
                    finder = new PopupWindowFinder(SeleniumDriver.FiringDriver);
                    popupWindowHandle = finder.Click(AbtTravel);
                    wait.Until(e => SeleniumDriver.FiringDriver.WindowHandles.Count >= 2);
                    SeleniumDriver.Close();
                
                    SeleniumDriver.FiringDriver.SwitchTo().Window(popupWindowHandle);
                    SeleniumDriver.FiringDriver.Manage().Window.Maximize();
                    break;

                case Abtlinks.ISMS:
                    AbtPages.AgiTopNavigation.HoverOverTools();
                    Isms.Click();

                    break;

                case Abtlinks.Outlook:
                
                    wait.Until((d) =>

                    {
                        if (SeleniumDriver.FiringDriver.WindowHandles.Count < 2)
                        {
                            AbtPages.AgiTopNavigation.HoverOverTools();
                            OutlookWeb.Click();
                        }
                        else
                        {
                            StartTimer();
                            SeleniumDriver.Close();
                            return true;
                        }


                        return false;

                    });
                    
                    SeleniumDriver.FiringDriver.SwitchTo().Window(SeleniumDriver.FiringDriver.WindowHandles.Last());
                    StopTimer();
                    break;

                case Abtlinks.RepCapPlanner:
                    AbtPages.AgiTopNavigation.HoverOverTools();
                    RepCapLink.Click();
                    wait.Until((d) =>

                    {
                        if (SeleniumDriver.FiringDriver.WindowHandles.Count < 2)
                        {
                            AbtPages.AgiTopNavigation.HoverOverTools();
                            RepCapLink.Click();
                        }
                        else
                        {
                            StartTimer();
                            return true;
                        }


                        return false;

                    });
                    SeleniumDriver.FiringDriver.Close();
                    SeleniumDriver.FiringDriver.SwitchTo().Window(SeleniumDriver.FiringDriver.WindowHandles.Last());
                    StopTimer();
                    break;

                case Abtlinks.ReputationalCapitalDB:
                    AbtPages.AgiTopNavigation.HoverOverTools();
                    repCapDBPageLink.Click();
                    wait.Until((d) =>

                    {
                        if (SeleniumDriver.FiringDriver.WindowHandles.Count < 2)
                        {
                            AbtPages.AgiTopNavigation.HoverOverTools();
                            repCapDBPageLink.Click();
                        }
                        else
                        {
                            StartTimer();
                            return true;
                        }


                        return false;

                    });
                    SeleniumDriver.FiringDriver.Close();
                    SeleniumDriver.FiringDriver.SwitchTo().Window(SeleniumDriver.FiringDriver.WindowHandles.Last());
                    StopTimer();
                    break;

            }
        }

        public void GoToAtlas()
        {
            goTo(Abtlinks.Abt_Talent_Learning_and_Support);
        }

        internal void AbtTravelLink()
        {
            AbtTravel.Click();

        }
 
        internal void AbtKnowledgeLink()
        {
            AbtKnowledge.Click();
        }

        internal void AtlasLink()
        {
           
            Atlas.Click();
        }

        internal void OracleLink()
        {
            Oracle.Click();
        }

        internal void IsmsLink()
        {
            Isms.Click();
        }

        internal void OutlookLink()
        {
            OutlookWeb.Click();
        }

    }
}