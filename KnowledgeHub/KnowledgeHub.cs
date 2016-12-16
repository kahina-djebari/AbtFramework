using System;
using AbtFramework;
using AbtFramework.AutoIT;
using AbtFramework.Utils_Classes;
using Xunit;

namespace KnowledgeHub
{
 
    public class KnowledgeHub
    {
        
       [Fact(DisplayName = "is the Knowledge Hub Available?")]
        public void Initial_Test_For_Knowledge_Hub()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.KnowledgeHubLandingPage.Go();
            AbtPages.KnowledgeHubLandingPage.AttemptToLogin();
            //validates if we have reached the knowledge hub or not.
            Assert.True(AbtPages.KnowledgeHubLandingPage.isAt());
            SeleniumDriver.Close();
        }

        [Fact(DisplayName = "Can i edit Documments in the Knowledge Hub?")]
        public void Edit_Docs_In_The_Knowledge_Hub()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.KnowledgeHubLandingPage.Go();
            AbtPages.KnowledgeHubLandingPage.AttemptToLogin();
            //Open documents online.
            AbtPages.SharePointDocumentNavigation.OpenDocumentOnline(MS2013documents.KnowledgeHub, documentType.Word);
            AbtPages.WordOnlinePage.Edit(); 
            SeleniumDriver.Quit();
        }

    }
}
