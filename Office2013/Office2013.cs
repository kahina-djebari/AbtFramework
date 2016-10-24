using System;
using Xunit;
using AbtFramework;
using AbtFramework.AutoIT;
using AbtFramework.Utils_Classes;

namespace Office2013
{
    
    public class Office2013
    {
        [Fact(DisplayName = "Edit Word Document on KM Workspace with Word 2013")]
        public void Should_Edit_Word_Doc_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.RemoteQALaptop);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.QA_ReadinessChecklist_v4);
            AutoITDriver.init();
           Assert.True(AutoITDriver.EditWord2013File()); //If have problem running AUtoIT remember that you need to register the dll with cmd
           Assert.True(AutoITDriver.SaveWord2013File());
           Assert.True(AutoITDriver.CloseWord2013File());
            SeleniumDriver.Close();
        }

        [Fact(DisplayName = "Edit PowerPoint Document on KM Workspace with PowerPoint 2013")]
        public void Should_Edit_PPT_Doc_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.RemoteQALaptop);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.SampleAVMetrics);
            AutoITDriver.init();
            AutoITDriver.EditPowerPoint2013File(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.SavePPT2013File();
            AutoITDriver.ClosePPT2013File();
            SeleniumDriver.Close();

        }



        [Fact(DisplayName = "Edit Excel Document on KM Workspace with Excel 2013")]
        public void Should_Edit_Excel_Doc_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.RemoteQALaptop);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.ITMetrics);
            AutoITDriver.init();
            Assert.True(AutoITDriver.EditExcel2013File()); //If have problem running AUtoIT remember that you need to register the dll with cmd
            Assert.True(AutoITDriver.SaveExcel2013File());
            Assert.True(AutoITDriver.CloseExcel2013File());
            SeleniumDriver.Close();
        }
    }
}
