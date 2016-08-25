using System;

namespace AbtFramework
{
    public class StaffDirectoryPage : PageModel
    {
        public bool isAt()
        {
            wait.Until(e=>Driver.seleniumdriver.Title.Equals("Search People"));

            return true;
        }
    }
}