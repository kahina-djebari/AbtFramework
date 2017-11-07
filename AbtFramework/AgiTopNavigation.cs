﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AbtFramework.Utils_Classes.SeleniumUtils;

namespace AbtFramework
{
    public class AgiTopNavigation : PageModel
    {

        [FindsBy(How=How.CssSelector,Using = "#menuContainer > li:nth-child(1) > div > a")]
        public IWebElement HomeLink;

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
        private HomeDropdown _homedropdown;
        private NewsDropdown _newsdropdown;
        [FindsBy(How=How.LinkText,Using = "Tools & Resources")]
        private IWebElement ToolsAndResourscesLink;

        public ToolsDropdown ToolsDropdown { get {
                _toolsDropdown = PageGenerator.GetPage<ToolsDropdown>();
                _toolsDropdown.wait = new WebDriverWait(SeleniumDriver.DriverInstance, TimeSpan.FromSeconds(30));
                _toolsDropdown.action = new Actions(SeleniumDriver.DriverInstance);
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

        public HomeDropdown HomeDropdown {
            get
            {
                _homedropdown= PageGenerator.GetPage<HomeDropdown>();
                _homedropdown.wait = new WebDriverWait(SeleniumDriver.DriverInstance, TimeSpan.FromSeconds(30));
                _homedropdown.action = new Actions(SeleniumDriver.DriverInstance);
                return _homedropdown;
            }
        }

        public NewsDropdown NewsDropdown {
            get
            {
                _newsdropdown = PageGenerator.GetPage<NewsDropdown>();
                _newsdropdown.wait = new WebDriverWait(SeleniumDriver.DriverInstance, TimeSpan.FromSeconds(30));
                _newsdropdown.action = new Actions(SeleniumDriver.DriverInstance);
                return _newsdropdown;
            }
        }



        public void HoverOverTools()
        {

            action.MoveToElement(ToolsAndResourscesLink).Perform();
            Thread.Sleep(1000);


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

        public void HoverOverHome()
        {
            action.MoveToElement(HomeLink).Perform();
        }

        public void ToolsAndResources()
        {
            ToolsLink.Click();
        }

        public void GoToProjects()
        {
            Goto(homelinks.Projects);
        }

        public void GoTo_News()
        {
           Goto(homelinks.News);
        }

        public void GoHome()
        {
            Console.WriteLine("Clicking on AGI Top Navigation -> Home");
            HomeLink.Click();
        }

        public void Home()
        {
            HomeLink.Click();
        }

 

        public void Goto(homelinks link)
        {

            switch (link)
            {

                case homelinks.Proposals:
                    OpenLink("Proposals");
                    break;
                case homelinks.News:
                    OpenLink("News");
                    break;
                case homelinks.Home:
                    OpenLink("Home");
                    break;
                case homelinks.Projects:
                    OpenLink("Projects");
                    break;
            }
        }

        private void OpenLink(string linkText)
        {
            while (SeleniumDriver.DriverInstance.Title.Equals("Home"))
            {
                try
                {

                    SeleniumDriver.DriverInstance.FindElement(By.LinkText(linkText)).Click();
                    Thread.Sleep(1000);
                }

                catch
                {

                }

            }

            Console.WriteLine("Clicking on AGI Top Navigation ->" + linkText);
            Console.WriteLine("</br>");
        }

        public void AbtValues()
        {
            finder = new PopupWindowFinder(SeleniumDriver.DriverInstance);
            finder.Click(abtvalueLink);
        }

        public void GoToProporsals()
        {
            Goto(homelinks.Proposals);
        }
    }
}