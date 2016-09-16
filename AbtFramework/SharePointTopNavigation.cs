using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class SharePointTopNavigation : PageModel
    {
        [FindsBy(How=How.CssSelector,Using = "#O365_TopMenu > div > div > div:nth-child(1) > div:nth-child(14) > button > div.o365cs-me-tileview-container > div > div:nth-child(3) > div > img")]
        private IWebElement ImgProfile;

        public void ClickOnImgProfile()
        {
            ImgProfile.Click();
        }

        internal string GetCurrentUser()
        {
           return ImgProfile.GetAttribute("title");
        }
    }
}