using System;

namespace AbtFramework
{
    public class StaffDirectoryPage : PageModel
    {
        public bool isAt()
        {
            wait.Until(e=>SeleniumDriver.Instance.Title.Equals("Search People"));

            return true;
        }
    }
}