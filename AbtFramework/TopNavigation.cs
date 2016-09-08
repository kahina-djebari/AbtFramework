using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace AbtFramework
{
    public class TopNavigation : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Tools & Resources")]
        private IWebElement ToolsAndResources;

        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement HomeLink;

        [FindsBy(How = How.LinkText, Using = "News")]
        private IWebElement NewsLink;

        [FindsBy(How = How.LinkText, Using = "Projects")]
        private IWebElement ProjectsLink;

        [FindsBy(How = How.LinkText, Using = "Proposals")]
        private IWebElement ProposalsLink;

        private List<IWebElement> LinkList;

        private ToolsDropdown _toolsDropdown;

        public ToolsDropdown ToolsDropdown { get {
                _toolsDropdown = PageGenerator.GetPage<ToolsDropdown>();
                _toolsDropdown.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(15));
                _toolsDropdown.action = new Actions(Driver.seleniumdriver);
                return _toolsDropdown;
            } }

       

        public void ToolsLink()
        {
            ToolsAndResources.Click();
                       
        }


        public void HoverOverTools()
        {
            wait.Until(e =>
            {

                if (Driver.seleniumdriver.WindowHandles.Count >= 2)
                {
                    return true;
                }

                else
                {
                    action.MoveToElement(ToolsAndResources).Perform();
                    action.Click(ToolsDropdown.AbtTravel);
                    return false;
                }



            });
            
            
        }

        public bool isActive()
        {

            LinkList = new List<IWebElement>();
            LinkList.Add(HomeLink);
            LinkList.Add(NewsLink);
            LinkList.Add(ProjectsLink);
            LinkList.Add(ProposalsLink);
            LinkList.Add(ToolsAndResources);
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

       

        public void Goto(homelinks link)
        {

            switch (link)
            {
                case homelinks.Projects:
                    wait.Timeout = TimeSpan.FromSeconds(40);
                    wait.Until(e =>
                    {
                        if (Driver.seleniumdriver.Title !="Projects")
                        {
                            ProjectsLink.Click();
                        }

                        else
                        {
                     
                            return true;
                        }
                        return false;
                    });
                
                    break;
            }
        }
    }
}