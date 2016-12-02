using OpenQA.Selenium;
using System;

namespace AbtFramework
{
    public class ServiceNowIRRTable : PageModel
    {
        public bool NewIRRExists()
        {
            try
            {
                Console.WriteLine(MyIRRSubmition.GetNumber());
                IWebElement IRR = SeleniumDriver.Instance.FindElement(By.LinkText(MyIRRSubmition.GetNumber()));
                IRR.Click();
                return true;   
              
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        
        }
    }
}