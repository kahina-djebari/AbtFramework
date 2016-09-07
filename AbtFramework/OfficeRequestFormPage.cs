using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AbtFramework
{
    public class OfficeRequestFormPage : PageModel
    {
        [FindsBy(How=How.Id,Using = "sys_display.IO:fd0ce7af0a0a0bd80032bad08a791851")]
        private IWebElement Location;
        [FindsBy(How = How.Id, Using = "IO:9a388eb79837c100b178ac1604f8f591")]
        private IWebElement Category;
        [FindsBy(How = How.Id, Using = "IO:923e46bc6f441100f8482fa0be3ee418")]
        private IWebElement Subcategory;
        [FindsBy(How = How.Id, Using = "IO:63ec85fb98f3c100b178ac1604f8f56b")]
        private IWebElement Shortdescription;
        [FindsBy(How = How.Id, Using = "IO:3823341e0a0a0b27003118193596953f")]
        private IWebElement Comments;
        [FindsBy(How = How.Id, Using = "submit_button")]
        private IWebElement Submitbtn;
        [FindsBy(How=How.Id,Using = "lookup.IO:fd26201e0a0a0bd800a12b67ffe70eab")]
        private  IWebElement LookUpLocation;
        [FindsBy(How=How.Id,Using = "b5e4c4622b6d6200fccbf62219da154d_text")]
        private IWebElement SearchBar;

        internal bool NewOfficeRequest(string location, string category, string subcategory, string shortdescription, string comments)
        {
           
            Location.Click();
            Location.SendKeys(location);
           Category.SelectOption(category).Click();
 
           Thread.Sleep(1000);
           Subcategory.SelectOption(subcategory).Click();
           Shortdescription.SendKeys(shortdescription);
           Comments.SendKeys(comments);
            Submitbtn.Click();
            return true;

        }
    }
}