using OpenQA.Selenium;
using System;
using AbtFramework.SeleniumUtils;

namespace AbtFramework
{
    public class ServiceNowIRRTable : PageModel
    {
        public bool IRRExists(string IncidentReportId)
        {
            try
            {
                
                IWebElement IRR = SeleniumDriver.DriverInstance.FindElement(By.LinkText(IncidentReportId));
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