using AbtFramework;
using AbtFramework.Enums;
using System;
using System.Globalization;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace abtTest.Steps
{
    [Binding]
    public class AGISteps
    {
        private string OracleWinHandle;
        private string PersonalLinkHandle;
        private Insight InsightInfo;
        private string AboutAbtFileWinHandle;

        [When(@"I Hover over Quick Links")]
        public void WhenIHoverOverQuickLinks()
        {
            AbtPages.AgiHomePage.HoverOverQuickLinks();
        }
        
        [When(@"I Click on Oracle")]
        public void WhenIClickOnOracle()
        {
           OracleWinHandle= AbtPages.AgiHomePage.QuickLinks.OpenOracle();
        }
        
        [Then(@"The Oracle Home Page Should Load Succesfully")]
        public void ThenTheOracleHomePageShouldLoadSuccesfully()
        {
           // Assert.True(AbtPages.OraclePage.isAt());
        }

        [When(@"I Click on Staff Directory")]
        public void WhenIClickOnStaffDirectory()
        {
            AbtPages.AgiHomePage.QuickLinks.OpenStaffDirectory();
        }

        [Then(@"I should be redirected to a page where you can Search the Staff people")]
        public void ThenIShouldBeRedirectedToAPageWhereYouCanSearchTheStaffPeople()
        {
            Assert.True(AbtPages.StaffDirectoryPage.isAt());
        }

        [When(@"I Click on Forms Library")]
        public void WhenIClickOnFormsLibrary()
        {
            AbtPages.AgiHomePage.QuickLinks.OpenFormsLibrary();
        }

        [Then(@"I should be redirected to the AbtForms Library Page")]
        public void ThenIShouldBeRedirectedToTheAbtFormsLibraryPage()
        {
            Assert.True(AbtPages.FormsLibraryPage.isAt());
        }

        [When(@"I Click on Customize")]
        public void WhenIClickOnCustomize()
        {
            AbtPages.AgiHomePage.QuickLinks.OpenCustomizeLink();
        }

        [Then(@"I should be redirected to the Personal Links Page")]
        public void ThenIShouldBeRedirectedToThePersonalLinksPage()
        {
            Assert.True(AbtPages.CustomizeLinksPage.isAt());
        }

        [When(@"I Click on ""(.*)"" to Open an insight")]
        public void WhenIClickOnToOpenAnInsight(string p0)
        {
            InsightInfo = AbtPages.AgiHomePage.OpenTodaysInsight();
        }

        [Then(@"The detailed page about the insight should load")]
        public void ThenTheDetailedPageAboutTheInsightShouldLoad()
        {
            Assert.Equal(InsightInfo.Author, "by "+AbtPages.TodayILearnedPage.Author);
            Assert.Equal(InsightInfo.Title.ToUpper(), AbtPages.TodayILearnedPage.WelcomeTitle);

        }

        [When(@"I Click on ""(.*)"" under the Abt Events Section")]
        public void WhenIClickOnUnderTheAbtEventsSection(string p0)
        {
            AbtPages.AgiHomePage.OpenAbtEvents();
        }

        [Then(@"The Abt Events Calendar should display")]
        public void ThenTheAbtEventsCalendarShouldDisplay()
        {
            var Today = DateTime.Now;
            Assert.Equal(Today.ToString("MMMM", CultureInfo.InvariantCulture) + " " + Today.Year, AbtPages.AgiEvents.EventCalendarCurrentMonth);
        }

        //[When(@"I Hover over ""(.*)"" on the Mega Menu")]
        //public void WhenIHoverOverOnTheMegaMenu(string onItem)
        //{
        //    switch (onItem)
        //    {
        //        case "Tools & Resources":
        //            AbtPages.AgiTopNavigation.HoverOverTools();
        //            break;

        //        case "Home":
        //            AbtPages.AgiTopNavigation.HoverOverHome();
        //            break;
        //        default:
        //            break;
        //    }
        //}

        [When(@"I click on About Abt")]
        public void WhenIClickOnAboutAbt()
        {
            AbtPages.AgiTopNavigation.HomeDropdown.OpenAboutAbt();
        }

        [Then(@"The About Abt page Should display")]
        public void ThenTheAboutAbtPageShouldDisplay()
        {
            Assert.True(AbtPages.AgiAboutAbt.IsAt());
        }

        [Given(@"I have navigated to the ""(.*)"" page on AGI")]
        public void GivenIHaveNavigatedToTheOnAGI(string page)
        {
            switch (page)
            {
                case "About Abt":
                    AbtPages.AgiAboutAbt.Go();
                    break;
                default:
                    break;
            }
        }

        [When(@"I Click on ""(.*)"" on the Left panel")]
        [Then(@"If I Click on ""(.*)"" on the Left panel")]
        public void ThenIfIClickOnOnTheLeftPanel(string onItem)
        {
            switch (onItem)
            {
                case "We Are Abt":
                    AbtPages.AgiAboutAbt.OpenWeAreAbt();
                    Thread.Sleep(1000);
                    break;
                case "Elevator Speech":

                    AbtPages.AgiAboutAbt.OpenElevatorSpeech();
                    Thread.Sleep(1000);
                    break;
                case "Management Advisory Group":
                    AbtPages.AgiAboutAbt.OpenMGA();
                    Thread.Sleep(1000);
                    break;
                case "Office Locations":
                    AbtPages.AgiAboutAbt.OpenOfficeLocations();
                    Thread.Sleep(1000);
                    break;
                case "Bethesda":
                    AbtPages.AgiAboutAbt.OpenBethesda();
                    Thread.Sleep(1000);
                    break;
                case "Cambridge":
                    AbtPages.AgiAboutAbt.OpenCambridge();
                    Thread.Sleep(1000);
                    break;
                case "Abt Cafe at Cambridge":
                    AbtPages.AgiAboutAbt.OpenCambridgeCafe();
                    Thread.Sleep(1000);
                    break;
                case "Abt Cambridge Softball":
                    AbtPages.AgiAboutAbt.OpenCambridgeSoftball();
                    Thread.Sleep(1000);
                    break;
                case "Cambridge Shuttle Schedule":
                    AbtPages.AgiAboutAbt.OpenCambridgeShuttle();
                    Thread.Sleep(1000);
                    break;
                case "Durham":
                    AbtPages.AgiAboutAbt.OpenDurham();
                    Thread.Sleep(1000);
                    break;
                case "History":
                    AbtPages.AgiAboutAbt.OpenHistory();
                    Thread.Sleep(1000);
                    break;
                default:
                    break;
            }
        }

        [Then(@"The ""(.*)"" section should display")]
        public void ThenTheSectionShouldDisplay(string section)
        {
            switch (section)
            {
                case "We Are Abt":
                    Thread.Sleep(1000);
                    Assert.True(AbtPages.AgiAboutAbt.IsWeAreAbtSectionOpen);
                    break;
                case "Elevator Speech":
                    Thread.Sleep(1000);
                    Assert.True(AbtPages.AgiAboutAbt.IsElevatorSpeechSectionOpen);
                    break;
                case "Management Advisory Group":
                    Thread.Sleep(1000);
                    Assert.True(AbtPages.AgiAboutAbt.IsMGASectionOpen);
                    break;
                case "Office Locations":
                    Thread.Sleep(1000);
                    Assert.True(AbtPages.AgiAboutAbt.IsOfficeLocationsSectionOpen);
                    break;
                case "Bethesda":
                    Thread.Sleep(1000);
                    Assert.True(AbtPages.AgiAboutAbt.IsBethesdaSectionOpen);
                    break;
                case "Cambridge":
                    Thread.Sleep(1000);
                    Assert.True(AbtPages.AgiAboutAbt.IsCambridgeSectionOpen);
                    break;
                case "Abt Cafe at Cambridge":
                    Thread.Sleep(1000);
                    Assert.True(AbtPages.AgiAboutAbt.IsCambridgeCafeSectionOpen);
                    break;
                case "Abt Cambridge Softball":
                    Thread.Sleep(1000);
                    Assert.True(AbtPages.AgiAboutAbt.IsCambridgeSoftballSectionOpen);
                    break;
                case "Cambridge Shuttle Schedule":
                    Thread.Sleep(1000);
                    Assert.True(AbtPages.AgiAboutAbt.IsCambridgeShuttleSectionOpen);
                    break;
                case "Durham":
                    Thread.Sleep(1000);
                    Assert.True(AbtPages.AgiAboutAbt.IsDurhamSectionOpen);
                    break;
                case "History":
                    Thread.Sleep(1000);
                    Assert.True(AbtPages.AgiAboutAbt.IsHistorySectionOpen);
                    break;
                default:
                    break;
            }
        }
        [Then(@"The breadcrumbs on the page should display the path to ""(.*)""")]
        public void ThenTheBreadcrumbsOnThePageShouldDisplayThePathTo(string page)
        {
            switch (page)
            {
                case "We Are Abt":
                    Assert.Equal("Home->About Abt->We Are Abt",
                        AbtPages.AgiAboutAbt.CurrentBreadCrumbsPath);
                    break;
                case "Elevator Speech":
                    Assert.Equal("Home->About Abt->Elevator Speech",
                       AbtPages.AgiAboutAbt.CurrentBreadCrumbsPath);
                    break;
                case "Management Advisory Group":
                    Assert.Equal("Home->About Abt->Management Advisory Group (MAG)",
                      AbtPages.AgiAboutAbt.CurrentBreadCrumbsPath);
                    break;
                case "Office Locations":
                    Assert.Equal("Home->About Abt->Office Locations",
                     AbtPages.AgiAboutAbt.CurrentBreadCrumbsPath);
                    break;
                case "Bethesda":
                    Assert.Equal("Home->About Abt->Bethesda",
                       AbtPages.AgiAboutAbt.CurrentBreadCrumbsPath);
                    break;
                case "Cambridge":
                    Assert.Equal("Home->About Abt->Cambridge->Cambridge",
                        AbtPages.AgiAboutAbt.CurrentBreadCrumbsPath);
                    break;
                case "Abt Cafe at Cambridge":
                    Assert.Equal("Home->About Abt->Cambridge->Abt Café at Cambridge",
                      AbtPages.AgiAboutAbt.CurrentBreadCrumbsPath);
                    break;
                case "Abt Cambridge Softball":
                    Assert.Equal("Home->About Abt->Cambridge->Abt Cambridge Softball",
                      AbtPages.AgiAboutAbt.CurrentBreadCrumbsPath);
                    break;
                case "Cambridge Shuttle Schedule":
                    Assert.Equal("Home->About Abt->Cambridge->Cambridge Shuttle Schedule",
                     AbtPages.AgiAboutAbt.CurrentBreadCrumbsPath);
                    break;
                case "Durham":
                    Assert.Equal("Home->About Abt->Durham",
                      AbtPages.AgiAboutAbt.CurrentBreadCrumbsPath);
                    break;
                case "History":
                    Assert.Equal("Home->About Abt->History->History",
                       AbtPages.AgiAboutAbt.CurrentBreadCrumbsPath);
                    break;
                default:
                    break;
            }
        }
        
    
        [Then(@"The file ""(.*)"" should open properly")]
        public void ThenTheFileShouldOpenProperly(string file)
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I try to Open the file ""(.*)""")]
        [Then(@"If I try to open the file ""(.*)""")]
        public void ThenIfITryToOpenTheFile(string file)
        {
            switch (file)
            {
                case "Company-Organization-Chart":
                 AboutAbtFileWinHandle=  AbtPages.AgiAboutAbt.OpenFile(aboutAbtFiles.CompanyChart);
                    break;

                case "Abt Annual Review 2016":
                    AboutAbtFileWinHandle = AbtPages.AgiAboutAbt.OpenFile(aboutAbtFiles.AbtAnualReview2016);
                    break;
                case "Abt Annual Review 2015":
                    AboutAbtFileWinHandle = AbtPages.AgiAboutAbt.OpenFile(aboutAbtFiles.AbtAnualReview2015);
                    break;
                case "Abt Annual Review 2014":
                    AboutAbtFileWinHandle = AbtPages.AgiAboutAbt.OpenFile(aboutAbtFiles.AbtAnualReview2014);
                    break;
                case "Abt Annual Review 2013":
                    AboutAbtFileWinHandle = AbtPages.AgiAboutAbt.OpenFile(aboutAbtFiles.AbtAnualReview2013);
                    break;
                case "Abt Annual Review 2012":
                    AboutAbtFileWinHandle = AbtPages.AgiAboutAbt.OpenFile(aboutAbtFiles.AbtAnualReview2012);
                    break;
                default:
                    break;
            }
        }



    }
}
