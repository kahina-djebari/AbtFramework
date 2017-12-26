﻿using OpenQA.Selenium;
using System;
using System.Threading;
using AbtFramework.Utils_Classes.SeleniumUtils;

namespace AbtFramework
{
    public class ExcelOnlinePage : PageModel
    {
        public void Edit()
        {
            SeleniumDriver.Instance.SwitchTo().Frame("WebApplicationFrame");
            Thread.Sleep(3000);
            action.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowLeft).SendKeys(Keys.ArrowLeft)
                                           .SendKeys(Keys.ArrowLeft)
                                           .SendKeys("Added this line at: " + DateTime.Now).Perform();
            Console.WriteLine("Edited Excel Document Succesfully");
            Thread.Sleep(5000);

        }
    }
}