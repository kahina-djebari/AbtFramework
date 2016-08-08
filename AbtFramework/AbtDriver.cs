using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework
{
    public class AbtDriver
    {
        private static AbtKnowledgePage _abtKnowledgePage;
        private static AbtTravelPage _abtTravelPage;
        private static AtlasPage _atlasPage;
        private static HomePage _homePage;
        private static IsmsPage _ismsPage;
        private static OraclePage _oraclePage;
        private static ToolsAndResourcesPage _toolsAndResourcesPage;
        private static TopNavigation _topNavigation;
        private static OutlookWebPage _outlookWebPage;
        private static RepCapPlannerPage _repCapPlannerPage;
        private static ReputationalCapDBPage _reputationalCapDBPage;
        private static WebExPage _webExPage;
        private static OutlookEmailViewerPage _outolooEmailViewerPage;

        public static AbtKnowledgePage AbtKnowledgePage { get {  _abtKnowledgePage = PageGenerator.GetPage<AbtKnowledgePage>();

                _abtKnowledgePage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(15));
                _abtKnowledgePage.action = new Actions(Driver.seleniumdriver);
                return _abtKnowledgePage;
            } }

        public static AbtTravelPage AbtTravelPage { get {  _abtTravelPage = PageGenerator.GetPage<AbtTravelPage>();
                _abtTravelPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(15));
                _abtTravelPage.action = new Actions(Driver.seleniumdriver);
                return _abtTravelPage;
            } }

        public static AtlasPage AtlasPage { get {  _atlasPage = PageGenerator.GetPage<AtlasPage>();

                _atlasPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(15));
                _atlasPage.action = new Actions(Driver.seleniumdriver);
                return _atlasPage;
            } }

        public static HomePage HomePage { get {  _homePage = PageGenerator.GetPage<HomePage>();
               _homePage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(15));
               _homePage.action = new Actions(Driver.seleniumdriver);
                return _homePage;

            } }

        public static IsmsPage IsmsPage { get {  _ismsPage = PageGenerator.GetPage<IsmsPage>();

                _ismsPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(15));
                _ismsPage.action = new Actions(Driver.seleniumdriver);
                return _ismsPage;
            } }

        public static OraclePage OraclePage { get {  _oraclePage = PageGenerator.GetPage<OraclePage>();

                _oraclePage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(15));
                _oraclePage.action = new Actions(Driver.seleniumdriver);
                return _oraclePage;
            } }

        public static OutlookWebPage OutlookWebPage { get {  _outlookWebPage = PageGenerator.GetPage<OutlookWebPage>();

                _outlookWebPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(15));
                _outlookWebPage.action = new Actions(Driver.seleniumdriver);
                return _outlookWebPage;

            } }

        public static RepCapPlannerPage RepCapPlannerPage { get {  _repCapPlannerPage = PageGenerator.GetPage<RepCapPlannerPage>();
                _repCapPlannerPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(15));
                _repCapPlannerPage.action = new Actions(Driver.seleniumdriver);
                return _repCapPlannerPage;
            } }

        public static ReputationalCapDBPage ReputationalCapDBPage { get {  _reputationalCapDBPage = PageGenerator.GetPage<ReputationalCapDBPage>();

                _reputationalCapDBPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(15));
                _reputationalCapDBPage.action = new Actions(Driver.seleniumdriver);
                return _reputationalCapDBPage;
            } }

        public static ToolsAndResourcesPage ToolsAndResourcesPage { get { _toolsAndResourcesPage = PageGenerator.GetPage<ToolsAndResourcesPage>();

                _toolsAndResourcesPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(15));
               _toolsAndResourcesPage.action = new Actions(Driver.seleniumdriver);
                return _toolsAndResourcesPage;
            } }

        public static TopNavigation TopNavigation { get { _topNavigation = PageGenerator.GetPage<TopNavigation>();
                                                    _topNavigation.wait = new WebDriverWait(Driver.seleniumdriver,TimeSpan.FromSeconds(15));
                _topNavigation.action = new Actions(Driver.seleniumdriver);
                return _topNavigation;
                                                        } }

        public static WebExPage WebExPage {
            get
            {
                _webExPage = PageGenerator.GetPage<WebExPage>();
                _webExPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(15));
               _webExPage.action = new Actions(Driver.seleniumdriver);
                return _webExPage;
            }
        }

        public static OutlookEmailViewerPage OutlookEmailViewerPage
        {
            get
            {
                _outolooEmailViewerPage = PageGenerator.GetPage<OutlookEmailViewerPage>();
                _outolooEmailViewerPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(15));
                _outolooEmailViewerPage.action = new Actions(Driver.seleniumdriver);
                return _outolooEmailViewerPage;
            }
        }
    }
}
