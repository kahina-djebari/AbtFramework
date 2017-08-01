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
        [FindsBy(How = How.LinkText, Using = "ATLAS (Abt Talent, Learning, and Support)")]    
        private IWebElement Atlas;

       
        [FindsBy(How = How.LinkText, Using = "AbtKnowledge")]
        private IWebElement AbtKnowledge;

        [FindsBy(How = How.LinkText, Using = "AbtTravel Online Booking")]
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

        [FindsBy(How=How.LinkText,Using ="AbtXchange")]
        private IWebElement AbtXchange;
        [FindsBy(How=How.LinkText,Using ="Abt Research Library")]
        private IWebElement AbtResearchLibrary;

        public string OpenAbtXchange()
        {
            finder = new PopupWindowFinder(SeleniumDriver.Instance);
          string AbtXchangeHandle= finder.Click(AbtXchange);
            StartTimer();
            return AbtXchangeHandle;

        }

        public IWebElement ToolsAndResources { get { return SeleniumDriver.Instance.FindElement(By.LinkText("Tools & Resources")); } }

        public void goTo(Abtlinks Page)
        {

            switch (Page)
            {

                case Abtlinks.TravelOnline:

                    OpenMegaMenuLink("AbtTravel Online Booking");

                    break;
                case Abtlinks.EmergencyCommunications:

                    OpenServiceCenterLink("Emergency Communications");
                    break;

                case Abtlinks.Resources:

                    OpenServiceCenterLink("Resources");
                    

                    break;

                case Abtlinks.ExpertiseCenters:
                    OpenServiceCenterLink("Expertise Centers");
                    break;
                case Abtlinks.ProposalLibrary:
                    OpenServiceCenterLink("Proposal Resume Library");
                    break;
                case Abtlinks.PolicyLibrary:

                    OpenServiceCenterLink("Policy Library");
                    break;
                case Abtlinks.ImageLibraries:

                    OpenServiceCenterLink("Image Libraries");
                    break;

                case Abtlinks.FormLibrary:
                    OpenServiceCenterLink("Form Library");
                    break;

                case Abtlinks.AbtResearchLibrary:

                    if (TestCaseGenerator.CurrentTestCase.StepExist("Hover over Tools & Resources"))
                        TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Hover over Tools & Resources");
                    OpenServiceCenterLink("Abt Research Library");

                    try
                    {
                        if (TestCaseGenerator.CurrentTestCase.StepExist("Click on Abt Research Library"))
                        {
                            TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Click on Abt Research Library");
                        }
                    }
                    catch (Exception ex)
                    {
                        if (TestCaseGenerator.CurrentTestCase.StepExist("Click on Abt Research Library"))
                        {
                            TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Click on Abt Research Library", ex.Message);
                        }
                       
                        throw (ex);
                    }

                    break;

                case Abtlinks.Travel:
                    OpenServiceCenterLink("Travel");

                    break;
                case Abtlinks.ReputationalCapital:

                    OpenServiceCenterLink("Reputational Capital");
                    break;

                case Abtlinks.OfficeServices:

                    OpenServiceCenterLink("Office Services");
                    break;

                case Abtlinks.ITServiceCenter:
                    OpenServiceCenterLink("IT Service Center");

                    break;

                case Abtlinks.HRServiceCenter:
                    OpenServiceCenterLink("HR Service Center");

                    break;

                case Abtlinks.Finance:
                    OpenServiceCenterLink("Finance");
                    break;

                case Abtlinks.CreativeServices:

                    OpenServiceCenterLink("Creative Services");
                    break;

                case Abtlinks.ContractOperations:
                    OpenServiceCenterLink("Contract Operations");

                    break;

                case Abtlinks.CTC:
                    OpenServiceCenterLink("Client Technology Center (CTC)");

                    break;
                case Abtlinks.BusinessDevelopment:
                    OpenServiceCenterLink("Business Development");
                    break;

                case Abtlinks.AbtLearn:

                    OpenServiceCenterLink("AbtLearn");
                    break;
                                
                    case Abtlinks.AbtExchange:

                    OpenMegaMenuLink("AbtXchange");
                    try
                    {
                        SeleniumDriver.Instance.FindElement(By.LinkText("Log In")).Click();
                        StartTimer();
                        if (TestCaseGenerator.CurrentTestCase.StepExist("Click on Log In"))
                        {
                            TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Click on Log In");
                        }
                    }

                    catch(Exception ex)
                    {
                        if (TestCaseGenerator.CurrentTestCase.StepExist("Click on Log In"))
                        {
                            TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Click on Log In",ex.Message);
                        }
                        break;
                        throw (ex);
                    }
                   
                   
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

        public void OpenAbtResearchLibrary()
        {
            AbtResearchLibrary.Click();
            
        }

        public string OpenAbtTravel()
        {
            
            finder = new PopupWindowFinder(SeleniumDriver.Instance);
           string handle=finder.Click(AbtTravel);
            StartTimer();
            return handle;
        }

        public string OpenSuccessFactors()
        {
            finder = new PopupWindowFinder(SeleniumDriver.Instance);
          string WinHandle=finder.Click(Atlas);
           StartTimer();
            return WinHandle;
        }


        private void OpenServiceCenterLink(string linkText)
        {
            var StartDebugTimer = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            while (SeleniumDriver.Instance.Title.Equals("Home"))
            {
                try
                {
                    action.MoveToElement(ToolsAndResources).Perform();
                    Thread.Sleep(500);
                    SeleniumDriver.Instance.FindElement(By.LinkText(linkText)).Click();
                    Thread.Sleep(1000);
                }

                catch
                {

                }

            }


            Console.WriteLine("Clicking on dropdown Tools & Resources ->" + linkText);
            Console.WriteLine("</br>");
            
        }

        private void OpenMegaMenuLink(string linkText)
        {
            var tempTimer = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            while (SeleniumDriver.Instance.WindowHandles.Count < 2)
            {
                try
                {
                    action.MoveToElement(ToolsAndResources).Perform();
                    Thread.Sleep(500);
                    SeleniumDriver.Instance.FindElement(By.LinkText(linkText)).Click();
                    Thread.Sleep(1000);
                }

                catch (Exception ex)
                {
                    var temTimer2 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                    Console.WriteLine("Timer 2:" + temTimer2);
                    Console.WriteLine("Timer 1:" + tempTimer);
                    var timediff = temTimer2 - tempTimer;
                    Console.WriteLine(timediff + "ms");
                    if ((timediff > 50000))
                    {
                        // Console.WriteLine("timer diff is longer than 5segs: " + timediff + " ms");
                        if (TestCaseGenerator.CurrentTestCase.StepExist("Click on "+linkText))
                        {
                            TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Click on "+linkText,ex.Message);
                            
                        }
                        if (TestCaseGenerator.CurrentTestCase.StepExist("Hover over Tools & Resources"))
                        {
                            TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Hover over Tools & Resources",ex.Message);
                           
                        }


                        throw ex;


                    }
                }

              
               

            }

            Console.WriteLine("Clicking on dropdown Tools & Resources -> "+linkText);
            Console.WriteLine("</br>");
            if (TestCaseGenerator.CurrentTestCase.StepExist("Hover over Tools & Resources"))
                TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Hover over Tools & Resources");
            if (TestCaseGenerator.CurrentTestCase.StepExist("Click on "+linkText))
                TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Click on "+linkText);
            StartTimer();
            SeleniumDriver.Close();

            SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.Instance.WindowHandles.Last());
            SeleniumDriver.Instance.Manage().Window.Maximize();
        }

        public void GoTo_CreativeServices()
        {
            goTo(Abtlinks.CreativeServices);
        }

        public void GoTo_ContractOperations()
        {
            goTo(Abtlinks.ContractOperations);
        }

        public void GoTo_CTC()
        {
            goTo(Abtlinks.CTC);
        }

        public void GoTo_Finance()
        {
            goTo(Abtlinks.Finance);
        }

        public void GoToBusinessDevelopment()
        {
            goTo(Abtlinks.BusinessDevelopment);
        }

        public void GoTo_HRServiceCenter()
        {
            goTo(Abtlinks.HRServiceCenter);
        }

        public void GoToAbtLearn()
        {
            goTo(Abtlinks.AbtLearn);
        }

        public void GoToRepCap_Planner()
        {
            goTo(Abtlinks.RepCapPlanner);
        }

        public void GoTo_ITServiceCenter()
        {
            goTo(Abtlinks.ITServiceCenter);
        }

        public void GoToRepCapDB()
        {
            goTo(Abtlinks.ReputationalCapitalDB);
        }

        public void GoTo_OfficeServices()
        {
            goTo(Abtlinks.OfficeServices);
        }

        public void GoToAbtExchange()
        {
            goTo(Abtlinks.AbtExchange);
        }

        public void GoTo_ReputationalCapital()
        {
            goTo(Abtlinks.ReputationalCapital);
        }

        public void GoToISMS()
        {
            goTo(Abtlinks.ISMS);
        }

        public void GoTo_Concur()
        {
            goTo(Abtlinks.TravelOnline);
        }

        public void GoTo_Travel()
        {
            goTo(Abtlinks.TravelOnline);
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

        public void GoTo_AbtResearchLibrary()
        {
            goTo(Abtlinks.AbtResearchLibrary);
        }

        public void GoToAtlas()
        {
            goTo(Abtlinks.Abt_Talent_Learning_and_Support);
        }

        public void GoTo_FormLibrary()
        {
            goTo(Abtlinks.FormLibrary);
        }

        internal void AbtTravelLink()
        {
            AbtTravel.Click();

        }

        public void GoTo_ImageLibraries()
        {
            goTo(Abtlinks.ImageLibraries);
        }

        internal void AbtKnowledgeLink()
        {
            AbtKnowledge.Click();
        }

        internal void AtlasLink()
        {
           
            Atlas.Click();
        }

        public void GoTo_PolicyLibrary()
        {
            goTo(Abtlinks.PolicyLibrary);
        }

        internal void OracleLink()
        {
            Oracle.Click();
        }

        public void GoTo_ProposalLibrary()
        {
            goTo(Abtlinks.ProposalLibrary);
        }

        internal void IsmsLink()
        {
            Isms.Click();
        }

        internal void OutlookLink()
        {
            OutlookWeb.Click();
        }

        public void GoTo_ExpertiseCenters()
        {
            goTo(Abtlinks.ExpertiseCenters);
        }

        public void GoTo_Resources()
        {
            goTo(Abtlinks.Resources);
        }

        public void GoTo_EmergencyCommunications()
        {
            goTo(Abtlinks.EmergencyCommunications);
        }
    }
}