using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Utils_Classes
{
    public class DriverExtentions
    {


        public static Func<IWebDriver, bool> WaitforWindowsTobe2 = new Func<IWebDriver, bool>((IWebDriver Web) =>
          {

              if (Web.WindowHandles.Count >= 2)
              {
                  return true;
              }
              return false;
          });


        public static Func<IWebDriver, IWebElement> WaitforQuicklinks = new Func<IWebDriver, IWebElement>((IWebDriver Web) =>
        {

            Web.FindElement(By.Id("quicklinks")).Click();
            Console.WriteLine("clicked on quicklinks!");
            IWebElement oracleLink = Web.FindElement(By.LinkText("Oracle"));


            return oracleLink;
        });

   
    }

  
}
        


