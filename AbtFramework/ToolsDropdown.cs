using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

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

                                
                    case Abtlinks.AbtExchange:

                    OpenMegaMenuLink("AbtXchange");
                    break;

                    case Abtlinks.Oracle:

                    OpenMegaMenuLink("Oracle");                         
                    break;

                    case Abtlinks.Abt_Talent_Learning_and_Support:

                    OpenMegaMenuLink("Abt Talent, Learning and Support (ATLAS)");                 
                    break;

                    case Abtlinks.AbtKnowledge:

                    OpenMegaMenuLink("AbtKnowledge");
                    try    //Sometimes you're not redirected to Abtknowledge directly
                    {      //and you need to click on a button that says continue to AbtKnowledge
                           //try clicking the button if is there, continue if is not.
                        SeleniumDriver.Instance.FindElement(By.Id("submitbutton")).Click();
                    }
                    catch
                    {

                    }
                    break;

                    case Abtlinks.AbtTravel:

                    OpenMegaMenuLink("AbtTravel Portal");                  
                    break;

                    case Abtlinks.ISMS:

                    OpenMegaMenuLink("ISMS");
                    break;

                    case Abtlinks.Outlook:

                    OpenMegaMenuLink("Outlook Web Access");
                    break;

                    case Abtlinks.RepCapPlanner:

                    OpenMegaMenuLink("RepCap Planner");
                    break;

                    case Abtlinks.ReputationalCapitalDB:

                    OpenMegaMenuLink("Reputational Capital Database");
                    try    //Sometimes you're not redirected to Abtknowledge directly
                    {      //and you need to click on a button that says continue to AbtKnowledge
                           //try clicking the button if is there, continue if is not.
                        SeleniumDriver.Instance.FindElement(By.Id("submitbutton")).Click();
                    }
                    catch
                    {

                    }
                    break;

            }
        }

        private void OpenMegaMenuLink(string linkText)
        {
            while (SeleniumDriver.Instance.WindowHandles.Count < 2)
            {
                try
                {
                    action.MoveToElement(SeleniumDriver.Instance.FindElement(By.LinkText("Tools & Resources"))).Perform();
                    Thread.Sleep(500);
                    SeleniumDriver.Instance.FindElement(By.LinkText(linkText)).Click();
                    Thread.Sleep(1000);
                }

                catch (Exception ex)
                {

                }

            }
            Console.WriteLine("Clicking on dropdown Tools & Resources -> "+linkText);
            Console.WriteLine("</br>");
            StartTimer();
            SeleniumDriver.Close();
            SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.Instance.WindowHandles.Last());
            SeleniumDriver.Instance.Manage().Window.Maximize();
        }

        public void GoToRepCap_Planner()
        {
            goTo(Abtlinks.RepCapPlanner);
        }

        public void GoToRepCapDB()
        {
            goTo(Abtlinks.ReputationalCapitalDB);
        }

        public void GoToAbtExchange()
        {
            goTo(Abtlinks.AbtExchange);
        }

        public void GoToISMS()
        {
            goTo(Abtlinks.ISMS);
        }

        public void GoTo_Concur()
        {
            goTo(Abtlinks.AbtTravel);
        }

        public void GoToAbtKnowledge()
        {
            goTo(Abtlinks.AbtKnowledge);
        }

        public void GoTo_OWA()
        {
            goTo(Abtlinks.Outlook);
        }

        public void GoTo_Oracle()
        {
            goTo(Abtlinks.Oracle);
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