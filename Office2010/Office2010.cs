using AbtFramework;
using AbtFramework.AutoIT;
using AbtFramework.Utils_Classes;
using System;
using Xunit;

namespace Office2010
{
   
    public class Office2010
    {
        [Fact(DisplayName = "Edit Word Document on KM Workspace")]
        public void Should_Edit_Word_Doc_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.RemoteDavidIENoNativeEvents);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.QA_ReadinessChecklist_v4);
            AutoITDriver.init();
            AutoITDriver.EditWordFile(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.SaveWordFile();
            AutoITDriver.CloseWordFile();
            SeleniumDriver.Close();
        }

        [Fact(DisplayName = "Edit PowerPoint Document on KM Workspace")]
        public void Should_Edit_PPT_Doc_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.RemoteDavidIENoNativeEvents);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.SampleAVMetrics);
            AutoITDriver.init();
            AutoITDriver.EditPowerPointFile(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.SavePPTFile();
            AutoITDriver.ClosePPTFile();
            SeleniumDriver.Close();

        }



        [Fact(DisplayName = "Edit Excel Document on KM Workspace")]
        public void Should_Edit_Excel_Doc_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.RemoteDavidIENoNativeEvents);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.ITMetrics);
            AutoITDriver.init();
            Assert.True(AutoITDriver.EditExcelFile()); //If have problem running AUtoIT remember that you need to register the dll with cmd
            Assert.True(AutoITDriver.SaveExcelFile());
            Assert.True(AutoITDriver.CloseExcelFile());
            SeleniumDriver.Close();
        }
    }
}
