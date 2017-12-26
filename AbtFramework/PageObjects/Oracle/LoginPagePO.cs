using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.PageObjects.Oracle
{
    public class LoginPagePO
    {
       
        public IWebElement GetUserNameInput()
        {
            string xpath = "//input[contains(@title,'User Name')]";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetPasswordInput()
        {
            string xpath = "//input[contains(@title,'Password')]";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetLoginBtn()
        {
            string xpath = "//button[contains(@title,'Login')]";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

    }
}
