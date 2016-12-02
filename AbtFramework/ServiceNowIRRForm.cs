using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class ServiceNowIRRForm : PageModel
    {
        [FindsBy(How=How.Id,Using = "sys_readonly.u_incident_response.number")]
        public IWebElement Number;


        public void FillWithDefaultValues()
        {
           
            MyIRRSubmition.SetNumber(Number.GetAttribute("value"));

           
        }
    }
}