using OpenQA.Selenium.Support.PageObjects;

namespace AbtFramework
{
    public class PageGenerator
    {

        public static T GetPage<T>() where T : PageModel, new()
        {
            T page = new T();
            PageFactory.InitElements(Driver.seleniumdriver, page);
            return page;

        }
    }
}