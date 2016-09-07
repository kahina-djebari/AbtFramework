﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace AbtFramework
{
    public class MyOpenIncidentsPage : PageModel
    {
      

        public bool IncidentExists(string IncidentDescription)
        {
            Driver.seleniumdriver.SwitchTo().Frame("gsft_main");

            if (AbtDriver.IncidentTablePageObject.FirstIncidentDescription.Equals(IncidentDescription))
            {
                return true;
            }
            

            return false;
        }

       
    }
}