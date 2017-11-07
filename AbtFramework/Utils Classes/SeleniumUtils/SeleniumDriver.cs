using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace AbtFramework.Utils_Classes.SeleniumUtils
{
    /// <summary>
    /// SeleniumDriver class that initiates driver upon browser and contains all helper methods used.
    /// Class works as a singleton pattern, one instance of driver always.
    /// </summary>
    public class SeleniumDriver
    {
        //constants
        private static readonly string IE = "IE";
        private static readonly string CHROME = "Chrome";

        //unique instance of driver
        public static IWebDriver DriverInstance;

        //to handle javascript actions
        private static IJavaScriptExecutor js;

        //for customWaits 
        public static WebDriverWait customWait;
        private static WebDriverWait wait;

        //variables for path to Drivers
        private static string _pathToChrome;
        private static string _pathToIE;

        private SeleniumDriver()
        {
            // use static methods, no instance
        }

        /// <summary>
        /// Inits local browser driver with browser needed
        /// </summary>
        /// <param name="browser"></param>
        public static void InitBrowser(string browser)
        {
            if (IE.ToLower().Contains(browser.ToLower()))
            {
                SetUpIE();
            }
            else if (CHROME.ToLower().Contains(browser.ToLower()))
            {
                SetUpChrome();
            }


        }

        /// <summary>
        /// Init Chrome driver
        /// </summary>
        private static void SetUpChrome()
        {
            LoadJSONConfig();
            DriverInstance = new ChromeDriver(_pathToChrome);
            js =  (IJavaScriptExecutor)DriverInstance;
            DriverInstance.Manage().Window.Maximize();
            Console.WriteLine("-------->  Opening Chrome Driver");
        }

        /// <summary>
        /// Init IE driver
        /// </summary>
        private static void SetUpIE()
        {
            LoadJSONConfig();
            InternetExplorerOptions IEoptions = new InternetExplorerOptions();
            IEoptions.IgnoreZoomLevel = true;
            IEoptions.RequireWindowFocus = true;
            IEoptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            IEoptions.AddAdditionalCapability("acceptSslCerts", true);
            DriverInstance = new InternetExplorerDriver(_pathToIE, IEoptions);
            js = (IJavaScriptExecutor)DriverInstance;

            DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            DriverInstance.Manage().Window.Maximize();
        }


        public static string GetAlertText()
        {
            WebDriverWait wait = new WebDriverWait(DriverInstance, TimeSpan.FromSeconds(5));
            var alert = wait.Until(ExpectedConditions.AlertIsPresent());

            return alert.Text;
        }

        /// <summary>
        /// Goes to a URL
        /// </summary>
        /// <param name="url"></param>
        public static void GoTo(string url)
        {
            SeleniumDriver.DriverInstance.Navigate().GoToUrl(url);
        }


        /// <summary>
        /// Quits current driver instance 
        /// </summary>
        public static void QuitDriverInstance()
        {
            DriverInstance.Quit();
            DriverInstance = null;

        }

        private static void TakeScreenShotOnException(object sender, WebDriverExceptionEventArgs e)
        {

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
            DriverInstance.TakeScreenshot().SaveAsFile("failedTest-" + timestamp + ".png", ImageFormat.Png);
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


        //********************************************* PO ELEMENTS HELPER **********************************************************//

        /// <summary>
        /// Loads path to drivers from test_config.json 
        /// </summary>
        private static void LoadJSONConfig()
        {
            JObject obj = null;
            try
            {
                obj = JObject.Parse(File.ReadAllText(@"../AbtFramework/Utils Classes/Properties/test_config.json"));
            }
            catch (FileNotFoundException)
            {
                Assert.Fail("test_config.json file not found, please check Properties folder.");
            }

            Dictionary<string, object> dictObj = obj.ToObject<Dictionary<string, object>>();

            _pathToChrome = dictObj["pathToChromDriver"].ToString();
            _pathToIE = dictObj["pathToInternetExplorerDriver"].ToString();

            if (_pathToChrome == null || _pathToIE == null)
            {
                Assert.Fail("Path to Drivers are empty in test_config.json");

            }
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
            catch (Exception)
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
            WebDriverWait waiting = new WebDriverWait(DriverInstance, TimeSpan.FromSeconds(time));

            try
            {

                //  waiting.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(elements));
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
            WebDriverWait waiting = new WebDriverWait(DriverInstance, TimeSpan.FromSeconds(time));
            waiting.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(xpath)));
        }


        /// <summary>
        /// Switch to a frame
        /// </summary>
        /// <param name="frameName"></param>
        public void SwitchToFrame(string frameName)
        {
            Thread.Sleep(2);
            try
            {
                DriverInstance.SwitchTo().Frame(frameName);

            }
            catch (Exception e2)
            {
                DriverInstance.SwitchTo().Frame(DriverInstance.FindElement(By.Id(frameName)));
            }

        }




    }

}