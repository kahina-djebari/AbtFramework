using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Linq;
using System.Threading;

namespace AbtFramework
{
    public class HomeDropdown : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="About Abt")]
        private IWebElement _AboutAbt;

        public void OpenAboutAbt()
        {
            _AboutAbt.Click();
        }
    }
}