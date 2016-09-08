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
  

        public void goTo(AbtPages Page)
        {

            switch (Page)
            {
                case AbtPages.Oracle:
                    AbtDriver.TopNavigation.HoverOverTools();
                    Oracle.Click();
                    wait.Until((d) =>

                    {
                        if (Driver.seleniumdriver.WindowHandles.Count < 2)
                        {
                            AbtDriver.TopNavigation.HoverOverTools();
                            Oracle.Click();
                        }
                        else
                        {
                            StartTimer();
                            return true;
                        }

                      
                        return false;
                        
                        });
                    Driver.seleniumdriver.Close();
                    Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                    StopTimer();
                    break;

                case AbtPages.Abt_Talent_Learning_and_Support:
                    AbtDriver.TopNavigation.HoverOverTools();
                    Atlas.Click();
                    wait.Until((d) =>

                    {
                        if (Driver.seleniumdriver.WindowHandles.Count < 2)
                        {
                            AbtDriver.TopNavigation.HoverOverTools();
                            Atlas.Click();
                        }
                        else
                        {
                            StartTimer();
                            return true;
                        }


                        return false;

                    });
                    Driver.seleniumdriver.Close();
                    Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                    StopTimer(); break;

                case AbtPages.AbtKnowledge:

             
                    AbtDriver.TopNavigation.HoverOverTools();
                    AbtKnowledge.Click();
                    wait.Until((d) =>

                    {
                        if (Driver.seleniumdriver.WindowHandles.Count < 2)
                        {
                            AbtDriver.TopNavigation.HoverOverTools();
                            AbtKnowledge.Click();
                        }
                        else
                        {
                            StartTimer();
                            return true;
                        }


                        return false;

                    });
                                                                
                    Driver.seleniumdriver.Close();
                    Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                    Driver.seleniumdriver.FindElement(By.Id("submitbutton")).Click(); //a windows pop up with a btn "continue to abtKnowledge" finding the element withouth page factory 
                    StopTimer();

                    break;

                case AbtPages.AbtTravel:

                    finder = new PopupWindowFinder(Driver.seleniumdriver);
                    popupWindowHandle = finder.Click(AbtTravel);
                    Driver.Close();
                    string falsewindow = "";
                   // foreach(var handle in Driver.seleniumdriver.WindowHandles)
                  //  {
                  //      if (!handle.Equals(popupWindowHandle))
                   //     {
                     //       falsewindow = handle;
                   //     }
                    //}
                  //  Driver.seleniumdriver.SwitchTo().Window(falsewindow);
                  //  Driver.Close();
                    Driver.seleniumdriver.SwitchTo().Window(popupWindowHandle);
                    Driver.seleniumdriver.Manage().Window.Maximize();
                    break;

                case AbtPages.ISMS:
                    AbtDriver.TopNavigation.HoverOverTools();
                    Isms.Click();

                    break;

                case AbtPages.Outlook:
                
                    wait.Until((d) =>

                    {
                        if (Driver.seleniumdriver.WindowHandles.Count < 2)
                        {
                            AbtDriver.TopNavigation.HoverOverTools();
                            OutlookWeb.Click();
                        }
                        else
                        {
                            StartTimer();
                            Driver.Close();
                            return true;
                        }


                        return false;

                    });
                    
                    Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                    StopTimer();
                    break;

                case AbtPages.RepCapPlanner:
                    AbtDriver.TopNavigation.HoverOverTools();
                    RepCapLink.Click();
                    wait.Until((d) =>

                    {
                        if (Driver.seleniumdriver.WindowHandles.Count < 2)
                        {
                            AbtDriver.TopNavigation.HoverOverTools();
                            RepCapLink.Click();
                        }
                        else
                        {
                            StartTimer();
                            return true;
                        }


                        return false;

                    });
                    Driver.seleniumdriver.Close();
                    Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                    StopTimer();
                    break;

                case AbtPages.ReputationalCapitalDB:
                    AbtDriver.TopNavigation.HoverOverTools();
                    repCapDBPageLink.Click();
                    wait.Until((d) =>

                    {
                        if (Driver.seleniumdriver.WindowHandles.Count < 2)
                        {
                            AbtDriver.TopNavigation.HoverOverTools();
                            repCapDBPageLink.Click();
                        }
                        else
                        {
                            StartTimer();
                            return true;
                        }


                        return false;

                    });
                    Driver.seleniumdriver.Close();
                    Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                    StopTimer();
                    break;

            }
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