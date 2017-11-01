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
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbtFramework
{
    public class SeleniumDriver
    {

        static InternetExplorerOptions IEoptions;

        public static WebDriverWait GenerateDriverWait()
        {
            throw new NotImplementedException();
        }

        public static IWebDriver Instance;
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
        private static IWebDriver Instance2;
        private static IJavaScriptExecutor js;
        public static WebDriverWait customWait;
        private static WebDriverWait wait;
        public static EventFiringWebDriver FiringDriver2;

        public static void init(Browser browser)
        {
            switch (browser)
            {
                case Browser.IECleanSessionIgnoreProtectedMode:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;
                    IEoptions.EnsureCleanSession = true;
                    IEoptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits", IEoptions);

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.RemoteQALaptop:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;
                    IEoptions.EnableNativeEvents = false;
                    //  string localIp = MyUtils.GetLocalIpAddress();

                    Instance = new RemoteWebDriver(new Uri("http://" + MyUtils.GetLocalIpAddress() + ":4444/wd/hub"), IEoptions.ToCapabilities());

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();

                    break;
                case Browser.RemoteSofianesIECleanSession:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;
                    // IEoptions.EnsureCleanSession = true;
                    IEoptions.EnableNativeEvents = false;

                    Instance = new RemoteWebDriver(new Uri("http://10.220.68.64:4444/wd/hub"), IEoptions.ToCapabilities());

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;

                case Browser.IECleanSessionNoNativeEvents:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;
                    IEoptions.EnsureCleanSession = true;
                    IEoptions.EnableNativeEvents = false;

                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits", IEoptions);

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
                    Instance.Manage().Window.Maximize();
                    break;

                case Browser.IECleanSession:

                    IEoptions = new InternetExplorerOptions();
                    // IEoptions.EnablePersistentHover = false;
                    // IEoptions.EnableNativeEvents = false;
                    // IEoptions.EnsureCleanSession = true;
                    IEoptions.RequireWindowFocus = true;
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits", IEoptions);

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(35));
                    Instance.Manage().Window.Maximize();
                    break;


                case Browser.ServerRemote:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;
                    IEoptions.EnableNativeEvents = false;


                    Instance = new RemoteWebDriver(new Uri("http://172.18.58.20:4444/wd/hub"), IEoptions.ToCapabilities());

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();

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
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits", IEoptions);

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;

                case Browser.RemoteDavidIENoNativeEvents:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;
                    IEoptions.EnableNativeEvents = false;

                    Instance = new RemoteWebDriver(new Uri("http://" + MyUtils.GetLocalIpAddress() + ":4444/wd/hub"), IEoptions.ToCapabilities());

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;

                case Browser.RemoteDavidIE:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;


                    Instance = new RemoteWebDriver(new Uri("http://" + MyUtils.GetLocalIpAddress() + ":4444/wd/hub"), IEoptions.ToCapabilities());

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;

                case Browser.RemoteSofianesIE:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnablePersistentHover = true;


                    Instance = new RemoteWebDriver(new Uri("http://10.220.68.64:4444/wd/hub"), IEoptions.ToCapabilities());

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();

                    break;

                case Browser.RemoteSofianesIENoNativeEvents:

                    IEoptions = new InternetExplorerOptions();
                    IEoptions.IgnoreZoomLevel = true;
                    IEoptions.EnableNativeEvents = false;
                    Instance = new RemoteWebDriver(new Uri("http://10.220.68.64:4444/wd/hub"), IEoptions.ToCapabilities()

                       );

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();

                    break;

                case Browser.RemoteFrometaIE:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.IgnoreZoomLevel = true;
                    IEoptions.EnableNativeEvents = false;
                    Instance = new RemoteWebDriver(new Uri("http://172.18.58.24:4444/wd/hub"), IEoptions.ToCapabilities()

                       );

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;

                case Browser.IENoNativeEvents:
                    IEoptions = new InternetExplorerOptions();
                    IEoptions.EnableNativeEvents = false;
                    IEoptions.EnablePersistentHover = true;

                    //Clean Cache on Every Session ->  // IEoptions.EnsureCleanSession = true;

                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits", IEoptions);

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.Chrome:
                    Instance = new ChromeDriver(@"C:\Selenium\ChromeDriver");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.IE246:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.46\32bits");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.IE247:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.47\32bits");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.IE248:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.48\32bits");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.IE249:

                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.49\32bits");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.IE250:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.50\32bits");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.IE251:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.51\32bits");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.IE252:

                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.52\32bits");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.IE24664:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.46\64bits");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.IE24764:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.47\64bits");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.IE24864:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.48\64bits");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.IE24964:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.49\64bits");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.IE25064:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.50\64bits");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.IE25164:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.51\64bits");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
                    break;
                case Browser.IE25264:
                    Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.52\64bits");

                    Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
                    Instance.Manage().Window.Maximize();
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
            WebDriverWait wait = new WebDriverWait(Instance, TimeSpan.FromSeconds(5));
            var alert = wait.Until(ExpectedConditions.AlertIsPresent());

            return alert.Text;
        }

        public static void GoTo(string url)
        {
            SeleniumDriver.Instance.Navigate().GoToUrl(url);
        }



        public static void CloseAll()
        {


            Instance.Quit();

        }

        private static void TakeScreenShotOnException(object sender, WebDriverExceptionEventArgs e)
        {

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
            Instance.TakeScreenshot().SaveAsFile("failedTest-" + timestamp + ".png", ImageFormat.Png);
        }

        public static void RemoteInitDavidsPc(Browser browser)
        {
            IEoptions = new InternetExplorerOptions();
            IEoptions.EnablePersistentHover = true;


            Instance = new RemoteWebDriver(new Uri("http://172.18.58.26:4444/wd/hub"), IEoptions.ToCapabilities());

            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            Instance.Manage().Window.Maximize();
        }

        public static void RemoteInitFrometasPC(Browser browser)
        {
            IEoptions = new InternetExplorerOptions();
            IEoptions.EnablePersistentHover = true;


            Instance = new RemoteWebDriver(new Uri("http://172.18.58.29:4444/wd/hub"), IEoptions.ToCapabilities());

            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            Instance.Manage().Window.Maximize();
        }

        public static void init()
        {
            DesiredCapabilities d = DesiredCapabilities.InternetExplorer();
            d.SetCapability("nativeEvents", false);


            Instance = new InternetExplorerDriver(@"C:\Selenium\IEDriver\2.45\32bits");

            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            Instance.Manage().Window.Maximize();
        }

        public static void Close()
        {
            Instance.Close();
        }

        internal static string GetcurrentWindowHandler(ReadOnlyCollection<string> windowsHandler)
        {
            foreach (var window in windowsHandler)
            {
                Console.WriteLine(window);
                if (window != Instance.CurrentWindowHandle)
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

            Instance = new RemoteWebDriver(new Uri("http://10.220.68.64:4444/wd/hub"), IEoptions.ToCapabilities()

               );

            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            Instance.Manage().Window.Maximize();

        }

        public static void Quit()
        {
            Instance.Quit();
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


        /**
	 * perform a click on the element
	 * 
	 * @param element
	 */
        public static void ClickElement(IWebElement element)
        {
            //  GlobalUtils.customWait(1); // require or it will go to fast
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

        /**
	 * set a value in an element. usually text fields, input tag if value is not
	 * correct it will re-try
	 * 
	 * @param element
	 * @param value
	 *            to set
	 */
        public static void SetValue(IWebElement element, string value)
        {
            //GlobalUtils.customWait(1); // require or it will go to fast :(

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

        /**
	 * clear the value, works for input and textarea
	 * 
	 * @param element
	 */
        public static void ClearValue(IWebElement element)
        {
            //  GlobalUtils.customWait(1); // :( required
            try
            {
                element.Clear();
            }
            catch (Exception e)
            {
                // Ignore
            }
        }



        /**
	 * return the value of the attribute VALUE in the element common for input
	 * fields
	 * 
	 * @param element
	 * @return the text of the value property
	 */
        public static string GetValue(IWebElement element)
        {
            return element.GetAttribute("value");
        }



        /**
	 * return the value of an specified attribute name in the element
	 * 
	 * @param element
	 * @param attributeName-
	 *            name of the attribute you want to get the value of
	 */
        public static string GetAttributeValue(IWebElement element, string attributeName)
        {
            return element.GetAttribute(attributeName);
        }


        /**
	 * return the text of that element
	 * 
	 * @param element
	 */
        public static string GetText(IWebElement element)
        {
            string text = element.Text;

            if (text.Equals(""))
                text = (string)js.ExecuteScript("return arguments[0].value", element);

            if (text.Equals(""))
                text = (string)js.ExecuteScript("return arguments[0].textContent", element);

            return text;
        }

        /**
	 * return if the checkbox is checked
	 * 
	 * @param element
	 */
        public bool IsChecked(IWebElement element)
        {

            return (Boolean)js.ExecuteScript("return arguments[0].checked", element);
        }


        /**
	 * select an item in a drop down element by the value
	 * 
	 * @param element
	 * @param value-
	 *            name of the item, value of the item
	 */
        public static void SelectDropDown(IWebElement element, string value)
        {

            new SelectElement(element).SelectByValue(value);
        }


        /**
	 * select an item in a drop down element by the index
	 * 
	 * @param element
	 * @param value-
	 *            index of the item
	 */
        public static void SelectDropDown(IWebElement element, int value)
        {
            new SelectElement(element).SelectByIndex(value);
        }


        /**
	 * select an item in a drop down element by the text visible
	 * 
	 * @param element
	 * @param text
	 */
        public static void SelectDropDownByText(IWebElement element, string text)
        {
            new SelectElement(element).SelectByText(text);
        }


        /**
	 * scroll the current windows to a certain element
	 * 
	 * @param element
	 */
        public static void ScrollToElement(IWebElement element)
        {
            // GlobalUtils.customWait(3);
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


        /**
	 * @param time
	 *            max time set for the element to be found
	 * @return the wait instance to be use in custom situations
	 */
        public static WebDriverWait CustomWait(IWebDriver driver, int time)
        {
            customWait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            return customWait;
        }


        /**
 * wait for the HTML DOM to be ready, all elements loaded
 * 
 * note: Does not guarantee the full page has loaded, sometimes DOM can
 * return complete, but some elements are still loading dynamically.
 */
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







    }

}