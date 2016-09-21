using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

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
            finder = new PopupWindowFinder(SeleniumDriver.FiringDriver);
            popupWindowHandle = finder.Click(concurLink);
            StartTimer();
            SeleniumDriver.Close();
            SeleniumDriver.FiringDriver.SwitchTo().Window(popupWindowHandle);
            SeleniumDriver.FiringDriver.Manage().Window.Maximize();
            wait.Until(e => warning.Displayed);
            warning.Click();

        }
    }
}