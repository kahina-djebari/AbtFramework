using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Drawing;
using System.Drawing.Imaging;
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
    /// Class works as a singleton, one instance of driver always.
    /// </summary>
    public class SeleniumDriver
    {
        
        //constants for browser
        private static readonly string IE = "IE";
        private static readonly string CHROME = "Chrome";
        private static readonly string XPATH = "xpath";
        private static readonly string ID = "id";
        private static readonly string NAME = "name";
        private static readonly string LINK = "link";

        private static readonly int MAX = 3;

        //unique instance of driver
        public static IWebDriver DriverInstance;

        //to handle javascript actions
        private static IJavaScriptExecutor js;

        //wait object 
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
        /// Init Chrome driver with configuration
        /// </summary>
        private static void SetUpChrome()
        {
            LoadJSONConfig();
            ChromeOptions options = new ChromeOptions();
            //set some options
            options.AddArguments("--disable-popup-blocking"); //To disable automatic popup blocking 
            options.AddArguments("--disable-extensions");
            options.AddArguments("--ignore-certificate-errors");
           
            try
            {
                DriverInstance = new ChromeDriver(_pathToChrome, options);
            }
            catch (Exception e)
            {
                Assert.Fail("---> " + e.Message);
            }

            if (DriverInstance == null)
                Assert.Fail("--> None of the webDrivers are supported for this browser");


            js = (IJavaScriptExecutor)DriverInstance; //init js object
            wait = new WebDriverWait(DriverInstance, TimeSpan.FromSeconds(60)); //init wait object
            DriverInstance.Manage().Window.Maximize();
            Console.WriteLine("-------->  Opening Chrome Driver");
        }

        /// <summary>
        /// Init IE driver with configuration
        /// </summary>
        private static void SetUpIE()
        {
            LoadJSONConfig();
            InternetExplorerOptions IEoptions = new InternetExplorerOptions();
            //set options
            IEoptions.IgnoreZoomLevel = true;
            IEoptions.RequireWindowFocus = true;
            IEoptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true; 
            IEoptions.AddAdditionalCapability("acceptSslCerts", true);

            try
            {
                DriverInstance = new InternetExplorerDriver(_pathToIE, IEoptions);
            }
            catch (Exception e)
            {
                Assert.Fail("---> " + e.Message);
            }

            if (DriverInstance == null)
                Assert.Fail("--> None of the webDrivers are supported for this browser");

            js = (IJavaScriptExecutor)DriverInstance; //init js object
            wait = new WebDriverWait(DriverInstance, TimeSpan.FromSeconds(60)); //init wait object
            DriverInstance.Manage().Window.Maximize();
        }


        public static string GetAlertText()
        {
            WebDriverWait wait = new WebDriverWait(DriverInstance, TimeSpan.FromSeconds(5));
            var alert = wait.Until(ExpectedConditions.AlertIsPresent());

            return alert.Text;
        }

        /// <summary>
        /// Goes to an URL
        /// </summary>
        /// <param name="url"></param>
        public static void GoTo(string url)
        {
            SeleniumDriver.DriverInstance.Navigate().GoToUrl(url);
        }


        /// <summary>
        /// Quits current driver instance from memory
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


        /// <summary>
        /// Close current Tab in browser
        /// </summary>
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

        /// <summary>
        /// Loads variables with path to drivers from Properties/test_config.json 
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


        // - - - - - - - - - -  Basic Actions Basic actions - - - - - - - - - - - - - //
        // ===================================================================//



        ///<summary>
        ///Perform a click on the element and with JavaScript if needed.
        ///</summary>
        ///<param name="element">element to click</param>
        ///
        public static void ClickElement(IWebElement element)
        {
            Thread.Sleep(1);

            try
            {
                js.ExecuteScript("arguments[0].click();", element);
                // element.Click();//javaScript click is working better 
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
            catch (StaleElementReferenceException e)
            {
                // Ignore ElementNotClickableException, not necessary for set a value
            }

            element.SendKeys(value);

            if (!GetValue(element).ToLower().Equals(value.ToLower()))
            {
                Thread.Sleep(1);
                element.SendKeys(Keys.Home);
                element.SendKeys(Keys.Home + Keys.Shift);
                element.SendKeys(Keys.Delete);


                Thread.Sleep(1);
                js.ExecuteScript("arguments[0].value = '" + value + "';", element);
                js.ExecuteScript("arguments[0].focus(); arguments[0].blur(); return true", element);
            }
        }


        ///<summary>
        ///Clear the value, works for input and textArea
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
        public static bool IsChecked(IWebElement element)
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
                 WaitVisibilityOf(element);
            }
            catch (Exception e)
            {
                // logger.error("---> Could not scroll to the element");
            }
        }


        // - - - - - - - - - - Waits Helpers - - - - - - - - - - - - - //
        // ===================================================================//



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
        /// Wait up to 60 sec for the visibility of the element, alternative to wait for page load
        /// </summary>
        /// <param name="element"></param>
        public static void WaitVisibilityOf(IWebElement element)
        {
            WaitVisibilityOf(element, 60);
        }

        /// <summary>
        /// Waits for an element to be clickckable therefore visible
        /// </summary>
        /// <param name="element"></param>
        /// <param name="time"></param>
        public static void WaitVisibilityOf(IWebElement element, int time)
        {
              WebDriverWait waiting = new WebDriverWait(DriverInstance, TimeSpan.FromSeconds(time));

            try
            {

               waiting.Until(ExpectedConditions.ElementToBeClickable(element));
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


        public static void WaitVisibilityOfAllElements(By locator)
        {
            WaitVisibilityOfAllElements(locator, 60);
        }

        /// <summary>
        /// Waits for visibility of all element in a list using its locator "By"
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="time"></param>
        public static void WaitVisibilityOfAllElements(By locator, int time)
        {
            WebDriverWait waiting = new WebDriverWait(DriverInstance, TimeSpan.FromSeconds(time));

            try
            {

                waiting.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
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
        /// <param name="locator"></param>
        /// <param name="time"></param>
        public static void WaitInvisibilityOf(By locator, int time)
        {
            WebDriverWait waiting = new WebDriverWait(DriverInstance, TimeSpan.FromSeconds(time));
            waiting.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
        }


        // - - - - - - - - - - Windows / Frames - - - - - - - - - - - - //
        // ===================================================================//


        /// <summary>
        /// Switch to a frame
        /// </summary>
        /// <param name="frameName"></param>
        public static void SwitchToFrame(string frameName)
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

        // - - - - - - - - - - Page Object Helper - - - - - - - - - - //
        // ===================================================================//
     
            /// <summary>
            /// Gets element located by xpath
            /// </summary>
            /// <param name="xpath"></param>
            /// <returns>Element located by xpath</returns>
        public static IWebElement GetElementByXpath(string xpath)
        {
            return GetElementByXpath(xpath, 10, true);
        }

      
        /// <summary>
        /// Gets element located by Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Element located by Name</returns>
        public static IWebElement GetElementByName(string name)
        {
            return GetElementByName(name, 10, true);
        }

        /// <summary>
        /// Gets element located by ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>Element located by ID</returns>
        public static IWebElement GetElementByID(string ID)
        {
            return GetElementByID(ID, 10, true);
        }

        /// <summary>
        /// Gets list of elements located by xpath
        /// </summary>
        /// <param name="xpath"></param>
        /// <returns>List of Element located by Xpath</returns>
        public static List<IWebElement> GetListElementByXpath(string xpath)
        {
            return GetListElementByXpath(xpath, 10, true);
        }

        /// <summary>
        /// Gets list of elements located by name
        /// </summary>
        /// <param name="nae"></param>
        /// <returns>List of Element located by Name</returns>
        public static List<IWebElement> GetListElementByName(string name)
        {
            return GetListElementByName(name, 10, true);
        }

        /// <summary>
        /// Gets list of elements located by linkText
        /// </summary>
        /// <param name="linkText"></param>
        /// <returns>List of Element located by linkText</returns>
        public static IWebElement GetElementByLinkText(string linkText)
        {
            return GetElementByLinkText(linkText, 10, true);
        }

       
        public static IWebElement GetElementByXpath(string xpath, long time, bool printError)
        {
            return GetElement(xpath, time, printError, XPATH);
        }

       
       
        public static IWebElement GetElementByName(string name, long time, bool printError)
        {
            return GetElement(name, time, printError, NAME);
        }

      
        public static IWebElement GetElementByID(string id, long time, bool printError)
        {
            return GetElement(id, time, printError, ID);
        }

        
        public static IWebElement GetElementByLinkText(string link, long time, bool printError)
        {
            return GetElement(link, time, printError, LINK);
        }

      
        public static List<IWebElement> GetListElementByXpath(string xpath, long time, bool printError)
        {
            return GetListOfElements(xpath, time, printError, XPATH);
        }

       
        public static List<IWebElement> GetListElementByName(string name, long time, bool printError)
        {
            return GetListOfElements(name, time, printError, NAME);
        }

      
   

        private static List<IWebElement> GetListOfElements(string element, long time, bool printError, string by)
        {
            WebDriverWait wait = new WebDriverWait(DriverInstance, TimeSpan.FromSeconds(time));
            List<IWebElement> elements = null;
            // TODO: Need to create a medium wait about --> 10 secs

            for (int i = 0; i < MAX && (elements == null || elements.Count < 1); ++i)
            {
                try
                {
                    if (by.ToLower().Equals(NAME))
                        elements = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Name(element))).ToList();
                    else if (by.ToLower().Equals(XPATH))
                        elements = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(element))).ToList();

                }
                catch (Exception ex)
                {
                    // Nothing expected
                }
            }

            if (elements != null && elements.Count > 0)
                return elements;

            else
            {
                if (printError)
                {
                    Console.WriteLine("---> Unable to find List of elements with " + by + ": " + element);
                }
                return null;
            }
        }

        private static IWebElement GetElement(string element, long time, bool printError, string by)
        {
            WebDriverWait wait = new WebDriverWait(DriverInstance, TimeSpan.FromSeconds(time));
            List<IWebElement> elements = null;
            // TODO: Need to create a medium wait about --> 10 secs

            for (int i = 0; i < MAX && (elements == null || elements.Count < 1); ++i)
            {
                try
                {
                    if (by.ToLower().Equals(ID))
                        elements = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id(element))).ToList();
                    else if (by.ToLower().Equals(NAME))
                        elements = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Name(element))).ToList();
                    if (by.ToLower().Equals(XPATH))
                        elements = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(element))).ToList();
                    else if (by.ToLower().Equals(LINK))
                        try
                        {
                            elements = wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.LinkText(element))).ToList();
                        }
                        catch (Exception e)
                        {
                            elements = wait
                                    .Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.PartialLinkText(element))).ToList();
                        }

                }
                catch (Exception ex)
                {
                  
                    if (i == 1 && by.ToLower().Equals(XPATH))
                    {
                        element = "//*" + element.Substring(element.Split("\\[".ToCharArray()[0])[0].Length);
                        // xpath = "//*["+ xpath.split("\\[")[1];
                    }
                }
            }

            if (elements != null && elements.Count > 0)
                return elements.ElementAt(0);

            else
            {
                if (printError)
                {
                    Console.WriteLine("---> Unable to find element with " + by + ": " + element);
                }
                return null;
            }
        }

    }

}