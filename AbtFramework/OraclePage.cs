using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AbtFramework
{
    public class OraclePage : PageModel
    {

        [FindsBy(How=How.Id,Using ="PageLayoutRN")]
        private IWebElement headerInfo;
        [FindsBy(How = How.CssSelector, Using = "#PageLayoutRN > div > div:nth-child(5) > div > div.x63 > table > tbody > tr > td > h1")]
        private IWebElement OracleWelcome;

        public bool isAt()
        {
            //Thread.Sleep(2000);
            SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.Instance.WindowHandles.Last());
            try
            {

                AbtFramework.AutoIT.AutoITDriver.init();
                AbtFramework.AutoIT.AutoITDriver.AceptCertificate();

            }
            catch (NoAlertPresentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            // PrintResponseTime("Oracle");

            if (wait.Until(e => OracleWelcome.Displayed))
            {
                StopTimer();
                return true;
            }

            else
            {
                return false;
            }
        }

        private string GetCurrentUser()
        {

            return headerInfo.FindElement(By.TagName("div")).FindElements(By.TagName("table"))[0].FindElements(By.TagName("span"))[1].Text;
        }

        private IWebElement getHeader()
        {
           return  headerInfo.FindElements(By.TagName("h1")).Single(e => e.Text.Equals("Oracle Applications Home Page"));
        }
    }
}