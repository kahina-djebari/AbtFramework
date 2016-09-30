using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiFormLibrary : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Form Management View")]
        private IWebElement FormManagementView;

        public bool IsAt()
        {

            wait.Until(e => e.Title.Equals("AbtForms - All Documents"));
            if (FormManagementView.Displayed)
            {
                Console.WriteLine("Form Library Link Opened Succesfully");
                return true;
            }

            return false;

        }
    }
}