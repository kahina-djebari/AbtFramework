using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework
{
    public class OraclePage : PageModel
    {
        [FindsBy(How=How.Id,Using ="PageLayoutRN")]
        private IWebElement headerInfo;


        public bool isAt()
        {
            Console.WriteLine("Oracle Web Page Loaded in: " + LoadTime);
            IWebElement header = getHeader();
                
            if (GetCurrentUser()!="Sofiane"){

                return true;
            }

            return false;
        }

        private string GetCurrentUser()
        {

            return headerInfo.FindElements(By.TagName("span")).Single(e=>e.Text.Equals("OUMSSALEMS")).Text;
        }

        private IWebElement getHeader()
        {
           return  headerInfo.FindElements(By.TagName("h1")).Single(e => e.Text.Equals("Oracle Applications Home Page"));
        }
    }
}