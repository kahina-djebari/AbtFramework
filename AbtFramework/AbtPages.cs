using AbtFramework.ERP;
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
    public class AbtPages
    {
        private static AbtKnowledgePage _abtKnowledgePage;
        private static AbtTravelPage _abtTravelPage;
        private static AtlasPage _atlasPage;
        private static AgiHomePage _homePage;
        private static IsmsPage _ismsPage;
        private static OraclePage _oraclePage;
        private static ToolsAndResourcesPage _toolsAndResourcesPage;
        private static AgiTopNavigation _topNavigation;
        private static OutlookWebPage _outlookWebPage;
        private static RepCapPlannerPage _repCapPlannerPage;
        private static ReputationalCapDBPage _reputationalCapDBPage;
        private static WebExPage _webExPage;
        private static OutlookEmailViewerPage _outolooEmailViewerPage;
        private static StaffDirectoryPage _staffDirectoryPage;
        private static FormsLibraryPage _formsLibraryPage;
        private static CustomizeLinksPage _customizeLinksPage;
        private static TodayILearnedPage _todayILearnedPage;
        private static AgiNews _newsPage;
        private static AboutAbtPage _aboutAbtPage;
        private static ServiceNowHomepage _servicenowhomepage;
        private static ServiceHubHomepage _servicehubhomepage;
        private static HRServiceRequestpage _hrservicerequestpage;
        private static ITServiceRequestpage _itservicerequestpage;
        private static OfficeServiceRequestpage _officeservicerequestpage;
        private static NewIncidentPage _newincidentpage;
        private static OfficeRequestFormPage _officerequestformpage;
        private static ProjectsPage _projectspage;
        private static WordOnlinePage _worddocumentpage;
        private static WeSpireHomePage _wespirehomepage;
        private static WeSpireLoginPage _wespireloginpage;
        private static EbscoHomePage _ebscohomepage;
        private static SuccessFactorHomePage _successfactorhomepage;
        private static ConcurHomePage _concurhomepage;
        private static WeSpireUpdateInterestsPage _wespireupdateinterestspage;
        private static WeSpireInvitePage _wespireinvitepage;
        private static ITServiceRequestFormPage _itserviceaskquestionpage;
        private static MyOpenIncidentsPage _myopenincidentspage;
        private static TablePageObject _incidenttablepageobject;
        private static ITKnowledgeBasePage _knowledgebase;
        private static PowerPointOnlinePage _powerpointonlinepage;
        private static ExcelOnlinePage _excelonlinepage;
        private static ConferencingSetupPage _conferencingsetup;
        private static SubmittedOrderPage _confsetupconfirmation;
        private static DistListReqFormPage _distlistreqpage;
        private static RightFindHomePage _rightfindhomepage;
        private static SharePointTopNavigation _sharepointtopnavigation;
        private static KmWorkSpacePage _kmworspace;
        private static SharePointDocumentNavigation _documentnavigation;
        private static EbscoMyAccountPage _ebscomyaccountpage;
        private static Office365LoginPage _sharepointhomepage;
        private static MailOffice365Page _mailoffice365;
        private static AgiAbtLearnPage _agiabtlearn;
        private static AgiBusinessDevelopmentPage _agibusinessdevelopment;
        private static AgiCTCPage _agictcpage;
        private static AgiContractOperationsPage _agicontractoperationspage;
        private static AgiCreativeServices _agicreativeservices;
        private static AgiFinance _agifinance;
        private static AgiHRServiceCenter _agihrservicecenter;
        private static AgiITServiceCenter _agiItservicecenter;
        private static AgiOfficeServices _agiofficeservices;
        private static AgiReputationalCapital _agireputationalcapital;
        private static AgiTravelPage _agitravelpage;
        private static AgiAbtResearch _agiabtresearch;
        private static AgiFormLibrary _agiformlibrary;
        private static Agi_ImageLibraries _agi_imageLibraries;
        private static Agi_PolicyLibraryPage _agipolicylibrary;
        private static Agi_ProposalLibrary _agiproposallibrary;
        private static Agi_ExpertiseCenter _agiexpertisecenters;
        private static AgiEmergencyCommunications _agiemergency;
        private static AgiAboutAbt _agiAboutabt;
        private static AgiDepartments _agidepartments;
        private static AgiInitiatives _agi_initiatives;
        private static AgiSubsidaries _agisubsidaries;
        private static AgiDivisions _agidivisions;
        private static AgiAbtStrategy _agiabtstrategy;
        private static AgiAbtValues _agiabtvalues;
        private static AgiHelpPage _agihelp;
        private static AgiCommunities _agicommunities;
        private static AgiEAC _agieac;
        private static AgiAnnouncements _agiannouncements;
        private static AgiEvents _agievents;
        private static AgiNewsArchive _aginewsarchive;
        private static AgiProposals _agiproposals;
        private static SANSHomepage _sanshomepage;
        private static ServiceNowTaskBar _sntaskbar;
        private static ServiceNowIRRForm _servicenowIRRform;
        private static ServiceNowIRRTable _servicenowIRRTable;
        private static AgiAbtLibrarySearch _AgiAbtLibrary;
        private static KnowledgeHubLandingPage _knowledgehublandingpage;
        private static ERPBillAndAdjustments _ERPBillAndAdjustsments;
        private static ERPExpenseReports _ERPExpenseReports;
         public static ERPBillAndAdjustments ERPBillAndAdjustsments
        { get {
                _ERPBillAndAdjustsments = PageGenerator.GetPage<ERPBillAndAdjustments>();

                _ERPBillAndAdjustsments.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _ERPBillAndAdjustsments.action = new Actions(SeleniumDriver.Instance);
                return _ERPBillAndAdjustsments;
            } }
        public static ERPExpenseReports ERPExpenseReports
        {
            get
            {
                _ERPExpenseReports = PageGenerator.GetPage<ERPExpenseReports>();

                _ERPExpenseReports.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _ERPExpenseReports.action = new Actions(SeleniumDriver.Instance);
                return _ERPExpenseReports;
            }
        }

        public static AbtKnowledgePage AbtKnowledgePage { get {  _abtKnowledgePage = PageGenerator.GetPage<AbtKnowledgePage>();

                _abtKnowledgePage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _abtKnowledgePage.action = new Actions(SeleniumDriver.Instance);
                return _abtKnowledgePage;
            } }

        public static KnowledgeHubLandingPage KnowledgeHubLandingPage { get {
                _knowledgehublandingpage = PageGenerator.GetPage<KnowledgeHubLandingPage>();
                _knowledgehublandingpage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _knowledgehublandingpage.action = new Actions(SeleniumDriver.Instance);
                return _knowledgehublandingpage;
            } }

        public static AbtTravelPage AbtTravelPage { get {  _abtTravelPage = PageGenerator.GetPage<AbtTravelPage>();
                _abtTravelPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _abtTravelPage.action = new Actions(SeleniumDriver.Instance);
                return _abtTravelPage;
            } }

        public static AtlasPage AtlasPage { get {  _atlasPage = PageGenerator.GetPage<AtlasPage>();

                _atlasPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _atlasPage.action = new Actions(SeleniumDriver.Instance);
                return _atlasPage;
            } }

        public static AgiHomePage AgiHomePage { get {  _homePage = PageGenerator.GetPage<AgiHomePage>();
               _homePage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
               _homePage.action = new Actions(SeleniumDriver.Instance);
                return _homePage;

            } }

        public static IsmsPage IsmsPage { get {  _ismsPage = PageGenerator.GetPage<IsmsPage>();

                _ismsPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _ismsPage.action = new Actions(SeleniumDriver.Instance);
                return _ismsPage;
            } }

        public static OraclePage OraclePage { get {  _oraclePage = PageGenerator.GetPage<OraclePage>();

                _oraclePage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _oraclePage.action = new Actions(SeleniumDriver.Instance);
                return _oraclePage;
            } }

        public static OutlookWebPage OutlookWebPage { get {  _outlookWebPage = PageGenerator.GetPage<OutlookWebPage>();

                _outlookWebPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _outlookWebPage.action = new Actions(SeleniumDriver.Instance);
                return _outlookWebPage;

            } }

        public static RepCapPlannerPage RepCapPlannerPage { get {  _repCapPlannerPage = PageGenerator.GetPage<RepCapPlannerPage>();
                _repCapPlannerPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _repCapPlannerPage.action = new Actions(SeleniumDriver.Instance);
                return _repCapPlannerPage;
            } }

        public static ReputationalCapDBPage ReputationalCapDBPage { get {  _reputationalCapDBPage = PageGenerator.GetPage<ReputationalCapDBPage>();

                _reputationalCapDBPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _reputationalCapDBPage.action = new Actions(SeleniumDriver.Instance);
                return _reputationalCapDBPage;
            } }

        public static ToolsAndResourcesPage ToolsAndResourcesPage { get { _toolsAndResourcesPage = PageGenerator.GetPage<ToolsAndResourcesPage>();

                _toolsAndResourcesPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
               _toolsAndResourcesPage.action = new Actions(SeleniumDriver.Instance);
                return _toolsAndResourcesPage;
            } }

        public static AgiTopNavigation AgiTopNavigation { get { _topNavigation = PageGenerator.GetPage<AgiTopNavigation>();
                                                    _topNavigation.wait = new WebDriverWait(SeleniumDriver.Instance,TimeSpan.FromSeconds(30));
                _topNavigation.action = new Actions(SeleniumDriver.Instance);
                return _topNavigation;
                                                        } }

        public static WebExPage WebExPage {
            get
            {
                _webExPage = PageGenerator.GetPage<WebExPage>();
                _webExPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
               _webExPage.action = new Actions(SeleniumDriver.Instance);
                return _webExPage;
            }
        }

        public static OutlookEmailViewerPage OutlookEmailViewerPage
        {
            get
            {
                
                   _outolooEmailViewerPage = PageGenerator.GetPage<OutlookEmailViewerPage>();
                _outolooEmailViewerPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _outolooEmailViewerPage.action = new Actions(SeleniumDriver.Instance);
                return _outolooEmailViewerPage;
            }
        }

        public static StaffDirectoryPage StaffDirectoryPage {
            get
            {
                _staffDirectoryPage = PageGenerator.GetPage<StaffDirectoryPage>();
                _staffDirectoryPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _staffDirectoryPage.action = new Actions(SeleniumDriver.Instance);
                return _staffDirectoryPage;
            }
        }

        public static FormsLibraryPage FormsLibraryPage {
            get
            {
                _formsLibraryPage = PageGenerator.GetPage<FormsLibraryPage>();
                _formsLibraryPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _formsLibraryPage.action = new Actions(SeleniumDriver.Instance);
                return _formsLibraryPage;
            }
        }

        public static CustomizeLinksPage CustomizeLinksPage
        {
            get
            {
                _customizeLinksPage = PageGenerator.GetPage<CustomizeLinksPage>();
                _customizeLinksPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _customizeLinksPage.action = new Actions(SeleniumDriver.Instance);
                return _customizeLinksPage;
            }
        }

        public static TodayILearnedPage TodayILearnedPage {
            get
            {
                _todayILearnedPage = PageGenerator.GetPage<TodayILearnedPage>();
                _todayILearnedPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _todayILearnedPage.action = new Actions(SeleniumDriver.Instance);
                return _todayILearnedPage;
            }
        }

        public static AgiNews AgiNews {

            get
            {
                _newsPage = PageGenerator.GetPage<AgiNews>();
                _newsPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _newsPage.action = new Actions(SeleniumDriver.Instance);
                return _newsPage;
            }
        }

        public static AboutAbtPage AboutAbtPage
        {
            get
            {
                _aboutAbtPage = PageGenerator.GetPage<AboutAbtPage>();
                _aboutAbtPage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _aboutAbtPage.action = new Actions(SeleniumDriver.Instance);
                return _aboutAbtPage;
            }
        }

        public static ServiceNowHomepage ServiceNowHomepage
        {
            get
            {
                _servicenowhomepage = PageGenerator.GetPage<ServiceNowHomepage>();
                _servicenowhomepage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _servicenowhomepage.action = new Actions(SeleniumDriver.Instance);
                return _servicenowhomepage;
            }
        }

        public static ServiceHubHomepage ServiceHubHomepage {
            get
            {
                _servicehubhomepage = PageGenerator.GetPage<ServiceHubHomepage>();
                _servicehubhomepage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _servicehubhomepage.action = new Actions(SeleniumDriver.Instance);
                return _servicehubhomepage;
            }
        }

        public static HRServiceRequestpage HRServiceRequestpage
        {
            get
            {
                _hrservicerequestpage = PageGenerator.GetPage<HRServiceRequestpage>();
                _hrservicerequestpage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _hrservicerequestpage.action = new Actions(SeleniumDriver.Instance);
                return _hrservicerequestpage;
            }
        }

        public static ITServiceRequestpage ITServiceRequestpage {
            get
            {
                _itservicerequestpage = PageGenerator.GetPage<ITServiceRequestpage>();
                _itservicerequestpage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _itservicerequestpage.action = new Actions(SeleniumDriver.Instance);
                return _itservicerequestpage;
            }
        }
        public static OfficeServiceRequestpage OfficeServiceRequestpage
        {
            get
            {
                _officeservicerequestpage = PageGenerator.GetPage<OfficeServiceRequestpage>();
                _officeservicerequestpage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _officeservicerequestpage.action = new Actions(SeleniumDriver.Instance);
                return _officeservicerequestpage;
            }
        }

        public static NewIncidentPage NewIncidentPage
        {
            get
            {
                _newincidentpage = PageGenerator.GetPage<NewIncidentPage>();
                _newincidentpage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _newincidentpage.action = new Actions(SeleniumDriver.Instance);
                return _newincidentpage;
            }
        }

        public static OfficeRequestFormPage OfficeRequestFormPage
        {
            get
            {
                _officerequestformpage = PageGenerator.GetPage<OfficeRequestFormPage>();
                _officerequestformpage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _officerequestformpage.action = new Actions(SeleniumDriver.Instance);
                return _officerequestformpage;
            }
        }

        public static ProjectsPage ProjectsPage
        {
            get
            {
                _projectspage = PageGenerator.GetPage<ProjectsPage>();
                _projectspage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _projectspage.action = new Actions(SeleniumDriver.Instance);
                return _projectspage;
            }
        }

        public static WordOnlinePage WordOnlinePage
        {
            get
            {
                _worddocumentpage = PageGenerator.GetPage<WordOnlinePage>();
                _worddocumentpage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _worddocumentpage.action = new Actions(SeleniumDriver.Instance);
                return _worddocumentpage;
            }
        }

     
        public static SharePointDocumentNavigation SharePointDocumentNavigation
        {
            get
            {
                _documentnavigation = PageGenerator.GetPage<SharePointDocumentNavigation>();
                _documentnavigation.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _documentnavigation.action = new Actions(SeleniumDriver.Instance);
                return _documentnavigation;
            }
        }

        public static WeSpireHomePage WeSpireHomePage
        {
            get
            {
                _wespirehomepage = PageGenerator.GetPage<WeSpireHomePage>();
                _wespirehomepage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _wespirehomepage.action = new Actions(SeleniumDriver.Instance);
                return _wespirehomepage;
            }
        }

        public static WeSpireLoginPage WeSpireLoginPage
        {
            get
            {
                _wespireloginpage = PageGenerator.GetPage<WeSpireLoginPage>();
                _wespireloginpage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _wespireloginpage.action = new Actions(SeleniumDriver.Instance);
                return _wespireloginpage;
            }
        }

        public static EbscoHomePage EbscoHomePage {
            get
            {
                _ebscohomepage = PageGenerator.GetPage<EbscoHomePage>();
                _ebscohomepage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _ebscohomepage.action = new Actions(SeleniumDriver.Instance);
                return _ebscohomepage;
            }
        }

        public static SuccessFactorHomePage SuccessFactorHomePage {
            get
            {
                _successfactorhomepage = PageGenerator.GetPage<SuccessFactorHomePage>();
                _successfactorhomepage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _successfactorhomepage.action = new Actions(SeleniumDriver.Instance);
                return _successfactorhomepage;
            }
        }

        public static ConcurHomePage ConcurHomePage
        {
            get
            {
                _concurhomepage = PageGenerator.GetPage<ConcurHomePage>();
                _concurhomepage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _concurhomepage.action = new Actions(SeleniumDriver.Instance);
                return _concurhomepage;
            }
        }

        public static WeSpireUpdateInterestsPage WeSpireUpdateInterestsPage
        {
            get
            {
                _wespireupdateinterestspage = PageGenerator.GetPage<WeSpireUpdateInterestsPage>();
                _wespireupdateinterestspage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _wespireupdateinterestspage.action = new Actions(SeleniumDriver.Instance);
                return _wespireupdateinterestspage;
            }
        }

        public static WeSpireInvitePage WeSpireInvitePage {
            get
            {
                _wespireinvitepage = PageGenerator.GetPage<WeSpireInvitePage>();
                _wespireinvitepage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _wespireinvitepage.action = new Actions(SeleniumDriver.Instance);
                return _wespireinvitepage;
            }
        }

        public static ITServiceRequestFormPage ITServiceRequestFormPage
        {
            get
            {
                _itserviceaskquestionpage = PageGenerator.GetPage<ITServiceRequestFormPage>();
                _itserviceaskquestionpage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _itserviceaskquestionpage.action = new Actions(SeleniumDriver.Instance);
                return _itserviceaskquestionpage;
            }
        }

        public static MyOpenIncidentsPage MyOpenIncidentsPage
        {
            get
            {
                _myopenincidentspage = PageGenerator.GetPage<MyOpenIncidentsPage>();
                _myopenincidentspage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _myopenincidentspage.action = new Actions(SeleniumDriver.Instance);
                return _myopenincidentspage;
            }
        }

        public static TablePageObject TablePageObject {
            get
            {
                _incidenttablepageobject = PageGenerator.GetPage<TablePageObject>();
                _incidenttablepageobject.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _incidenttablepageobject.action = new Actions(SeleniumDriver.Instance);
                return _incidenttablepageobject;
            }
        }

        public static ITKnowledgeBasePage ITKnowledgeBasePage
        {
            get
            {
                _knowledgebase = PageGenerator.GetPage<ITKnowledgeBasePage>();
                _knowledgebase.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _knowledgebase.action = new Actions(SeleniumDriver.Instance);
                return _knowledgebase;
            }
        }

        public static PowerPointOnlinePage PowerPointOnlinePage
        {
            get
            {
                _powerpointonlinepage= PageGenerator.GetPage<PowerPointOnlinePage>();
                _powerpointonlinepage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _powerpointonlinepage.action = new Actions(SeleniumDriver.Instance);
                return _powerpointonlinepage;
            }
        }

        public static ExcelOnlinePage ExcelOnlinePage
        {
            get
            {
                _excelonlinepage = PageGenerator.GetPage<ExcelOnlinePage>();
                _excelonlinepage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _excelonlinepage.action = new Actions(SeleniumDriver.Instance);
                return _excelonlinepage;
            }
        }

        public static ConferencingSetupPage ConferencingSetupPage {
            get
            {
                _conferencingsetup= PageGenerator.GetPage<ConferencingSetupPage>();
                _conferencingsetup.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _conferencingsetup.action = new Actions(SeleniumDriver.Instance);
                return _conferencingsetup;
            }
        }

        public static SubmittedOrderPage SubmittedOrderPage {
            get
            {
                _confsetupconfirmation = PageGenerator.GetPage<SubmittedOrderPage>();
                _confsetupconfirmation.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _confsetupconfirmation.action = new Actions(SeleniumDriver.Instance);
                return _confsetupconfirmation;
            }
        }

        public static DistListReqFormPage DistListReqFormPage
        {
            get
            {
                _distlistreqpage = PageGenerator.GetPage<DistListReqFormPage>();
                _distlistreqpage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _distlistreqpage.action = new Actions(SeleniumDriver.Instance);
                return _distlistreqpage;
            }
        }

        public static RightFindHomePage RightFindHomePage {
            get
            {
                _rightfindhomepage = PageGenerator.GetPage<RightFindHomePage>();
                _rightfindhomepage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _rightfindhomepage.action = new Actions(SeleniumDriver.Instance);
                return _rightfindhomepage;
            }
        }

        public static SharePointTopNavigation SharePointTopNavigation
        {
            get
            {
                _sharepointtopnavigation = PageGenerator.GetPage<SharePointTopNavigation>();
                _sharepointtopnavigation.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _sharepointtopnavigation.action = new Actions(SeleniumDriver.Instance);
                return _sharepointtopnavigation;
            }
        }

        public static KmWorkSpacePage KmWorkSpacePage {
            get
            {
                _kmworspace = PageGenerator.GetPage<KmWorkSpacePage>();
                _kmworspace.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _kmworspace.action = new Actions(SeleniumDriver.Instance);
                return _kmworspace;
            }
        }

        public static EbscoMyAccountPage EbscoMyAccountPage
        {
            get
            {
                _ebscomyaccountpage = PageGenerator.GetPage<EbscoMyAccountPage>();
                _ebscomyaccountpage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _ebscomyaccountpage.action = new Actions(SeleniumDriver.Instance);
                return _ebscomyaccountpage;
            }
        }

        public static Office365LoginPage Office365LoginPage {
            get
            {
                _sharepointhomepage= PageGenerator.GetPage<Office365LoginPage>();
                _sharepointhomepage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _sharepointhomepage.action = new Actions(SeleniumDriver.Instance);
                return _sharepointhomepage;
            }
        }

        public static MailOffice365Page MailOffice365Page {
            get
            {
                _mailoffice365 = PageGenerator.GetPage<MailOffice365Page>();
                _mailoffice365.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _mailoffice365.action = new Actions(SeleniumDriver.Instance);
                return _mailoffice365;
            }
        }

        public static AgiAbtLearnPage AgiAbtLearnPage {
            get
            {
                _agiabtlearn = PageGenerator.GetPage<AgiAbtLearnPage>();
                _agiabtlearn.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agiabtlearn.action = new Actions(SeleniumDriver.Instance);
                return _agiabtlearn;
            }
        }

        public static AgiBusinessDevelopmentPage AgiBusinessDevelopmentPage {
            get
            {
                _agibusinessdevelopment = PageGenerator.GetPage<AgiBusinessDevelopmentPage>();
                _agibusinessdevelopment.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agibusinessdevelopment.action = new Actions(SeleniumDriver.Instance);
                return _agibusinessdevelopment;
            }
        }

        public static AgiCTCPage AgiCTCPage {
            get
            {
                _agictcpage = PageGenerator.GetPage<AgiCTCPage>();
                _agictcpage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agictcpage.action = new Actions(SeleniumDriver.Instance);
                return _agictcpage;
            }
        }

        public static AgiContractOperationsPage AgiContractOperationsPage
        {
            get
            {
                _agicontractoperationspage = PageGenerator.GetPage<AgiContractOperationsPage>();
                _agicontractoperationspage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agicontractoperationspage.action = new Actions(SeleniumDriver.Instance);
                return _agicontractoperationspage;
            }
        }

        public static AgiCreativeServices AgiCreativeServices
        {
            get
            {
                _agicreativeservices = PageGenerator.GetPage<AgiCreativeServices>();
                _agicreativeservices.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agicreativeservices.action = new Actions(SeleniumDriver.Instance);
                return _agicreativeservices;
            }
        }

        public static AgiFinance AgiFinance
        {
            get
            {
                _agifinance = PageGenerator.GetPage<AgiFinance>();
                _agifinance.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agifinance.action = new Actions(SeleniumDriver.Instance);
                return _agifinance;
            }
        }

        public static AgiHRServiceCenter AgiHRServiceCenter {
            get
            {
                _agihrservicecenter = PageGenerator.GetPage<AgiHRServiceCenter>();
                _agihrservicecenter.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agihrservicecenter.action = new Actions(SeleniumDriver.Instance);
                return _agihrservicecenter;
            }
        }

        public static AgiITServiceCenter AgiITServiceCenter
        {
            get
            {
                _agiItservicecenter = PageGenerator.GetPage<AgiITServiceCenter>();
                _agiItservicecenter.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agiItservicecenter.action = new Actions(SeleniumDriver.Instance);
                return _agiItservicecenter;
            }
        }

        public static AgiOfficeServices AgiOfficeServices
        {
            get
            {
                _agiofficeservices = PageGenerator.GetPage<AgiOfficeServices>();
                _agiofficeservices.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agiofficeservices.action = new Actions(SeleniumDriver.Instance);
                return _agiofficeservices;
            }
        }

        public static AgiReputationalCapital AgiReputationalCapital
        {
            get
            {
                _agireputationalcapital = PageGenerator.GetPage<AgiReputationalCapital>();
                _agireputationalcapital.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agireputationalcapital.action = new Actions(SeleniumDriver.Instance);
                return _agireputationalcapital;
            }
        }

        public static AgiTravelPage AgiTravelPage {
            get
            {
                _agitravelpage = PageGenerator.GetPage<AgiTravelPage>();
                _agitravelpage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agitravelpage.action = new Actions(SeleniumDriver.Instance);
                return _agitravelpage;
            }
        }

        public static AgiAbtResearch AgiAbtResearch {
            get
            {
                _agiabtresearch = PageGenerator.GetPage<AgiAbtResearch>();
                _agiabtresearch.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agiabtresearch.action = new Actions(SeleniumDriver.Instance);
                return _agiabtresearch;
            }
        }

        public static AgiFormLibrary AgiFormLibrary {
            get
            {
                _agiformlibrary= PageGenerator.GetPage<AgiFormLibrary>();
                _agiformlibrary.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agiformlibrary.action = new Actions(SeleniumDriver.Instance);
                return _agiformlibrary;
            }
        }

        public static Agi_ImageLibraries Agi_ImageLibraries {
            get
            {
                _agi_imageLibraries = PageGenerator.GetPage<Agi_ImageLibraries>();
                _agi_imageLibraries.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agi_imageLibraries.action = new Actions(SeleniumDriver.Instance);
                return _agi_imageLibraries;
            }
        }

        public static Agi_PolicyLibraryPage Agi_PolicyLibraryPage
        {
            get
            {
                _agipolicylibrary = PageGenerator.GetPage<Agi_PolicyLibraryPage>();
                _agipolicylibrary.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agipolicylibrary.action = new Actions(SeleniumDriver.Instance);
                return _agipolicylibrary;
            }
        }

        public static Agi_ProposalLibrary Agi_ProposalLibrary {
            get
            {
                _agiproposallibrary = PageGenerator.GetPage<Agi_ProposalLibrary>();
                _agiproposallibrary.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agiproposallibrary.action = new Actions(SeleniumDriver.Instance);
                return _agiproposallibrary;
            }
        }

        public static Agi_ExpertiseCenter Agi_ExpertiseCenter
        {
            get
            {
                _agiexpertisecenters = PageGenerator.GetPage<Agi_ExpertiseCenter>();
                _agiexpertisecenters.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agiexpertisecenters.action = new Actions(SeleniumDriver.Instance);
                return _agiexpertisecenters;
            }
        }

        public static AgiEmergencyCommunications AgiEmergencyCommunications {
            get
            {
                _agiemergency = PageGenerator.GetPage<AgiEmergencyCommunications>();
                _agiemergency.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agiemergency.action = new Actions(SeleniumDriver.Instance);
                return _agiemergency;
            }
        }

        public static AgiAboutAbt AgiAboutAbt
        {
            get
            {
                _agiAboutabt = PageGenerator.GetPage<AgiAboutAbt>();
                _agiAboutabt.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agiAboutabt.action = new Actions(SeleniumDriver.Instance);
                return _agiAboutabt;
            }
        }

        public static AgiDepartments AgiDepartments {
            get
            {
                _agidepartments = PageGenerator.GetPage<AgiDepartments>();
                _agidepartments.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agidepartments.action = new Actions(SeleniumDriver.Instance);
                return _agidepartments;
            }
        }

        public static AgiInitiatives AgiInitiatives
        {
            get
            {
                _agi_initiatives= PageGenerator.GetPage<AgiInitiatives>();
                _agi_initiatives.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agi_initiatives.action = new Actions(SeleniumDriver.Instance);
                return _agi_initiatives;
            }
        }

        public static AgiSubsidaries AgiSubsidaries
        {
            get
            {
                _agisubsidaries = PageGenerator.GetPage<AgiSubsidaries>();
                _agisubsidaries.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agisubsidaries.action = new Actions(SeleniumDriver.Instance);
                return _agisubsidaries;
            }
        }

        public static AgiDivisions AgiDivisions
        {
            get
            {
                _agidivisions = PageGenerator.GetPage<AgiDivisions>();
                _agidivisions.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agidivisions.action = new Actions(SeleniumDriver.Instance);
                return _agidivisions;
            }
        }

        public static AgiAbtStrategy AgiAbtStrategy
        {
            get
            {
                _agiabtstrategy = PageGenerator.GetPage<AgiAbtStrategy>();
                _agiabtstrategy.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agiabtstrategy.action = new Actions(SeleniumDriver.Instance);
                return _agiabtstrategy;
            }
        }

        public static AgiAbtValues AgiAbtValues {
            get
            {
                _agiabtvalues = PageGenerator.GetPage<AgiAbtValues>();
                _agiabtvalues.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agiabtvalues.action = new Actions(SeleniumDriver.Instance);
                return _agiabtvalues;
            }
        }

        public static AgiHelpPage AgiHelpPage
        {
            get
            {
                _agihelp = PageGenerator.GetPage<AgiHelpPage>();
                _agihelp.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agihelp.action = new Actions(SeleniumDriver.Instance);
                return _agihelp;
            }
        }

        public static AgiCommunities AgiCommunities
        {
            get
            {
                _agicommunities = PageGenerator.GetPage<AgiCommunities>();
                _agicommunities.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agicommunities.action = new Actions(SeleniumDriver.Instance);
                return _agicommunities;
            }
        }

        public static AgiEAC AgiEAC {
            get
            {
                _agieac = PageGenerator.GetPage<AgiEAC>();
                _agieac.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agieac.action = new Actions(SeleniumDriver.Instance);
                return _agieac;
            }
        }

        public static AgiAnnouncements AgiAnnouncements
        {
            get
            {
                _agiannouncements = PageGenerator.GetPage<AgiAnnouncements>();
                _agiannouncements.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agiannouncements.action = new Actions(SeleniumDriver.Instance);
                return _agiannouncements;
            }
        }

        public static AgiEvents AgiEvents {
            get
            {
                _agievents = PageGenerator.GetPage<AgiEvents>();
                _agievents.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agievents.action = new Actions(SeleniumDriver.Instance);
                return _agievents;
            }
        }

        public static AgiNewsArchive AgiNewsArchive {
            get
            {
                _aginewsarchive = PageGenerator.GetPage<AgiNewsArchive>();
                _aginewsarchive.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _aginewsarchive.action = new Actions(SeleniumDriver.Instance);
                return _aginewsarchive;
            }
        }

        public static AgiProposals AgiProposals
        {
            get
            {
                _agiproposals = PageGenerator.GetPage<AgiProposals>();
                _agiproposals.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _agiproposals.action = new Actions(SeleniumDriver.Instance);
                return _agiproposals;
            }
        }

        public static SANSHomepage SANSHomepage {
            get
            {
                _sanshomepage = PageGenerator.GetPage<SANSHomepage>();
                _sanshomepage.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _sanshomepage.action = new Actions(SeleniumDriver.Instance);
                return _sanshomepage;
            }
        }

        public static ServiceNowTaskBar ServiceNowTaskBar
        {
            get
            {
                _sntaskbar = PageGenerator.GetPage<ServiceNowTaskBar>();
                _sntaskbar.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _sntaskbar.action = new Actions(SeleniumDriver.Instance);
                return _sntaskbar;
            }
        }

        public static ServiceNowIRRForm ServiceNowIRRForm
        {
            get
            {
                _servicenowIRRform = PageGenerator.GetPage<ServiceNowIRRForm>();
                _servicenowIRRform.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _servicenowIRRform.action = new Actions(SeleniumDriver.Instance);
                return _servicenowIRRform;
            }
        }

        public static ServiceNowIRRTable ServiceNowIRRTable
        {
            get
            {
                _servicenowIRRTable = PageGenerator.GetPage<ServiceNowIRRTable>();
                _servicenowIRRTable.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _servicenowIRRTable.action = new Actions(SeleniumDriver.Instance);
                return _servicenowIRRTable;
            }
        }

        public static AgiAbtLibrarySearch AgiAbtLibrarySearch
        {
            get
            {
                _AgiAbtLibrary = PageGenerator.GetPage<AgiAbtLibrarySearch>();
                _AgiAbtLibrary.wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(30));
                _AgiAbtLibrary.action = new Actions(SeleniumDriver.Instance);
                return _AgiAbtLibrary;
            }
        }
    }
}
