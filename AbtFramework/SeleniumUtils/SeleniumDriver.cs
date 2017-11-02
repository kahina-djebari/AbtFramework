using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
using System.Threading;
using AbtFramework.Utils_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace AbtFramework.SeleniumUtils
{
    public class SeleniumDriver
    {

        static InternetExplorerOptions IEoptions;
        public static IWebDriver DriverInstance;
        private static IWebDriver Instance2;
        public static IWebDriver driver1;
        public static IWebDriver driver2;
        public static IWebDriver driver3;
        public static IWebDriver driver4;
        public static IWebDriver driver5;
        public static IWebDriver driver6;
        public static IWebDriver driver7;
        public static IWebDriver driver8;
        public static IWebDriver driver9;
        public static IWebDriver driver10;
        private static IJavaScriptExecutor js;
        public static WebDriverWait customWait;
        private static WebDriverWait wait;
        public static EventFiringWebDriver FiringDriver2;

        private SeleniumDriver()
        {
           // use static methods
        }

        public static void init(Browser browser)
        {
            switch (browser)
            {
                case Browser.IECleanSessionIgnoreProtectedMode:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;
                    IEoptions.EnsureCleanSession = true;
                    IEoptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits", IEoptions);

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.RemoteQALaptop:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;
                    IEoptions.EnableNativeEvents = false;
                    //  string localIp = MyUtils.GetLocalIpAddress();

                    DriverInstance = new RemoteWebDriver(new Uri("http://" + MyUtils.GetLocalIpAddress() + ":4444/wd/hub"), IEoptions.ToCapabilities());

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();

                    break;
                case Browser.RemoteSofianesIECleanSession:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;
                    // IEoptions.EnsureCleanSession = true;
                    IEoptions.EnableNativeEvents = false;

                    DriverInstance = new RemoteWebDriver(new Uri("http://10.220.68.64:4444/wd/hub"), IEoptions.ToCapabilities());

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;

                case Browser.IECleanSessionNoNativeEvents:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;
                    IEoptions.EnsureCleanSession = true;
                    IEoptions.EnableNativeEvents = false;

                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits", IEoptions);

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
                    DriverInstance.Manage().Window.Maximize();
                    break;

                case Browser.IECleanSession:

                    IEoptions = new InternetExplorerOptions();
                    // IEoptions.EnablePersistentHover = false;
                    // IEoptions.EnableNativeEvents = false;
                    // IEoptions.EnsureCleanSession = true;
                    IEoptions.RequireWindowFocus = true;
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits", IEoptions);

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(35));
                    DriverInstance.Manage().Window.Maximize();
                    break;


                case Browser.ServerRemote:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;
                    IEoptions.EnableNativeEvents = false;


                    DriverInstance = new RemoteWebDriver(new Uri("http://172.18.58.20:4444/wd/hub"), IEoptions.ToCapabilities());

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();

                    break;
                case Browser.RemoteDavidIEDriver2:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;


                    Instance2 = new RemoteWebDriver(new Uri("http://172.18.58.26:4444/wd/hub"), IEoptions.ToCapabilities());
                    FiringDriver2 = new EventFiringWebDriver(Instance2);
                    FiringDriver2.ExceptionThrown += TakeScreenShotOnException;
                    Instance2 = FiringDriver2;
                    FiringDriver2.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    FiringDriver2.Manage().Window.Maximize();
                    break;
                case Browser.IE:

                    IEoptions = new InternetExplorerOptions();
                    // IEoptions.EnablePersistentHover = true;
                    // IEoptions.EnsureCleanSession = true;
                    // IEoptions.IgnoreZoomLevel = true;
                    IEoptions.RequireWindowFocus = true;
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits", IEoptions);

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;

                case Browser.RemoteDavidIENoNativeEvents:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;
                    IEoptions.EnableNativeEvents = false;

                    DriverInstance = new RemoteWebDriver(new Uri("http://" + MyUtils.GetLocalIpAddress() + ":4444/wd/hub"), IEoptions.ToCapabilities());

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;

                case Browser.RemoteDavidIE:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;


                    DriverInstance = new RemoteWebDriver(new Uri("http://" + MyUtils.GetLocalIpAddress() + ":4444/wd/hub"), IEoptions.ToCapabilities());

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;

                case Browser.RemoteSofianesIE:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;


                    DriverInstance = new RemoteWebDriver(new Uri("http://10.220.68.64:4444/wd/hub"), IEoptions.ToCapabilities());

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();

                    break;

                case Browser.RemoteSofianesIENoNativeEvents:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.IgnoreZoomLevel = true;
                    IEoptions.EnableNativeEvents = false;
                    DriverInstance = new RemoteWebDriver(new Uri("http://10.220.68.64:4444/wd/hub"), IEoptions.ToCapabilities()

                       );

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();

                    break;

                case Browser.RemoteFrometaIE:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.IgnoreZoomLevel = true;
                    IEoptions.EnableNativeEvents = false;
                    DriverInstance = new RemoteWebDriver(new Uri("http://172.18.58.24:4444/wd/hub"), IEoptions.ToCapabilities()

                       );

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;

                case Browser.IENoNativeEvents:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnableNativeEvents = false;
                    IEoptions.EnablePersistentHover = true;

                    //Clean Cache on Every Session ->  // IEoptions.EnsureCleanSession = true;

                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits", IEoptions);

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.Chrome:
                    DriverInstance = new ChromeDriver(@"C:\Selenium\ChromeDriver");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.IE246:
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.46\32bits");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.IE247:
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.47\32bits");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.IE248:
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.48\32bits");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.IE249:

                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.49\32bits");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.IE250:
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.50\32bits");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.IE251:
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.51\32bits");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.IE252:

                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.52\32bits");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.IE24664:
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.46\64bits");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.IE24764:
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.47\64bits");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.IE24864:
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.48\64bits");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.IE24964:
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.49\64bits");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.IE25064:
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.50\64bits");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.IE25164:
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.51\64bits");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                case Browser.IE25264:
                    DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.52\64bits");

                    DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    DriverInstance.Manage().Window.Maximize();
                    break;
                default:
                    break;
            }

        }

        public static void init(object iECleanSessionIgnoreProtectedMode)
        {
            throw new NotImplementedException();
        }

        public static string GetAlertText()
        {
            WebDriverWait wait = new WebDriverWait(DriverInstance, TimeSpan.FromSeconds(5));
            var alert = wait.Until(ExpectedConditions.AlertIsPresent());

            return alert.Text;
        }

        public static void GoTo(string url)
        {
            SeleniumDriver.DriverInstance.Navigate().GoToUrl(url);
        }



        public static void CloseAll()
        {
            DriverInstance.Quit();

        }

        private static void TakeScreenShotOnException(object sender, WebDriverExceptionEventArgs e)
        {

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
            DriverInstance.TakeScreenshot().SaveAsFile("failedTest-" + timestamp + ".png", ImageFormat.Png);
        }

        public static void RemoteInitDavidsPc(Browser browser)
        {
            IEoptions = new InternetExplorerOptions();
            IEoptions.EnablePersistentHover = true;


            DriverInstance = new RemoteWebDriver(new Uri("http://172.18.58.26:4444/wd/hub"), IEoptions.ToCapabilities());

            DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            DriverInstance.Manage().Window.Maximize();
        }

        public static void RemoteInitFrometasPC(Browser browser)
        {
            IEoptions = new InternetExplorerOptions();
            IEoptions.EnablePersistentHover = true;


            DriverInstance = new RemoteWebDriver(new Uri("http://172.18.58.29:4444/wd/hub"), IEoptions.ToCapabilities());

            DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            DriverInstance.Manage().Window.Maximize();
        }

        public static void init()
        {
            DesiredCapabilities d = DesiredCapabilities.InternetExplorer();
            d.SetCapability("nativeEvents", false);


            DriverInstance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits");

            DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            DriverInstance.Manage().Window.Maximize();
        }

        public static void Close()
        {
            DriverInstance.Close();
        }

        internal static string GetcurrentWindowHandler(ReadOnlyCollection<string> windowsHandler)
        {
            foreach (var window in windowsHandler)
            {
                Console.WriteLine(window);
                if (window != DriverInstance.CurrentWindowHandle)
                {
                    return window;
                }
            }
            return null;
        }

        public static void RemoteInit()
        {
            IEoptions = new InternetExplorerOptions();
            IEoptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            // IEoptions.EnableNativeEvents = false;
            IEoptions.IgnoreZoomLevel = true;

            DriverInstance = new RemoteWebDriver(new Uri("http://10.220.68.64:4444/wd/hub"), IEoptions.ToCapabilities()

               );

            DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            DriverInstance.Manage().Window.Maximize();

        }

        public static void Quit()
        {
            DriverInstance.Quit();
        }

        public static void InitDriver1()
        {
            driver1 = new InternetExplorerDriver();
            driver1.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            driver1.Manage().Window.Maximize();
        }

        public static void InitDriver2()
        {
            driver2 = new InternetExplorerDriver();
            driver2.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            driver2.Manage().Window.Maximize();
        }


        ///<summary>
        ///Perform a click on the element and with javascript if needed.
        ///</summary>
        ///<param name="element">element to click</param>
        ///
        public static void ClickElement(IWebElement element)
        {
            Thread.Sleep(1);
        
            try
            {
                element.Click();
            }
            catch (StaleElementReferenceException e)
            {
                // Ignore
            }
            catch (Exception e)
            {
                js.ExecuteScript("arguments[0].click();", element);
            }
        }


        ///<summary>
        ///Set a value in an element. usually text fields, input tag if value is not
        ///correct it will re-try
        ///</summary>
        ///<param name="element"></param>
        ///<param name="value"></param>
        public static void SetValue(IWebElement element, string value)
        {
            Thread.Sleep(1); // require or it will go to fast :(

            try
            {
                element.Click();
            }
            catch (Exception e)
            {
                // Ignore ElementNotClickableException, not necessary for set a value
            }

            element.SendKeys(value);

            if (!GetValue(element).ToLower().Equals(value.ToLower()))
            {
                //GlobalUtils.customWait(1);
                element.SendKeys(Keys.Home);
                element.SendKeys(Keys.Home + Keys.Shift);
                element.SendKeys(Keys.Delete);


                // GlobalUtils.customWait(1);
                js.ExecuteScript("arguments[0].value = '" + value + "';", element);
                js.ExecuteScript("arguments[0].focus(); arguments[0].blur(); return true", element);
            }
        }


        ///<summary>
        ///Clear the value, works for input and textarea
        ///</summary>
        ///<param name="element"></param>
        public static void ClearValue(IWebElement element)
        {
            Thread.Sleep(1); // :( required
            try
            {
                element.Clear();
            }
            catch (Exception e)
            {
                // Ignore
            }
        }

        ///<summary>
        ///Return the value of the attribute VALUE in the element common for input
	    /// fields
        ///</summary>
        ///<param name="element"></param>
        ///<returns>return the text of the value property</returns>
        public static string GetValue(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        ///<summary>
        ///Return the value of an specified attribute name in the element
        /// </summary>
        /// <param name="element"></param>
        /// <param name="attributeName"></param>
        public static string GetAttributeValue(IWebElement element, string attributeName)
        {
            return element.GetAttribute(attributeName);
        }


        ///<summary>
        ///return the text of that element
        /// </summary>
        /// <param name="element"></param>
        public static string GetText(IWebElement element)
        {
            string text = element.Text;

            if (text.Equals(""))
                text = (string)js.ExecuteScript("return arguments[0].value", element);

            if (text.Equals(""))
                text = (string)js.ExecuteScript("return arguments[0].textContent", element);

            return text;
        }


        ///<summary>
        /// Return if the checkbox is checked
        /// </summary>
        /// <param name="element"></param>
        public bool IsChecked(IWebElement element)
        {

            return (Boolean)js.ExecuteScript("return arguments[0].checked", element);
        }

        ///<summary>
        ///Select an item in a drop down element by the value
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SelectDropDown(IWebElement element, string value)
        {

            new SelectElement(element).SelectByValue(value);
        }


        ///<summary>
        ///Select an item in a drop down element by the index
        /// </summary>
        /// <param name="value"></param>
        /// <param name="element"></param>
        public static void SelectDropDown(IWebElement element, int value)
        {
            new SelectElement(element).SelectByIndex(value);
        }


        ///<summary>
        ///Select an item in a drop down element by the text visible
        /// </summary>
        /// <param name="element"></param>
        /// <param name="text"></param>
        public static void SelectDropDownByText(IWebElement element, string text)
        {
            new SelectElement(element).SelectByText(text);
        }



        ///<summary>
        ///Scroll the current windows to a certain element
        /// </summary>
        /// <param name="element"></param>
        public static void ScrollToElement(IWebElement element)
        {
            Thread.Sleep(3);
            try
            {
                js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
                // WaitVisibilityOf(element);
            }
            catch (Exception e)
            {
                // logger.error("---> Could not scroll to the element");
            }
        }



        ///<summary>
        ///Wait
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="time"></param>
        public static WebDriverWait CustomWait(IWebDriver driver, int time)
        {
            customWait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            return customWait;
        }


        ///<summary>
        ///wait for the HTML DOM to be ready, all elements loaded
        ///note: Does not guarantee the full page has loaded, sometimes DOM can
        /// return complete, but some elements are still loading dynamically
        /// </summary>
        public static void WaitForDOMready()
        {

            try
            {
                wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

            }
            catch (Exception)
            {

                Assert.Fail("Timeout waiting for Page Load Request to complete.");
            }

        }

        /// <summary>
        /// Wait for 60 sec for the visibility of the element, alternative to wait for page load
        /// </summary>
        /// <param name="element"></param>
        public void WaitVisibilityOf(IWebElement element)
        {
            WaitVisibilityOf(element, 60);
        }

        /// <summary>
        /// Waits for an element to be clickckable therefore visible
        /// </summary>
        /// <param name="element"></param>
        /// <param name="time"></param>
        public void WaitVisibilityOf(IWebElement element, int time)
        {
         //   WebDriverWait waiting = new WebDriverWait(driver, time);

            try
            {
             
              //  waiting.Until(ExpectedConditions.ElementToBeClickable(element));
            }
            catch (StaleElementReferenceException e)
            {
                // Ignore
            }
            catch (Exception ex)
            {
                // Ignore
            }

        }


        public void WaitVisibilityOfAllElements(List<IWebElement> elements)
        {
            WaitVisibilityOfAllElements(elements, 60);
        }

        /// <summary>
        /// Waits for visibility of all element in a list
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="time"></param>
        public void WaitVisibilityOfAllElements(List<IWebElement> elements, int time)
        {
          //  WebDriverWait waiting = new WebDriverWait(driver, time);

            try
            {
        
           //     waiting.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(elements));
            }
            catch (StaleElementReferenceException e)
            {
                // Ignore
            }
            catch (Exception ex)
            {
                // Ignore
            }

        }

        /// <summary>
        /// Waits until an elements if not visible
        /// </summary>
        /// <param name="xpath"></param>
        /// <param name="time"></param>
        public void WaitInvisibilityOf(string xpath, int time)
        {
          //  WebDriverWait waiting = new WebDriverWait(driver, time);
          //  waiting.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(xpath)));
        }


        /// <summary>
        /// Switch to a frame
        /// </summary>
        /// <param name="frameName"></param>
        public void SwitchToFrame(string frameName)
        {
           // GlobalUtils.customWait(5);
           //try
           // {
           //     driver.switchTo().frame(frameName);
           // }
           // catch (Exception e2)
           // {
           //     driver.switchTo().frame(driver.findElement(By.id(frameName)));
           // }

        }




    }

}