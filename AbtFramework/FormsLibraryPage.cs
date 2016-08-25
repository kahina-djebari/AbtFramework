using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class FormsLibraryPage : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="AbtForms")]
        private IWebElement abtForms;

        public bool isAt()
        {
            wait.Until(e=>abtForms.Displayed);
            
            return true;
        }
    }
}