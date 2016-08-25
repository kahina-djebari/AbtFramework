using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace AbtFramework
{
    public class MS2013UpgradePage : PageModel
    {
        private DocumentNavigation _documentnavigation;

        public DocumentNavigation DocumentNavigation {
            get
            {
                _documentnavigation = PageGenerator.GetPage<DocumentNavigation>();
                _documentnavigation.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _documentnavigation.action = new Actions(Driver.seleniumdriver);
                return _documentnavigation;
            }
        }
    }
}