using System;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;
using System.Threading;
using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace abtTest.Web
{

    public class OktaApps
    {

      // [Fact(DisplayName = "Should Go to WeSpire (Test) Home Page using Okta")]
        public void Should_Go_to_WeSpire_Test_HomePage() 
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_WeSpireTestResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.WeSpireHomePage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtPages.WeSpireHomePage.isAt());
            SeleniumDriver.Close();

        }


    //    [Fact(DisplayName = "Should Go to WeSpire (Prod) Home Page using Okta")] //Goes through AGI
        public void Should_Go_to_WeSpire_Prod_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_WeSpireHomePageResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToAbtExchange();
            Assert.True(AbtPages.WeSpireHomePage.isAt());
            SeleniumDriver.Close();

        }
        //
        // [Fact(DisplayName = "Should Go to WeSpire (Production) Home Page using Simieo")]
        public void Should_Go_to_WeSpire_Production_HomePage() //Done
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_Concur_Prod_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            //TODO dont know for that this is use
          //  SeleniumDriver.RemoteInit();
            AbtPages.WeSpireHomePage.Go(WebEnvironment.ProductionEnvironment);
            Assert.True(AbtPages.WeSpireHomePage.isAt());
            SeleniumDriver.Close();
        }



       // [Fact(DisplayName = "Should Go to Ebsco (Test) Home Page")]
        public void Should_Go_to_Ebsco_Test_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_Ebsco_Test_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.EbscoHomePage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtPages.EbscoHomePage.isAt());
            //AbtPages.EbscoHomePage.GoToMyAccount();
           // Assert.True(AbtPages.EbscoMyAccountPage.IsUserLoggedIn());

        }

      //  [Fact(DisplayName = "Should Go to Ebsco Production Home Page")]
        public void Should_Go_to_Ebsco_Production_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_Concur_Prod_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.EbscoHomePage.Go(WebEnvironment.ProductionEnvironment);
            AbtPages.EbscoHomePage.GoToMyAccount();
            Assert.True(AbtPages.EbscoMyAccountPage.IsUserLoggedIn());

        }

     //   [Fact(DisplayName="Should Go To Ebsco Production Through AGI")]
        public void Should_Go_To_Ebsco_Production_Through_AGI()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_Ebsco_Prod_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_AbtResearchLibrary();
            AbtPages.AgiAbtResearch.GoToEbscoDS();
            Assert.True(AbtPages.EbscoHomePage.isAt());

        }


      // [Fact(DisplayName = "Should Go to Success Factor (Test) Home Page")]
        public void Should_Go_to_SuccessFactor_Test_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_SuccessFactors_test_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.SuccessFactorHomePage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtPages.SuccessFactorHomePage.isAt());
            SeleniumDriver.Close();
            
        }

      //  [Fact(DisplayName = "Should Go to Success Factor Production Home Page")]
        public void Should_Go_to_SuccessFactor_Production_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_Concur_Prod_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.SuccessFactorHomePage.Go(WebEnvironment.ProductionEnvironment);
            Assert.True(AbtPages.SuccessFactorHomePage.isAt());
            SeleniumDriver.Close();
        }

         //Wants to go Trough AGI???
      //  [Fact(DisplayName = "Should Go to AbtKnowledge Production Home Page")]
        public void Should_Go_to_AbtKnowledge_Production_HomePage()
        {
            //TODO refactor process
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_Concur_Prod_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            //SeleniumDriver.RemoteInitDavidsPc("ie");
            AbtPages.AbtKnowledgePage.Go();
           Assert.True(AbtPages.AbtKnowledgePage.IsUserLoggedIn());
        }


     //   [Fact(DisplayName = "Should Go to BCD Travel Portal Production Home Page")]
        public void Should_Go_to_BCD_Travel_Production_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_Concur_Prod_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.AbtTravelPage.Go();
            Assert.True(AbtPages.AbtTravelPage.isUserLoggedIn());
        }


   //  [Fact(DisplayName = "Should Go to Concur (prod) Home Page using Okta")]
        public void Should_Go_to_Concur_Testing_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_Concur_Test_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.ConcurHomePage.Go();
            Assert.True(AbtPages.ConcurHomePage.IsAt());
            SeleniumDriver.Close();

        }

      // [Fact(DisplayName = "Should Go to Concur Production Home Page ")]
        public void Should_Go_to_Concur_Production_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_Concur_Prod_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.HoverOverTools();
            AbtPages.AbtTravelPage.HoverOverAbtTravelOnline();
            AbtPages.AbtTravelPage.AbtTravelOnlineDropdown.BookOrSearchUsTravel();
            
            Assert.True(AbtPages.ConcurHomePage.isUserLoggedIn());
            SeleniumDriver.Close();

        }

   //      [Fact(DisplayName = "Should Go to Right Find (Test) Home Page")]
        public void Should_Go_to_RightFind_Test_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_RightFind_Test_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.RightFindHomePage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtPages.RightFindHomePage.IsAt());

        }

      //  [Fact(DisplayName = "Should Go to Right Find Production Home Page")]
        public void Should_Go_to_RightFind_Production_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_Concur_Prod_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
           AbtPages.RightFindHomePage.Go(WebEnvironment.ProductionEnvironment);
            Assert.True(AbtPages.RightFindHomePage.IsUserLoggedIn());
        }

      //  [Fact(DisplayName = "Should Go to OracleSteps Production Home Page")]
        public void Should_Go_to_Oracle_Production_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_Concur_Prod_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.AgiHomePage.Go();
         //   AbtPages.AgiHomePage.QuickLinks.GoTo(quickLinks.OracleSteps);
            Assert.True(AbtPages.OraclePage.isAt());

        }

      //  [Fact(DisplayName = "Should Go to Rep Cap Database Production Home Page")]
        public void Should_Go_to_RepCapDatabase_Production_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_Concur_Prod_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.ReputationalCapDBPage.Go();
            Assert.True(AbtPages.ReputationalCapDBPage.isUserLoggedIn());
        }

     //   [Fact(DisplayName = "Should Go to Rep Cap Planner Production Home Page")]
        public void Should_Go_to_RepCapPlanner_Production_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_Concur_Prod_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.RepCapPlannerPage.Go();
            Assert.True(AbtPages.RepCapPlannerPage.isUserLoggedIn());
        }

     //  [Fact(DisplayName = "Should Go to Service Now (Test) Home Page")]
        public void Should_Go_to_ServiceNow_UAT_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_ServiceNow_Test_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtPages.ServiceNowHomepage.IsAt());
        }

      // [Fact(DisplayName = "Should Go to Service Now Production Home Page")]
        public void Should_Go_to_ServiceNow_Production_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_ServiceNow_Prod_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.ProductionEnvironment);
            Assert.True(AbtPages.ServiceNowHomepage.IsAt());
        }

    //   [Fact(DisplayName = "Should Go to WebEx (Test) Home Page")]
        public void Should_Go_to_WebEx_Test_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_WebEx_TestEnv_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.WebExPage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtPages.WebExPage.isAt());

        }

      //  [Fact(DisplayName = "Should Go to WebEx Production Home Page")]
        public void Should_Go_to_WebEx_Production_HomePage()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_Concur_Prod_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.WebExPage.Go(WebEnvironment.ProductionEnvironment);
            Assert.True(AbtPages.WebExPage.isAt());
        }

      //  [Fact(DisplayName ="Should Go to Success Factor (Production) Through AGI")]
        public void Should_Go_SuccessFactor_Through_Agi()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_SuccessFactors_Prod_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToAtlas();
            Assert.True(AbtPages.SuccessFactorHomePage.isAt());
            SeleniumDriver.QuitDriverInstance();
        }

       // [Fact(DisplayName ="AGI short okta link response time")]
        public void test3()
        {
           // string url = "http://agitest.corp.abtassoc.com/";
            string url = "https://abtassociates.okta.com/home/bookmark/0oa80vg271UBRAgM00x7/2557";
            SeleniumDriver.InitBrowser("ie");
            var timer1 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            SeleniumDriver.Instance.Navigate().GoToUrl(url);
            WebDriverWait wait = new WebDriverWait(SeleniumDriver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(e=>SeleniumDriver.Instance.FindElement(By.LinkText("Home")).Displayed);
            var timer2= DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            Console.WriteLine("Response Time for link " + url + ":" + (timer2 - timer1));
        }

    //   [Fact(DisplayName ="Should Go to Right Find Production Through AGI")]
        public void Should_Go_RightFind_Prod_AGI()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_RightFindProd_Throug_AGI);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_AbtResearchLibrary();
            AbtPages.AgiAbtResearch.GoToRightFind();
            Assert.True(AbtPages.RightFindHomePage.IsAt());
        }

       //   [Fact(DisplayName ="Should Go to  AGI")]
        public void Should_Go_To_AGI()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_AGI_ResponseTime);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.AgiHomePage.Go();
            Assert.True(AbtPages.AgiHomePage.isAt());
        }



        [Fact(DisplayName ="Should Go To SANS Prod")]
        public void Should_Go_To_SANS_Prod()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.Get_SANS_Response_Time);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.InitBrowser("ie");
            AbtPages.SANSHomepage.Go();
            Assert.True(AbtPages.SANSHomepage.IsAt());
        }

    }
}
