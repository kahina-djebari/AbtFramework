using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using AbtFramework.SeleniumUtils;

namespace AbtFramework
{
    public class AbtTravelOnlineDropdown : PageModel
    {
        [FindsBy(How = How.CssSelector, Using = "#dnn_dnnWTRADMENU_RadMenu1 > ul > li:nth-child(2) > div > ul > li:nth-child(2) > a")]
        private IWebElement concurLink;
        [FindsBy(How = How.Id, Using = "popupdialogBtn_0")]
        private IWebElement warning;

        public void BookOrSearchUsTravel()
        {
            // action.MoveToElement()
            finder = new PopupWindowFinder(SeleniumDriver.DriverInstance);
            Console.WriteLine("Clicking on Book or Search US Travel");
            Console.WriteLine("</br>");
            
            popupWindowHandle = finder.Click(concurLink);
            StartTimer();
            SeleniumDriver.Close();
            SeleniumDriver.DriverInstance.SwitchTo().Window(popupWindowHandle);
            SeleniumDriver.DriverInstance.Manage().Window.Maximize();
            wait.Until(e => warning.Displayed);
            warning.Click();
            StopTimer();
            PrintResponseTime("Concur");

        }
    }
}