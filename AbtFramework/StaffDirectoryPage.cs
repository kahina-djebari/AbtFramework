using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class StaffDirectoryPage : PageModel
    {
        [FindsBy(How=How.Id,Using = "ctl00_ctl48_g_8d631d64_a4f6_4687_ae5c_f4ea393a88a1_csr_sbox")]
        private IWebElement SearchBar;

       
        public bool isAt()
        {
            wait.Until(e=>SearchBar.Displayed);

            return true;
        }
    }
}
