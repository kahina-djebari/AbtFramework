using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace AbtFramework
{
   public class Driver
    {
        internal static IWebDriver seleniumdriver;

        public static void init()
        {
            DesiredCapabilities d = DesiredCapabilities.InternetExplorer();
            d.SetCapability("nativeEvents", false);
            

           // InternetExplorerOptions options = new InternetExplorerOptions();
           // options.AddAdditionalCapability("nativeEvents", false);
           seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits");
          //  seleniumdriver= new InternetExplorerDriver()
          //  seleniumdriver = new ChromeDriver(@"C:\Selenium\ChromeDriver");
            seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            seleniumdriver.Manage().Window.Maximize();
        }

        public static void Close()
        {
            seleniumdriver.Close();
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