using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework
{
    public class AgiTopNavigation : PageModel
    {
        

        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement HomeLink;

        [FindsBy(How = How.LinkText, Using = "News")]
        private IWebElement NewsLink;

        [FindsBy(How = How.LinkText, Using = "Projects")]
        private IWebElement ProjectsLink;

        [FindsBy(How = How.LinkText, Using = "Proposals")]
        private IWebElement ProposalsLink;

        private List<IWebElement> LinkList;

        [FindsBy(How = How.ClassName, Using = "main")]
        private IList<IWebElement> Toplinks;

        private ToolsDropdown _toolsDropdown;
        [FindsBy(How =How.LinkText,Using ="Abt Values")]
        private IWebElement abtvalueLink;

        public ToolsDropdown ToolsDropdown { get {
                _toolsDropdown = PageGenerator.GetPage<ToolsDropdown>();
                _toolsDropdown.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _toolsDropdown.action = new Actions(SeleniumDriver.Instance);
                return _toolsDropdown;
            } }


        public IWebElement ToolsLink
        { get {  foreach(var link in Toplinks)
                {
                   
                    var el = link.FindElement(By.TagName("a"));
                    if (el.GetAttribute("href").Equals("http://abtassoc.sharepoint.com/ToolsResources"))
                    {
                        return el;
                    }
                     
                            
                }
          return null;       
       } }

        public void HoverOverTools()
        {
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("body")));
            ToolsLink.Click();



        }

        public bool isActive()
        {

            LinkList = new List<IWebElement>();
            LinkList.Add(HomeLink);
            LinkList.Add(NewsLink);
            LinkList.Add(ProjectsLink);
            LinkList.Add(ProposalsLink);
            LinkList.Add(ToolsLink);
            bool areActive = true;

            foreach(var el in LinkList)
            {
                if (!el.Displayed)
                {
                    Console.WriteLine("Link \"" + el.Text + "\" is not displayed or not working ");
                    Console.WriteLine("</br>");
                    areActive = false;

                }
                else
                {
                    Console.WriteLine("Link \"" + el.Text + "\" is Displaying correctly");
                    Console.WriteLine("</br>");
                }
            }

            return areActive;
        }

        public void ToolsAndResources()
        {
            ToolsLink.Click();
        }

        public void Projects()
        {
            ProjectsLink.Click();
        }

        public void News()
        {
            NewsLink.Click();
        }

        public void Home()
        {
            HomeLink.Click();
        }

 

        public void Goto(homelinks link)
        {

            switch (link)
            {
                case homelinks.Projects:
                    wait.Timeout = TimeSpan.FromSeconds(40);
                    wait.Until((Func<IWebDriver, bool>)(e =>
                    {
                        if (SeleniumDriver.Instance.Title !="Projects")
                        {
                            ProjectsLink.Click();
                        }

                        else
                        {
                     
                            return true;
                        }
                        return false;
                    }));
                
                    break;
            }
        }

        public void AbtValues()
        {
            finder = new PopupWindowFinder(SeleniumDriver.Instance);
            finder.Click(abtvalueLink);
        }
    }
}