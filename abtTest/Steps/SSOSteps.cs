using AbtFramework;
using AbtFramework.Utils_Classes;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace abtTest.Steps
{
    [Binding]
    public class SSOSteps
    {
        private string AbtTravelHandle;
        private string AbtXchangeHandle;
        private string EbscoWinHandle;
        private string RightFindWinHandle;
        private string AtlasWinHandle;

        [AfterScenario]
        public void CleanUp()
        {
            SeleniumDriver.Quit();
        }
        [Given(@"I have navigated to AGI Home Page")]
        public void GivenIHaveNavigatedToAGIHomePage()
        {
            AbtPages.AgiHomePage.Go();
        }
        [Given(@"I have navigated to AGI-Tools&Resources")]
        public void GivenIHaveNavigatedToAGI_ToolsResources()
        {
            AbtPages.AgiHomePage.GoToToolsNResources();
        }

        [When(@"The Home page completes loading")]
        public void WhenTheHomePageCompletesLoading()
        {
            AbtPages.AgiHomePage.WaitForHomeToLoad();
        }
        
        [Then(@"I Should be able to calculate what the response time is")]
        public void ThenIShouldBeAbleToCalculateWhatTheResponseTimeIs()
        {
            Assert.NotNull(AbtPages.AgiHomePage.GetResponseTime());
            Console.WriteLine(AbtPages.AgiHomePage.GetResponseTime());
        }



      
        [Given(@"I Click on AbtXchange")]
        public void WhenIClickOnAbtXchange()
        {
            AbtPages.AgiHomePage.goToAbtXchange();
            AbtPages.WeSpireHomePage.WaitForHomePageToLoad(AbtXchangeHandle);
        }

        [Given(@"I wait for the AbtXchange Home Page to load")]
        public void WhenIWaitForTheAbtXchangeOnlineBookingHomePageToLoad()
        {
            AbtPages.WeSpireHomePage.WaitForHomePageToLoad(AbtXchangeHandle);
        }

        [Then(@"I Should be able to calculate what the AbtXchange Home Page response time is")]
        public void ThenIShouldBeAbleToCalculateWhatTheAbtXchangeHomePageResponseTimeIs()
        {
            Assert.NotNull(AbtPages.WeSpireHomePage.GetResponseTime());
            Console.WriteLine(AbtPages.WeSpireHomePage.GetResponseTime());
        }

        [Given(@"I Click on Abt Research Library")]
        public void WhenIClickOnAbtResearchLibrary()
        {
            AbtPages.AgiTopNavigation.ToolsDropdown.OpenAbtResearchLibrary();
        }

        [Given(@"I Click on Oracle")]
        public void GivenIClickOnOracle()
        {
            AbtPages.AgiTopNavigation.ToolsDropdown.OracleLink();
        }


        [Given(@"I Click on Ebsco Discovery Service")]
        public void WhenIClickOnEbscoDiscoveryService()
        {
            EbscoWinHandle = AbtPages.AgiAbtResearch.GoToEbscoDS();
        }

        [Given(@"I wait for the Ebsco Home Page to load")]
        public void WhenIWaitForTheEbscoHomePageToLoad()
        {
            AbtPages.EbscoHomePage.WaitForHomePageToLoad(EbscoWinHandle);
        }

        [Then(@"I should be able to calculate what the Ebsco Home Page response time is")]
        public void ThenIShouldBeAbleToCalculateWhatTheEbscoHomePageResponseTimeIs()
        {
            string ResponseTime = AbtPages.EbscoHomePage.GetResponseTime();
           Assert.NotNull(ResponseTime);
            Console.WriteLine(ResponseTime);
        }

        [Given(@"I navigate to RightFind Home Page")]
        public void WhenINavigateToRightFindHomePage()
        {
            AbtPages.RightFindHomePage.Go(WebEnvironment.ProductionEnvironment);
        }


        [Given(@"I have navigated to AGI Abt Search Library Web Page")]
        public void GivenIHaveNavigatedToAGIAbtSearchLibraryWebPage()
        {
            AbtPages.AgiHomePage.Go();
           // AbtPages.AgiAbtLibrarySearch.Go();
        }

        [Given(@"I Click on the RightFind Link Named Document Delivery via Copyright Clearance Center | RightFind")]
        public void WhenIClickOnTheRightFindLink()
        {
            RightFindWinHandle = AbtPages.AgiAbtResearch.GoToRightFind();
        }

        [Given(@"I wait for the RightFind Home Page to load")]
        public void WhenIWaitForTheRightFindHomePageToLoad()
        {
            AbtPages.RightFindHomePage.WaitForHomePageToLoad(RightFindWinHandle);
        }

        [Then(@"I should be able to calculate what the RightFind Home Page response time is")]
        public void ThenIShouldBeAbleToCalculateWhatTheRightFindHomePageResponseTimeIs()
        {
            string ResponseTime = AbtPages.RightFindHomePage.GetResponseTime();
            Assert.NotNull(ResponseTime);
            Console.WriteLine(ResponseTime);
        }

        [When(@"I navigate to WebEx Home Page")]
        public void WhenINavigateToWebExHomePage()
        {
            AbtPages.WebExPage.Go(WebEnvironment.ProductionEnvironment);
        }

        [When(@"I Click Log In")]
        public void WhenIClickLogIn()
        {
            AbtPages.WebExPage.Login();
        }

        [Given(@"I have Open IE")]
        public void GivenIHaveOpenIE()
        {
            SeleniumDriver.init(Browser.Chrome);

        }


        [When(@"I wait For the WebEx Home page to load")]
        public void WhenIWaitForTheWebExHomePageToLoad()
        {
            AbtPages.WebExPage.WaitForHomePageToLoad();
        }

        [Then(@"I Should be able to calculate what the WebEx home page response time is")]
        public void ThenIShouldBeAbleToCalculateWhatTheWebExHomePageResponseTimeIs()
        {
            string ResponseTime = AbtPages.WebExPage.GetResponseTime();
            Assert.NotNull(ResponseTime);
            Console.WriteLine(ResponseTime);
       
        }


        [When(@"I navigate to ServiceNow Home Page")]
        public void WhenINavigateToServiceNowHomePage()
        {
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.ProductionEnvironment);

        }

        [When(@"I wait for the ServiceNow Home page to load")]
        public void WhenIWaitForTheServiceNowHomePageToLoad()
        {
            AbtPages.ServiceNowHomepage.WaitForHomePageToLoad();
        }

        [Then(@"I Should be able to calculate what the ServiceNow Home Page response time is")]
        public void ThenIShouldBeAbleToCalculateWhatTheServiceNowHomePageResponseTimeIs()
        {
            string ResponseTime = AbtPages.ServiceNowHomepage.GetResponseTime();
            Assert.NotNull(ResponseTime);
            Console.WriteLine(ResponseTime);
          
            
        }

        [Given(@"I Click on Abt Talent, Learning and Support \(ATLAS\)")]
        public void WhenIClickOnAbtTalentLearningAndSupportATLAS()
        {
          AtlasWinHandle= AbtPages.AgiTopNavigation.ToolsDropdown.OpenSuccessFactors();
        }

        [Given(@"I wait for the SuccessFactor Home Page to load")]
        public void WhenIWaitForTheSuccessFactorHomePageToLoad()
        {
            AbtPages.SuccessFactorHomePage.WaitForHomePageToLoad(AtlasWinHandle);
        }

        [Then(@"I Should be able to calculate what the SuccessFactor Home Page response time is")]
        public void ThenIShouldBeAbleToCalculateWhatTheSuccessFactorHomePageResponseTimeIs()
        {
            Assert.NotNull(AbtPages.SuccessFactorHomePage.GetResponseTime());
            Console.WriteLine(AbtPages.SuccessFactorHomePage.GetResponseTime());
        }

        [Given(@"I Click on AbtTravel Online Booking")]
        public void WhenIClickOnAbtTravelOnlineBooking()
        {
           AbtPages.AgiHomePage.WaitForAbtTravelToLoad();
        }

        [Given(@"I wait for the AbtTravel Online Booking Home Page to load")]
        public void WhenIWaitForTheAbtTravelOnlineBookingHomePageToLoad()
        {
            AbtPages.ConcurHomePage.WaitForHomePageToLoad();
        }

        [Then(@"I Should be able to calculate what the AbtTravel Home Page response time is")]
        public void ThenIShouldBeAbleToCalculateWhatTheAbtTravelHomePageResponseTimeIs()
        {
            Assert.NotNull(AbtPages.ConcurHomePage.GetResponseTime());
            Console.WriteLine(AbtPages.ConcurHomePage.GetResponseTime());
        }


    }
}
