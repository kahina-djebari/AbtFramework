using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.Extensions;
using System.Drawing.Imaging;

namespace AbtFramework
{
   public class SeleniumDriver
    {
        public static EventFiringWebDriver FiringDriver;
        static InternetExplorerOptions IEoptions;
        private static IWebDriver Instance;

        public static void init(Browser browser)
        {
            switch (browser)
            {
                case Browser.IE:
                    
                     IEoptions = new InternetExplorerOptions();
                     IEoptions.EnablePersistentHover = true;
                    
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits", IEoptions);
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;

                case Browser.RemoteDavidIENoNativeEvents:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;
                    IEoptions.EnableNativeEvents = false;

                    Instance = new RemoteWebDriver(new Uri("http://172.18.58.20:4444/wd/hub"), IEoptions.ToCapabilities());
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance= FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;

                case Browser.RemoteDavidIE:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;


                    Instance = new RemoteWebDriver(new Uri("http://172.18.58.20:4444/wd/hub"), IEoptions.ToCapabilities());
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;

                case Browser.RemoteSofianesIE:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    IEoptions.EnablePersistentHover = true;


                    Instance = new RemoteWebDriver(new Uri("http://10.220.68.64:4444/wd/hub"), IEoptions.ToCapabilities());
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();

                    break;

                case Browser.RemoteSofianesIENoNativeEvents:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    IEoptions.IgnoreZoomLevel = true;
                    IEoptions.EnableNativeEvents = false;
                    Instance = new RemoteWebDriver(new Uri("http://10.220.68.64:4444/wd/hub"), IEoptions.ToCapabilities()

                       );
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();

                    break;

                case Browser.RemoteFrometaIE:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    IEoptions.IgnoreZoomLevel = true;
                    IEoptions.EnableNativeEvents = false;
                    Instance = new RemoteWebDriver(new Uri("http://172.18.58.24:4444/wd/hub"), IEoptions.ToCapabilities()

                       );
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;

                case Browser.IENoNativeEvents:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnableNativeEvents = false;
                  //  IEoptions.EnablePersistentHover = true;
              //Clean Cache on Every Session ->  // IEoptions.EnsureCleanSession = true;

                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits", IEoptions);
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.Chrome:
                    Instance = new ChromeDriver(@"C:\Selenium\ChromeDriver");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.IE246:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.46\32bits");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.IE247:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.47\32bits");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.IE248:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.48\32bits");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.IE249:

                    Instance= new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.49\32bits");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.IE250:
                   Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.50\32bits");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.IE251:
                   Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.51\32bits");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.IE252:

                    Instance= new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.52\32bits");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.IE24664:
                   Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.46\64bits");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.IE24764:
                  Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.47\64bits");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.IE24864:
                   Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.48\64bits");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.IE24964:
                    Instance= new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.49\64bits");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.IE25064:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.50\64bits");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.IE25164:
                   Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.51\64bits");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                case Browser.IE25264:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.52\64bits");
                    FiringDriver = new EventFiringWebDriver(Instance);
                    FiringDriver.ExceptionThrown += TakeScreenShotOnException;
                    Instance = FiringDriver;
                    FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver.Manage().Window.Maximize();
                    break;
                default:
                    break;
            }
         
        }

        public static void CloseAll()
        {
           

                FiringDriver.Quit();
            
        }

        private static void TakeScreenShotOnException(object sender, WebDriverExceptionEventArgs e)
        {

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
            FiringDriver.TakeScreenshot().SaveAsFile("failedTest-" + timestamp + ".png", ImageFormat.Png);
        }

        public static void RemoteInitDavidsPc(Browser browser)
        {
            IEoptions = new InternetExplorerOptions();
            IEoptions.EnablePersistentHover = true;


            Instance = new RemoteWebDriver(new Uri("http://172.18.58.24:4444/wd/hub"), IEoptions.ToCapabilities());
            FiringDriver = new EventFiringWebDriver(Instance);
            FiringDriver.ExceptionThrown += TakeScreenShotOnException;
            Instance = FiringDriver;
            FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            FiringDriver.Manage().Window.Maximize();
        }

        public static void RemoteInitFrometasPC(Browser browser)
        {
            IEoptions = new InternetExplorerOptions();
            IEoptions.EnablePersistentHover = true;

        
           Instance = new RemoteWebDriver(new Uri("http://172.18.58.29:4444/wd/hub"), IEoptions.ToCapabilities());
            FiringDriver = new EventFiringWebDriver(Instance);
            FiringDriver.ExceptionThrown += TakeScreenShotOnException;
            Instance = FiringDriver;
            FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            FiringDriver.Manage().Window.Maximize();
        }
     
        public static void init()
        {
            DesiredCapabilities d = DesiredCapabilities.InternetExplorer();
            d.SetCapability("nativeEvents", false);
            

          Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits");
            FiringDriver = new EventFiringWebDriver(Instance);
            FiringDriver.ExceptionThrown += TakeScreenShotOnException;
            Instance = FiringDriver;
            FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            FiringDriver.Manage().Window.Maximize();
        }

        public static void Close()
        {
            FiringDriver.Close();
        }

        internal static string GetcurrentWindowHandler(ReadOnlyCollection<string> windowsHandler)
        {
           foreach(var window in windowsHandler)
            {
                Console.WriteLine(window);
                if (window != FiringDriver.CurrentWindowHandle)
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
           // IEoptions.EnableNativeEvents = false;
            IEoptions.IgnoreZoomLevel = true;

            Instance = new RemoteWebDriver(new Uri("http://10.220.68.64:4444/wd/hub"),IEoptions.ToCapabilities()

               );
            FiringDriver = new EventFiringWebDriver(Instance);
            FiringDriver.ExceptionThrown += TakeScreenShotOnException;
            Instance = FiringDriver;
            FiringDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            FiringDriver.Manage().Window.Maximize();

        }

        public static void Quit()
        {
            FiringDriver.Quit();
        }
    }
}