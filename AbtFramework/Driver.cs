using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace AbtFramework
{
   public class Driver
    {
        internal static IWebDriver seleniumdriver;

        public static void init()
        {
            seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits");
           // seleniumdriver = new ChromeDriver(@"C:\Selenium\ChromeDriver");
            seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            seleniumdriver.Manage().Window.Maximize();
        }

    

        internal static string GetcurrentWindowHandler(ReadOnlyCollection<string> windowsHandler)
        {
           foreach(var window in windowsHandler)
            {
                Console.WriteLine(window);
                if (window != seleniumdriver.CurrentWindowHandle)
                {
                    return window;
                }
            }
            return null;
        }
    }
}