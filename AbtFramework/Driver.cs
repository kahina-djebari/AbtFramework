using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using AbtFramework.Utils_Classes;

namespace AbtFramework
{
   public class Driver
    {
        internal static IWebDriver seleniumdriver;
        static InternetExplorerOptions IEoptions;

        public static void init(Browser browser)
        {
            switch (browser)
            {
                case Browser.IE:
                    
                     IEoptions = new InternetExplorerOptions();
                     IEoptions.EnablePersistentHover = true;

                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits", IEoptions);
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    seleniumdriver.Manage().Window.Maximize();
                    break;

                case Browser.IENoNativeEvents:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnableNativeEvents = false;
                    IEoptions.EnablePersistentHover = true;
              //Clean Cache on Every Session ->  // IEoptions.EnsureCleanSession = true;

                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits", IEoptions);
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.Chrome:
                    seleniumdriver = new ChromeDriver(@"C:\Selenium\ChromeDriver");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.IE246:
                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.46\32bits");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.IE247:
                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.47\32bits");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.IE248:
                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.48\32bits");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.IE249:
                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.49\32bits");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.IE250:
                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.50\32bits");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.IE251:
                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.51\32bits");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.IE252:
                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.52\32bits");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.IE24664:
                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.46\64bits");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.IE24764:
                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.47\64bits");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.IE24864:
                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.48\64bits");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.IE24964:
                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.49\64bits");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.IE25064:
                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.50\64bits");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.IE25164:
                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.51\64bits");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                case Browser.IE25264:
                    seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.52\64bits");
                    seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    seleniumdriver.Manage().Window.Maximize();
                    break;
                default:
                    break;
            }
         
        }

        public static void RemoteInitDavidsPc(Browser browser)
        {
            IEoptions = new InternetExplorerOptions();
            IEoptions.EnablePersistentHover = true;


            seleniumdriver = new RemoteWebDriver(new Uri("http://172.18.58.24:4444/wd/hub"), IEoptions.ToCapabilities());
            seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            seleniumdriver.Manage().Window.Maximize();
        }

        public static void RemoteInitFrometasPC(Browser browser)
        {
            IEoptions = new InternetExplorerOptions();
            IEoptions.EnablePersistentHover = true;

        
            seleniumdriver = new RemoteWebDriver(new Uri("http://172.18.58.29:4444/wd/hub"), IEoptions.ToCapabilities());
            seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            seleniumdriver.Manage().Window.Maximize();
        }
     
        public static void init()
        {
            DesiredCapabilities d = DesiredCapabilities.InternetExplorer();
            d.SetCapability("nativeEvents", false);
            

          seleniumdriver = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits");

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

        public static void RemoteInit()
        {
            IEoptions = new InternetExplorerOptions();
            IEoptions.IntroduceInstabilityByIgnoringProtectedModeSettings=true;

            seleniumdriver = new RemoteWebDriver(new Uri("http://10.220.68.64:4444/wd/hub"),IEoptions.ToCapabilities()

               );
            seleniumdriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
           


        }

        public static void Quit()
        {
            seleniumdriver.Quit();
        }
    }
}