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


        public bool isAt()
        {
            //Thread.Sleep(2000);
            try
            {

                AbtFramework.AutoIT.AutoITDriver.init();
                AbtFramework.AutoIT.AutoITDriver.AceptCertificate();

            }
            catch (NoAlertPresentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            wait.Until(e => e.Title.Equals("Oracle Applications Home Page"));
            StopTimer();
           // PrintResponseTime("Oracle");
       
            if (GetCurrentUser().Equals("OUMSALEMS"))
            {
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