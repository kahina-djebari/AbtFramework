using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium.Support.PageObjects;

namespace AbtFramework
{
    public class PageGenerator
    {

        public static T GetPage<T>() where T : PageModel, new()
        {
            T page = new T();
            PageFactory.InitElements(SeleniumDriver.DriverInstance, page);
            return page;

        }
    }
}