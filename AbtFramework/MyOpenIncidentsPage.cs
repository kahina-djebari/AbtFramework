using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using AbtFramework.Utils_Classes.SeleniumUtils;

namespace AbtFramework
{
    public class MyOpenIncidentsPage : PageModel
    {
      

        public bool IncidentExists(string IncidentDescription)
        {
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Until(e => AbtPages.TablePageObject.FirstRowItem.Enabled);
            if (AbtPages.TablePageObject.FirstIncidentDescription.Equals(IncidentDescription))
            {
                return true;
            }
            

            return false;
        }

       
    }
}