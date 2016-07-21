using OpenQA.Selenium.Support.PageObjects;
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
        private static OutlookWebPage __outlookWebPage;
        private static RepCapPlannerPage __repCapPlannerPage;
        private static ReputationalCapDBPage __reputationalCapDBPage;

        public static AbtKnowledgePage AbtKnowledgePage { get { return _abtKnowledgePage = PageGenerator.GetPage<AbtKnowledgePage>(); } }

        public static AbtTravelPage AbtTravelPage { get { return _abtTravelPage = PageGenerator.GetPage<AbtTravelPage>(); } }

        public static AtlasPage AtlasPage { get { return _atlasPage = PageGenerator.GetPage<AtlasPage>(); } }

        public static HomePage HomePage { get { return _homePage = PageGenerator.GetPage<HomePage>(); } }

        public static IsmsPage IsmsPage { get { return _ismsPage = PageGenerator.GetPage<IsmsPage>(); } }

        public static OraclePage OraclePage { get { return _oraclePage = PageGenerator.GetPage<OraclePage>(); } }

        public static OutlookWebPage OutlookWebPage { get { return __outlookWebPage = PageGenerator.GetPage<OutlookWebPage>(); } }

        public static RepCapPlannerPage RepCapPlannerPage { get { return __repCapPlannerPage = PageGenerator.GetPage<RepCapPlannerPage>(); } }

        public static ReputationalCapDBPage ReputationalCapDBPage { get { return __reputationalCapDBPage = PageGenerator.GetPage<ReputationalCapDBPage>(); } }

        public static ToolsAndResourcesPage ToolsAndResourcesPage { get { return _toolsAndResourcesPage = PageGenerator.GetPage<ToolsAndResourcesPage>(); } }

        public static TopNavigation TopNavigation { get { return _topNavigation = PageGenerator.GetPage<TopNavigation>(); } }
    }
}
