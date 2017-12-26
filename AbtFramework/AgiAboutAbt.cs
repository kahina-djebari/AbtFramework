using AbtFramework.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using AbtFramework.Utils_Classes.SeleniumUtils;

namespace AbtFramework
{
    public class AgiAboutAbt : PageModel
    {
       
        [FindsBy(How=How.ClassName,Using ="PageHeader")]
        public IWebElement pageHeader;
        [FindsBy(How=How.LinkText,Using = "We Are Abt")]
        private IWebElement _weAreAbt;
        [FindsBy(How=How.LinkText,Using ="Elevator Speech")]
        private IWebElement _elevatorSpeech;
        [FindsBy(How = How.LinkText, Using = "Management Advisory Group (MAG)")]
        private IWebElement _mga;
        [FindsBy(How = How.LinkText, Using = "Office Locations")]
        private IWebElement _officeLocations;
        [FindsBy(How = How.LinkText, Using = "Bethesda")]
        private IWebElement _bethesda;
        [FindsBy(How = How.LinkText, Using = "Cambridge")]
        private IWebElement _cambridge;
        [FindsBy(How = How.LinkText, Using = "Abt Café at Cambridge")]
        private IWebElement _cambridgeCafe;
        [FindsBy(How = How.LinkText, Using = "Abt Cambridge Softball")]
        private IWebElement _cambridgeSoftball;
        [FindsBy(How = How.LinkText, Using = "Cambridge Shuttle Schedule")]
        private IWebElement _cambridgeShuttle;
        [FindsBy(How = How.LinkText, Using = "Durham")]
        private IWebElement _durham;
        [FindsBy(How = How.LinkText, Using = "History")]
        private IWebElement _history;
        [FindsBy(How=How.Id,Using = "WebPartTitleWPQ4")]
        private IWebElement _historyWrapper;
        [FindsBy(How=How.ClassName,Using = "breadcrumbCurrentNode")]
        public IWebElement _breadCrumbsCurrentNode;
        [FindsBy(How=How.ClassName,Using = "breadcrumbRootNode")]
        private IList<IWebElement> _breadCrumbsRootNode;
        [FindsBy(How = How.ClassName, Using = "breadcrumbNode")]
        private IList<IWebElement> _breadCrumbsNode;
        [FindsBy(How=How.Id,Using = "ms-lstItmLinkAnchor")]
        private IList<IWebElement> _linksMenuWrapper;
        [FindsBy(How=How.Id,Using = "SwitchToReadingMode - Small14")]
        private IWebElement _viewPresentation;
       

        public bool IsMGASectionOpen {
            get {
                if (pageHeader.Text.Equals("MANAGEMENT ADVISORY GROUP (MAG)"))
                {
                    return true;
                }
                else { return false; }
            }
        }
        public bool IsElevatorSpeechSectionOpen
        {
            get
            {
                if (pageHeader.Text.Equals("ELEVATOR SPEECH"))
                {
                    return true;
                }
                else { return false; }
            }
        }
        public bool IsWeAreAbtSectionOpen {
            get
            {
                //wait.IgnoreExceptionTypes(typeof(Element))
                wait.Until(e => pageHeader.Text.Equals("WE ARE ABT"));
                return true;
               
            }
        }
        public bool IsOfficeLocationsSectionOpen {
            get
            {
                wait.Until(e => pageHeader.Text.Equals("OFFICE LOCATIONS"));
               return true;
            }
        }
        public bool IsBethesdaSectionOpen {
            get
            {
                wait.Until(e => pageHeader.Text.Equals("BETHESDA"));
                return true;
            }
        }
        public bool IsCambridgeSectionOpen {
            get
            {
                wait.Until(e => pageHeader.Text.Equals("CAMBRIDGE"));
               return true;
            }
        }
        public bool IsCambridgeCafeSectionOpen {
            get
            {
                wait.Until(e => pageHeader.Text.Equals("ABT CAFÉ AT CAMBRIDGE"));
               return true;
            }
        }
        public bool IsCambridgeSoftballSectionOpen {
            get
            {
                wait.Until(e => pageHeader.Text.Equals("ABT CAMBRIDGE SOFTBALL"));
               return true;
            }
        }
        public bool IsCambridgeShuttleSectionOpen {
            get
            {
                wait.Until(e => pageHeader.Text.Equals("CAMBRIDGE SHUTTLE SCHEDULE"));
               return true;
            }
        }
        public bool IsDurhamSectionOpen {
            get
            {
                wait.Until(e => pageHeader.Text.Equals("DURHAM"));
               return true;
            }
        }
        public bool IsHistorySectionOpen {
            get
            {
                wait.Until(e => _historyWrapper.GetAttribute("title").Equals("History - Allows authors to enter rich text content."));
                return true;
            }
        }

        public bool IsWeAreAbtBreadcrumbsCorrect
        {
            get
            {
                wait.Until(e => _breadCrumbsCurrentNode.Text.Equals("We Are Abt"));
                if (_breadCrumbsRootNode.Count<2&& _breadCrumbsNode.Count<2&&
                    _breadCrumbsRootNode[0].Text.Equals("Home") &&
                    _breadCrumbsNode[0].Text.Equals("About Abt"))
                {
                    return true;
                }
                else
                {
                   

                    return false;
                }
               
            }
        }
        public bool IsElevatorSpeechBreadcrumbsCorrect
        {
            get
            {
                wait.Until(e => _breadCrumbsCurrentNode.Text.Equals("Elevator Speech"));
                if (_breadCrumbsRootNode.Count < 2 && _breadCrumbsNode.Count < 2 &&
                    _breadCrumbsRootNode[0].Text.Equals("Home") &&
                    _breadCrumbsNode[0].Text.Equals("About Abt"))
                {
                    return true;
                }
                return false;
            }
        }
        public bool IsMGABreadcrumbsCorrect
        {
            get
            {
                wait.Until(e => _breadCrumbsCurrentNode.Text.Equals("Management Advisory Group (MAG)"));
                if (_breadCrumbsRootNode.Count < 2 && _breadCrumbsNode.Count < 2 &&
                    _breadCrumbsRootNode[0].Text.Equals("Home") &&
                    _breadCrumbsNode[0].Text.Equals("About Abt"))
                {
                    return true;
                }
                return false;
            }
        }
        public bool IsOfficeLocationsBreadcrumbsCorrect
        {
            get
            {
                wait.Until(e => _breadCrumbsCurrentNode.Text.Equals("Office Locations"));
                if (_breadCrumbsRootNode.Count < 2 && _breadCrumbsNode.Count < 2 &&
                    _breadCrumbsRootNode[0].Text.Equals("Home") &&
                    _breadCrumbsNode[0].Text.Equals("About Abt"))
                {
                    return true;
                }
                return false;
            }
        }
        public bool IsBethesdaBreadcrumbsCorrect
        {
            get
            {
                wait.Until(e => _breadCrumbsCurrentNode.Text.Equals("Bethesda"));
                if (_breadCrumbsRootNode.Count < 2 && _breadCrumbsNode.Count < 2 &&
                    _breadCrumbsRootNode[0].Text.Equals("Home") &&
                    _breadCrumbsNode[0].Text.Equals("About Abt"))
                {
                    return true;
                }
                return false;
            }
        }
        public bool IsCambridgeBreadcrumbsCorrect
        {
            get
            {
                wait.Until(e => _breadCrumbsCurrentNode.Text.Equals("Cambridge"));
                if (_breadCrumbsRootNode.Count < 2 && _breadCrumbsNode.Count < 2 &&
                    _breadCrumbsRootNode[0].Text.Equals("Home") &&
                    _breadCrumbsNode[0].Text.Equals("About Abt"))
                {
                    return true;
                }
                return false;
            }
        }
        public bool IsCambridgeCafeBreadcrumbsCorrect
        {
            get
            {
                wait.Until(e => _breadCrumbsCurrentNode.Text.Equals("Abt Café at Cambridge"));
                if (_breadCrumbsRootNode.Count < 2 && _breadCrumbsNode.Count < 2 &&
                    _breadCrumbsRootNode[0].Text.Equals("Home") &&
                    _breadCrumbsNode[0].Text.Equals("About Abt"))
                {
                    return true;
                }
                return false;
            }
        }
        public bool IsCambridgeSoftballBreadcrumbsCorrect
        {
            get
            {
                wait.Until(e => _breadCrumbsCurrentNode.Text.Equals("Abt Cambridge Softball"));
                if (_breadCrumbsRootNode.Count < 2 && _breadCrumbsNode.Count < 2 &&
                     _breadCrumbsRootNode[0].Text.Equals("Home") &&
                     _breadCrumbsNode[0].Text.Equals("About Abt"))
                {
                    return true;
                }
                return false;
            }
        }
        public bool IsCambridgeShuttleBreadcrumbsCorrect
        {
            get
            {
                wait.Until(e => _breadCrumbsCurrentNode.Text.Equals("Cambridge Shuttle Schedule"));
                if (_breadCrumbsRootNode.Count < 2 && _breadCrumbsNode.Count < 2 &&
                      _breadCrumbsRootNode[0].Text.Equals("Home") &&
                      _breadCrumbsNode[0].Text.Equals("About Abt"))
                {
                    return true;
                }
                return false;
            }
        }
        public bool IsDurhamBreadcrumbsCorrect
        {
            get
            {
                wait.Until(e => _breadCrumbsCurrentNode.Text.Equals("Durham"));
                if (_breadCrumbsRootNode.Count < 2 && _breadCrumbsNode.Count < 2 &&
                      _breadCrumbsRootNode[0].Text.Equals("Home") &&
                      _breadCrumbsNode[0].Text.Equals("About Abt"))
                {
                    return true;
                }
                return false;
            }
        }
        public bool IsHistoryBreadcrumbsCorrect
        {
            get
            {
                wait.Until(e => _breadCrumbsCurrentNode.Text.Equals("History"));
                if (_breadCrumbsRootNode.Count < 2 && _breadCrumbsNode.Count < 2 &&
                      _breadCrumbsRootNode[0].Text.Equals("Home") &&
                      _breadCrumbsNode[0].Text.Equals("About Abt"))
                {
                    return true;
                }
                return false;
            }
        }

        public string CurrentBreadCrumbsPath {
            get
            {
                string path="";
                string rootNode = "";
                string node = "";
               foreach(IWebElement el in _breadCrumbsRootNode)
                {
                  rootNode= rootNode+ el.Text + "->";
                  
                } 
               foreach(IWebElement el in _breadCrumbsNode)
                {
                    node =  node+ el.Text + "->";
                   
                }
                path = rootNode + node + _breadCrumbsCurrentNode.Text;
                return path;
            }
      }

        public IWebElement FileMenu { get { return _linksMenuWrapper.Single(e => e.GetAttribute("title").Equals("Open Menu dialog for selected item")); } }

        public bool IsAt()
        {
             if (pageHeader.Displayed)
             {
                 return true;
             }
         

            return false;
        }

        public void OpenWeAreAbt()
        {
            _weAreAbt.Click();
        }

        public void Go()
        {
            SeleniumDriver.Instance.Navigate().GoToUrl("https://abtassoc.sharepoint.com/aboutabt/Pages/Home.aspx");
        }

        public void OpenElevatorSpeech()
        {
            _elevatorSpeech.Click();
        }

        public void OpenMGA()
        {
            _mga.Click();
        }

        public void OpenOfficeLocations()
        {
            _officeLocations.Click();
        }

        public void OpenBethesda()
        {
            _bethesda.Click();
        }

        public void OpenCambridge()
        {
            _cambridge.Click();
        }

        public void OpenCambridgeCafe()
        {
            _cambridgeCafe.Click();
        }

        public string OpenFile(aboutAbtFiles file)
        {
            switch (file)
            {
                case aboutAbtFiles.CompanyChart:
                   // SeleniumDriver.DriverInstance.SwitchTo().Frame("FilterIframe7");
                    OpenFileMenu();
                   return OpenPPtReadingMode();
                   
                case aboutAbtFiles.AbtAnualReview2016:
                   return OpenAbtAnualReview("2016");
                    
                case aboutAbtFiles.AbtAnualReview2015:
                 return  OpenAbtAnualReview("2015");
                    
                case aboutAbtFiles.AbtAnualReview2014:
                 return    OpenAbtAnualReview("2014");
                    
                case aboutAbtFiles.AbtAnualReview2013:
                 return   OpenAbtAnualReview("2013");
                    
                case aboutAbtFiles.AbtAnualReview2012:
                 return    OpenAbtAnualReview("2012");
                  
                default:
                    return "";
            }
        }

        private string OpenAbtAnualReview(string year)
        {
            finder = new PopupWindowFinder(SeleniumDriver.Instance);
            string winHandle=finder.Click(SeleniumDriver.Instance.FindElement(By.LinkText("Abt Annual Review " + year)));
            return winHandle;
        }

        private string OpenPPtReadingMode()
        {
            finder = new PopupWindowFinder(SeleniumDriver.Instance);
            string winHandle = finder.Click(_viewPresentation);
            return winHandle;
        }

        private void OpenFileMenu()
        {
            foreach(var el in _linksMenuWrapper)
            {
                Console.WriteLine(el.GetAttribute("title"));
            }
           // FileMenu.Click();
        }

        public void OpenCambridgeSoftball()
        {
            _cambridgeSoftball.Click();
        }

        public void OpenCambridgeShuttle()
        {
            _cambridgeShuttle.Click();
        }

        public void OpenDurham()
        {
            _durham.Click();
        }

        public void OpenHistory()
        {
            _history.Click();
        }
    }
}