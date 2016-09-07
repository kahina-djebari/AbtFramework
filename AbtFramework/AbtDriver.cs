﻿using OpenQA.Selenium.Interactions;
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
        private static StaffDirectoryPage _staffDirectoryPage;
        private static FormsLibraryPage _formsLibraryPage;
        private static CustomizeLinksPage _customizeLinksPage;
        private static TodayILearnedPage _todayILearnedPage;
        private static NewsPage _newsPage;
        private static AboutAbtPage _aboutAbtPage;
        private static ServiceNowHomepage _servicenowhomepage;
        private static ServiceHubHomepage _servicehubhomepage;
        private static HRServiceRequestpage _hrservicerequestpage;
        private static ITServiceRequestpage _itservicerequestpage;
        private static OfficeServiceRequestpage _officeservicerequestpage;
        private static NewIncidentPage _newincidentpage;
        private static OfficeRequestFormPage _officerequestformpage;
        private static ProjectsPage _projectspage;
        private static WordDocumentPage _worddocumentpage;
        private static MS2013UpgradePage _ms2013upgradepage;
        private static WeSpireHomePage _wespirehomepage;
        private static WeSpireLoginPage _wespireloginpage;
        private static EbscoHomePage _ebscohomepage;
        private static SuccessFactorHomePage _successfactorhomepage;
        private static ConcurHomePage _concurhomepage;
        private static WeSpireUpdateInterestsPage _wespireupdateinterestspage;
        private static WeSpireInvitePage _wespireinvitepage;
        private static ITServiceRequestFormPage _itserviceaskquestionpage;
        private static MyOpenIncidentsPage _myopenincidentspage;
        private static IncidentTablePageObject _incidenttablepageobject;
        private static ITKnowledgeBasePage _knowledgebase;
        private static PowerPointOnlinePage _powerpointonlinepage;
        private static ExcelOnlinePage _excelonlinepage;

        public static AbtKnowledgePage AbtKnowledgePage { get {  _abtKnowledgePage = PageGenerator.GetPage<AbtKnowledgePage>();

                _abtKnowledgePage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _abtKnowledgePage.action = new Actions(Driver.seleniumdriver);
                return _abtKnowledgePage;
            } }

 

        public static AbtTravelPage AbtTravelPage { get {  _abtTravelPage = PageGenerator.GetPage<AbtTravelPage>();
                _abtTravelPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _abtTravelPage.action = new Actions(Driver.seleniumdriver);
                return _abtTravelPage;
            } }

        public static AtlasPage AtlasPage { get {  _atlasPage = PageGenerator.GetPage<AtlasPage>();

                _atlasPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _atlasPage.action = new Actions(Driver.seleniumdriver);
                return _atlasPage;
            } }

        public static HomePage HomePage { get {  _homePage = PageGenerator.GetPage<HomePage>();
               _homePage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
               _homePage.action = new Actions(Driver.seleniumdriver);
                return _homePage;

            } }

        public static IsmsPage IsmsPage { get {  _ismsPage = PageGenerator.GetPage<IsmsPage>();

                _ismsPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _ismsPage.action = new Actions(Driver.seleniumdriver);
                return _ismsPage;
            } }

        public static OraclePage OraclePage { get {  _oraclePage = PageGenerator.GetPage<OraclePage>();

                _oraclePage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _oraclePage.action = new Actions(Driver.seleniumdriver);
                return _oraclePage;
            } }

        public static OutlookWebPage OutlookWebPage { get {  _outlookWebPage = PageGenerator.GetPage<OutlookWebPage>();

                _outlookWebPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _outlookWebPage.action = new Actions(Driver.seleniumdriver);
                return _outlookWebPage;

            } }

        public static RepCapPlannerPage RepCapPlannerPage { get {  _repCapPlannerPage = PageGenerator.GetPage<RepCapPlannerPage>();
                _repCapPlannerPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _repCapPlannerPage.action = new Actions(Driver.seleniumdriver);
                return _repCapPlannerPage;
            } }

        public static ReputationalCapDBPage ReputationalCapDBPage { get {  _reputationalCapDBPage = PageGenerator.GetPage<ReputationalCapDBPage>();

                _reputationalCapDBPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _reputationalCapDBPage.action = new Actions(Driver.seleniumdriver);
                return _reputationalCapDBPage;
            } }

        public static ToolsAndResourcesPage ToolsAndResourcesPage { get { _toolsAndResourcesPage = PageGenerator.GetPage<ToolsAndResourcesPage>();

                _toolsAndResourcesPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
               _toolsAndResourcesPage.action = new Actions(Driver.seleniumdriver);
                return _toolsAndResourcesPage;
            } }

        public static TopNavigation TopNavigation { get { _topNavigation = PageGenerator.GetPage<TopNavigation>();
                                                    _topNavigation.wait = new WebDriverWait(Driver.seleniumdriver,TimeSpan.FromSeconds(30));
                _topNavigation.action = new Actions(Driver.seleniumdriver);
                return _topNavigation;
                                                        } }

        public static WebExPage WebExPage {
            get
            {
                _webExPage = PageGenerator.GetPage<WebExPage>();
                _webExPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
               _webExPage.action = new Actions(Driver.seleniumdriver);
                return _webExPage;
            }
        }

        public static OutlookEmailViewerPage OutlookEmailViewerPage
        {
            get
            {
                _outolooEmailViewerPage = PageGenerator.GetPage<OutlookEmailViewerPage>();
                _outolooEmailViewerPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _outolooEmailViewerPage.action = new Actions(Driver.seleniumdriver);
                return _outolooEmailViewerPage;
            }
        }

        public static StaffDirectoryPage StaffDirectoryPage {
            get
            {
                _staffDirectoryPage = PageGenerator.GetPage<StaffDirectoryPage>();
                _staffDirectoryPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _staffDirectoryPage.action = new Actions(Driver.seleniumdriver);
                return _staffDirectoryPage;
            }
        }

        public static FormsLibraryPage FormsLibraryPage {
            get
            {
                _formsLibraryPage = PageGenerator.GetPage<FormsLibraryPage>();
                _formsLibraryPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _formsLibraryPage.action = new Actions(Driver.seleniumdriver);
                return _formsLibraryPage;
            }
        }

        public static CustomizeLinksPage CustomizeLinksPage
        {
            get
            {
                _customizeLinksPage = PageGenerator.GetPage<CustomizeLinksPage>();
                _customizeLinksPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _customizeLinksPage.action = new Actions(Driver.seleniumdriver);
                return _customizeLinksPage;
            }
        }

        public static TodayILearnedPage TodayILearnedPage {
            get
            {
                _todayILearnedPage = PageGenerator.GetPage<TodayILearnedPage>();
                _todayILearnedPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _todayILearnedPage.action = new Actions(Driver.seleniumdriver);
                return _todayILearnedPage;
            }
        }

        public static NewsPage NewsPage {

            get
            {
                _newsPage = PageGenerator.GetPage<NewsPage>();
                _newsPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _newsPage.action = new Actions(Driver.seleniumdriver);
                return _newsPage;
            }
        }

        public static AboutAbtPage AboutAbtPage
        {
            get
            {
                _aboutAbtPage = PageGenerator.GetPage<AboutAbtPage>();
                _aboutAbtPage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _aboutAbtPage.action = new Actions(Driver.seleniumdriver);
                return _aboutAbtPage;
            }
        }

        public static ServiceNowHomepage ServiceNowHomepage
        {
            get
            {
                _servicenowhomepage = PageGenerator.GetPage<ServiceNowHomepage>();
                _servicenowhomepage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _servicenowhomepage.action = new Actions(Driver.seleniumdriver);
                return _servicenowhomepage;
            }
        }

        public static ServiceHubHomepage ServiceHubHomepage {
            get
            {
                _servicehubhomepage = PageGenerator.GetPage<ServiceHubHomepage>();
                _servicehubhomepage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _servicehubhomepage.action = new Actions(Driver.seleniumdriver);
                return _servicehubhomepage;
            }
        }

        public static HRServiceRequestpage HRServiceRequestpage
        {
            get
            {
                _hrservicerequestpage = PageGenerator.GetPage<HRServiceRequestpage>();
                _hrservicerequestpage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _hrservicerequestpage.action = new Actions(Driver.seleniumdriver);
                return _hrservicerequestpage;
            }
        }

        public static ITServiceRequestpage ITServiceRequestpage {
            get
            {
                _itservicerequestpage = PageGenerator.GetPage<ITServiceRequestpage>();
                _itservicerequestpage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _itservicerequestpage.action = new Actions(Driver.seleniumdriver);
                return _itservicerequestpage;
            }
        }
        public static OfficeServiceRequestpage OfficeServiceRequestpage
        {
            get
            {
                _officeservicerequestpage = PageGenerator.GetPage<OfficeServiceRequestpage>();
                _officeservicerequestpage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _officeservicerequestpage.action = new Actions(Driver.seleniumdriver);
                return _officeservicerequestpage;
            }
        }

        public static NewIncidentPage NewIncidentPage
        {
            get
            {
                _newincidentpage = PageGenerator.GetPage<NewIncidentPage>();
                _newincidentpage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _newincidentpage.action = new Actions(Driver.seleniumdriver);
                return _newincidentpage;
            }
        }

        public static OfficeRequestFormPage OfficeRequestFormPage
        {
            get
            {
                _officerequestformpage = PageGenerator.GetPage<OfficeRequestFormPage>();
                _officerequestformpage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _officerequestformpage.action = new Actions(Driver.seleniumdriver);
                return _officerequestformpage;
            }
        }

        public static ProjectsPage ProjectsPage
        {
            get
            {
                _projectspage = PageGenerator.GetPage<ProjectsPage>();
                _projectspage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _projectspage.action = new Actions(Driver.seleniumdriver);
                return _projectspage;
            }
        }

        public static WordDocumentPage WordDocumentPage
        {
            get
            {
                _worddocumentpage = PageGenerator.GetPage<WordDocumentPage>();
                _worddocumentpage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _worddocumentpage.action = new Actions(Driver.seleniumdriver);
                return _worddocumentpage;
            }
        }

        public static MS2013UpgradePage MS2013UpgradePage
        {
            get
            {
                _ms2013upgradepage = PageGenerator.GetPage<MS2013UpgradePage>();
                _ms2013upgradepage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _ms2013upgradepage.action = new Actions(Driver.seleniumdriver);
                return _ms2013upgradepage;
            }
        }

        public static WeSpireHomePage WeSpireHomePage
        {
            get
            {
                _wespirehomepage = PageGenerator.GetPage<WeSpireHomePage>();
                _wespirehomepage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _wespirehomepage.action = new Actions(Driver.seleniumdriver);
                return _wespirehomepage;
            }
        }

        public static WeSpireLoginPage WeSpireLoginPage
        {
            get
            {
                _wespireloginpage = PageGenerator.GetPage<WeSpireLoginPage>();
                _wespireloginpage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _wespireloginpage.action = new Actions(Driver.seleniumdriver);
                return _wespireloginpage;
            }
        }

        public static EbscoHomePage EbscoHomePage {
            get
            {
                _ebscohomepage = PageGenerator.GetPage<EbscoHomePage>();
                _ebscohomepage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _ebscohomepage.action = new Actions(Driver.seleniumdriver);
                return _ebscohomepage;
            }
        }

        public static SuccessFactorHomePage SuccessFactorHomePage {
            get
            {
                _successfactorhomepage = PageGenerator.GetPage<SuccessFactorHomePage>();
                _successfactorhomepage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _successfactorhomepage.action = new Actions(Driver.seleniumdriver);
                return _successfactorhomepage;
            }
        }

        public static ConcurHomePage ConcurHomePage
        {
            get
            {
                _concurhomepage = PageGenerator.GetPage<ConcurHomePage>();
                _concurhomepage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _concurhomepage.action = new Actions(Driver.seleniumdriver);
                return _concurhomepage;
            }
        }

        public static WeSpireUpdateInterestsPage WeSpireUpdateInterestsPage
        {
            get
            {
                _wespireupdateinterestspage = PageGenerator.GetPage<WeSpireUpdateInterestsPage>();
                _wespireupdateinterestspage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _wespireupdateinterestspage.action = new Actions(Driver.seleniumdriver);
                return _wespireupdateinterestspage;
            }
        }

        public static WeSpireInvitePage WeSpireInvitePage {
            get
            {
                _wespireinvitepage = PageGenerator.GetPage<WeSpireInvitePage>();
                _wespireinvitepage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _wespireinvitepage.action = new Actions(Driver.seleniumdriver);
                return _wespireinvitepage;
            }
        }

        public static ITServiceRequestFormPage ITServiceRequestFormPage
        {
            get
            {
                _itserviceaskquestionpage = PageGenerator.GetPage<ITServiceRequestFormPage>();
                _itserviceaskquestionpage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _itserviceaskquestionpage.action = new Actions(Driver.seleniumdriver);
                return _itserviceaskquestionpage;
            }
        }

        public static MyOpenIncidentsPage MyOpenIncidentsPage
        {
            get
            {
                _myopenincidentspage = PageGenerator.GetPage<MyOpenIncidentsPage>();
                _myopenincidentspage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _myopenincidentspage.action = new Actions(Driver.seleniumdriver);
                return _myopenincidentspage;
            }
        }

        public static IncidentTablePageObject IncidentTablePageObject {
            get
            {
                _incidenttablepageobject = PageGenerator.GetPage<IncidentTablePageObject>();
                _incidenttablepageobject.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _incidenttablepageobject.action = new Actions(Driver.seleniumdriver);
                return _incidenttablepageobject;
            }
        }

        public static ITKnowledgeBasePage ITKnowledgeBasePage
        {
            get
            {
                _knowledgebase = PageGenerator.GetPage<ITKnowledgeBasePage>();
                _knowledgebase.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _knowledgebase.action = new Actions(Driver.seleniumdriver);
                return _knowledgebase;
            }
        }

        public static PowerPointOnlinePage PowerPointOnlinePage
        {
            get
            {
                _powerpointonlinepage= PageGenerator.GetPage<PowerPointOnlinePage>();
                _powerpointonlinepage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _powerpointonlinepage.action = new Actions(Driver.seleniumdriver);
                return _powerpointonlinepage;
            }
        }

        public static ExcelOnlinePage ExcelOnlinePage
        {
            get
            {
                _excelonlinepage = PageGenerator.GetPage<ExcelOnlinePage>();
                _excelonlinepage.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(30));
                _excelonlinepage.action = new Actions(Driver.seleniumdriver);
                return _excelonlinepage;
            }
        }
    }
}
