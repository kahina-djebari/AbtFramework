using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiDepartments : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Departments")]
        private IWebElement DepartmentsLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Departments"));
            if (DepartmentsLink.Displayed)
            {
                Console.WriteLine("Departments Link Opened Succcesfully");
                return true;
            }

            return false;

        }
    }
}