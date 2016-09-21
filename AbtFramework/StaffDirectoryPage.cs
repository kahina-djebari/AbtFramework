using System;

namespace AbtFramework
{
    public class StaffDirectoryPage : PageModel
    {
        public bool isAt()
        {
            wait.Until(e=>SeleniumDriver.FiringDriver.Title.Equals("Search People"));

            return true;
        }
    }
}