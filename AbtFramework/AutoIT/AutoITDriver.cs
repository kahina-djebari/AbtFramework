using AbtFramework.Utils_Classes;
using AutoItX3Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbtFramework.AutoIT
{
    public class AutoITDriver
    {
        public static AutoItX3 autoit;
        public static string currentWorkingDocTitle;

        public static bool EditExcelFile()
        {
            OpenDocument(true);
            autoit.WinActivate("Microsoft Excel - " + currentWorkingDocTitle);
            if((autoit.WinWaitActive("Microsoft Excel - " + currentWorkingDocTitle, "", 20)) == 1)
            {
                Thread.Sleep(2000);
                autoit.ControlSend("Microsoft Excel - " + currentWorkingDocTitle, "IT Metrics", "EXCEL71", "{DOWN}");
                Thread.Sleep(1000);
                autoit.ControlSend("Microsoft Excel - " + currentWorkingDocTitle, "IT Metrics", "EXCEL71", "Adding this line from Excel 2010 Desktop Client At: " + DateTime.Now);
                Thread.Sleep(2000);
                return true;
            }

            else
            {
                Console.WriteLine("AutoIT was unable to find the Excel document Window for editing");
                return false;
            }


        }

        public static bool EditPowerPoint2013File()
        {
            OpenDocument(true);
          
            if(autoit.WinWaitActive("Sample AV metrics - PowerPoint", "", 20) == 1)
            {
                Thread.Sleep(2000);
                autoit.ControlClick("Sample AV metrics - PowerPoint", "", "NetUIHWND1", "LEFT", 1, 182, 71);
                Thread.Sleep(500);
                autoit.ControlSend("Sample AV metrics - PowerPoint", "", "mdiClass1", "Adding this line from PPT 2013 Desktop Client At: " + DateTime.Now);
                Thread.Sleep(2000);
                return true;
            }

            else
            {
                Console.WriteLine("Unable to Find PPT doc to edit");
                return false;
            }
           
        }

        public static bool ClosePPT2013File()
        {

           if(autoit.WinClose("Sample AV metrics - PowerPoint", "") == 1)
            {
                Thread.Sleep(1000);
                return true;
            }
            else
            {
                Console.WriteLine("AutoIT was unable to close the PPT file");
                return false;
            }
        }

        public static bool SavePPT2013File()
        {
            if(autoit.ControlClick("Sample AV metrics - PowerPoint", "", "NetUIHWND1", "LEFT", 1, 46, 14)==1) //Click on Save Btn
            {
                Thread.Sleep(5000);
                return true;
            }

            else
            {
                Console.WriteLine("AutoIT was Unable To save PPT File");
                return false;
            }
                
        }

        public static bool CloseWord2013File()
        {
            if(autoit.WinClose("QA_ReadinessChecklist_v4 [Compatibility Mode] - Word", "") == 1)
            {
                Thread.Sleep(1000);
                CloseReadOnlyWordDocs();
                return true;
            }
            else
            {
                Console.WriteLine("AutoIT was unable to Close the Word Doc");
                return false;
            }
            
            
        }

        private static void KillWordProcess()
        {
            foreach (Process p in System.Diagnostics.Process.GetProcessesByName("winword"))
            {
                try
                {
                    p.Kill();
                    p.WaitForExit(); // possibly with a timeout
                }
                catch (Win32Exception winException)
                {
                    // process was terminating or can't be terminated - deal with it
                }
                catch (InvalidOperationException invalidException)
                {
                    // process has already exited - might be able to let this one go
                }
            }
        }

        public static bool SaveWord2013File()
        {
            if(autoit.ControlClick("QA_ReadinessChecklist_v4 [Compatibility Mode] - Word", "", "NetUIHWND1", "LEFT", 1, 47, 15) == 1)
            {
                Thread.Sleep(5000);
                return true;
            }
            else
            {
                Console.WriteLine("AutoIT was unable to save the Word Doc");
                return false;
            }
            
        }

        public static bool EditExcel2013File()
        {
            OpenDocument(true);
            Thread.Sleep(5000);
            CloseReadOnlyExcelDocs();

            if ((autoit.WinWaitActive("IT Metrics - Excel", "", 20)) == 1)
            {
                Thread.Sleep(2000);
                autoit.ControlSend("IT Metrics - Excel", "IT Metrics", "EXCEL71", "{DOWN}");
                Thread.Sleep(1000);
                autoit.ControlSend("IT Metrics - Excel", "IT Metrics", "EXCEL71", "Adding this line from Excel 2013 Desktop Client At: " + DateTime.Now);
                Thread.Sleep(2000);
                return true;
            }

            else
            {
                Console.WriteLine("AutoIT was unable to find the Excel document Window for editing");
                return false;
            }
        }

        private static void CloseReadOnlyExcelDocs()
        {
            
            autoit.WinWaitActive("IT Metrics  [Read-Only] - Excel", "", 5);
            autoit.WinClose("IT Metrics  [Read-Only] - Excel", "");
            autoit.WinWaitActive("IT Metrics  [Read-Only] - Excel", "", 5);
            autoit.WinClose("IT Metrics  [Read-Only] - Excel", "");
            Thread.Sleep(1000);
        }

        public static bool SaveExcel2013File()
        {
            if (autoit.ControlClick("IT Metrics - Excel", "", "NetUIHWND2", "LEFT", 1, 47, 13) == 1)
            {
                Thread.Sleep(5000);
                return true;

            }
            else
            {
                Console.WriteLine("AutoIt was unable to Save the Excel Document");
                return false;
            }
        }

        public static bool CloseExcel2013File()
        {
            if (autoit.WinClose("IT Metrics - Excel", "") == 1)
            {
                Thread.Sleep(1000);
                CloseReadOnlyExcelDocs();
                return true;
            }

            else
            {
               
                Console.WriteLine("AutoIT was unable to close the Excel document");
                return false;
            }
        }

        private static void KillExcelProcess()
        {
            foreach (Process p in System.Diagnostics.Process.GetProcessesByName("excel"))
            {
                try
                {
                    p.Kill();
                    p.WaitForExit(); // possibly with a timeout
                }
                catch (Win32Exception winException)
                {
                    // process was terminating or can't be terminated - deal with it
                }
                catch (InvalidOperationException invalidException)
                {
                    // process has already exited - might be able to let this one go
                }
            }
        }

        public static bool EditWord2013File()
        {
            OpenDocument(true);
            Thread.Sleep(5000);
            CloseReadOnlyWordDocs();//bug i dont know why it opens moren than one doc on office 2013
            if(autoit.WinWaitActive("QA_ReadinessChecklist_v4 [Compatibility Mode] - Word", "", 20) == 1)
            {
                autoit.ControlSend("QA_ReadinessChecklist_v4 [Compatibility Mode] - Word", "Microsoft Word Document", "_WwG1", "{ENTER}");
                Thread.Sleep(1000);
                autoit.ControlSend("QA_ReadinessChecklist_v4 [Compatibility Mode] - Word", "Microsoft Word Document", "_WwG1", "{UP}");
                Thread.Sleep(1000);
                autoit.ControlSend("QA_ReadinessChecklist_v4 [Compatibility Mode] - Word", "Microsoft Word Document", "_WwG1", "Adding this line from Word 2013 Desktop Client At: " + DateTime.Now);
                Thread.Sleep(2000);
                return true;
            }

            else
            {
                Console.WriteLine("AutoIT was Unable to find Microsoft Word Window to Edit Word File");
                return false;
            }
           
        }

        private static void CloseReadOnlyWordDocs()
        {
          
            autoit.WinWaitActive("QA_ReadinessChecklist_v4 [Read-Only] [Compatibility Mode] - Word", "", 5);
            autoit.WinClose("QA_ReadinessChecklist_v4 [Read-Only] [Compatibility Mode] - Word", "");
            autoit.WinWaitActive("QA_ReadinessChecklist_v4 [Read-Only] [Compatibility Mode] - Word", "", 5);
            autoit.WinClose("QA_ReadinessChecklist_v4 [Read-Only] [Compatibility Mode] - Word", "");
            Thread.Sleep(1000);

        }

        public static bool CloseExcelFile()
        {
            if(autoit.WinClose("Microsoft Excel - " + currentWorkingDocTitle, "") == 1)
            {
                return true;
            }

            else
            {
                Console.WriteLine("AutoIT was unable to close the Excel document");
                return false;
            }
        }

        public static bool SaveExcelFile()
        {
            if(autoit.ControlClick("Microsoft Excel - " + currentWorkingDocTitle, "", "NetUIHWND2", "LEFT", 1, 36, 20) == 1)
            {
                Thread.Sleep(5000);
                return true;

            }
            else
            {
                Console.WriteLine("AutoIt was unable to Save the Excel Document");
                return false;
            }
            
        }

        private static bool OpenDocument(bool openForEdit)
        {
       
            autoit.WinActivate("Open Document"); 
            autoit.WinWaitActive("Open Document", "", 3);
            Thread.Sleep(2000);
            if(openForEdit)
            autoit.ControlClick("Open Document", "&Edit", "1202", "LEFT", 1);
            Thread.Sleep(1000);
              if(autoit.ControlClick("Open Document", "OK", "1", "LEFT", 1) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        

            
        }

        public static void EditWordFile()
        {
            OpenDocument(true);
            autoit.WinActivate(currentWorkingDocTitle + " - Microsoft Word");
            autoit.WinWaitActive(currentWorkingDocTitle + " - Microsoft Word", "", 20);
            Thread.Sleep(2000);
            autoit.ControlSend(currentWorkingDocTitle + " - Microsoft Word", "Microsoft Word Document", "_WwG1", "{ENTER}");
            Thread.Sleep(1000);
            autoit.ControlSend(currentWorkingDocTitle + " - Microsoft Word", "Microsoft Word Document", "_WwG1", "{UP}");
            Thread.Sleep(1000);
            autoit.ControlSend(currentWorkingDocTitle+ " - Microsoft Word", "Microsoft Word Document", "_WwG1", "Adding this line from Word 2010 Desktop Client At: " + DateTime.Now);
            Thread.Sleep(2000);
        

        }

        public static void HoverOverAgiHomeDropdown()
        {
            autoit.WinActivate("Home - Windows Internet Explorer");
            autoit.WinWaitActive("Home - Windows Internet Explorer", "", 30);
            Thread.Sleep(3000);
            //autoit.ControlClick("Home - Windows Internet Explorer", "", "Internet Explorer_Server1", "LEFT", 1, 344, 101);
            autoit.MouseMove(350, 156);
          
        }

        public static void init()
        {
            autoit = new AutoItX3();
        }

        public static void EditPowerPointFile()
        {
            OpenDocument(true);
            autoit.WinActivate(currentWorkingDocTitle+ " - Microsoft PowerPoint");
            autoit.WinWaitActive(currentWorkingDocTitle + " - Microsoft PowerPoint", "", 20);
            Thread.Sleep(2000);
            autoit.ControlClick(currentWorkingDocTitle, "", "NetUIHWND1", "LEFT", 1, 177, 76);
            Thread.Sleep(500);
            autoit.ControlSend(currentWorkingDocTitle + " - Microsoft PowerPoint", "Slide", "paneClassDC1", "Adding this line from PPT 2010 Desktop Client At: " + DateTime.Now);
            Thread.Sleep(2000);

        }

        public static void ClosePPTFile()
        {
            autoit.WinClose("Sample AV metrics - Microsoft PowerPoint", "");
        }

        public static void SavePPTFile()
        {
            autoit.ControlClick(currentWorkingDocTitle, "", "NetUIHWND1", "LEFT", 1, 35, 19); //Click on Save Btn
            Thread.Sleep(5000);

        }

        public static void OpenDocumentForReading()
        {
            OpenDocument(false);

        }



        public static void EditWordFileFromInsideApp()
        {
           
            autoit.WinActivate(currentWorkingDocTitle + " [Read-Only] - Microsoft Word");
            autoit.WinWaitActive(currentWorkingDocTitle + " [Read-Only] - Microsoft Word","",20);
            Thread.Sleep(2000);
            autoit.ControlClick(currentWorkingDocTitle, "", "NetUIHWND2", "LEFT", 1, 511, 17); //click on edit document on word
            Thread.Sleep(1000);
            autoit.ControlSend(currentWorkingDocTitle + " - Microsoft Word", "Microsoft Word Document", "_WwG1", "{ENTER}");
            Thread.Sleep(1000);
            autoit.ControlSend(currentWorkingDocTitle + " - Microsoft Word", "Microsoft Word Document", "_WwG1", "{UP}");
            Thread.Sleep(1000);
            autoit.ControlSend(currentWorkingDocTitle + " - Microsoft Word", "Microsoft Word Document", "_WwG1", "Adding this line from Word Desktop Client At: " + DateTime.Now);
            Thread.Sleep(2000);

     

           
        }



        public static void CloseWordFile()
        {
            autoit.WinClose(currentWorkingDocTitle + " - Microsoft Word", "");
        }

        public static void SaveWordFile()
        {
           
            autoit.ControlClick(currentWorkingDocTitle + " - Microsoft Word", "", "NetUIHWND1", "LEFT", 1, 35, 19);
            Thread.Sleep(5000);
        }

        public static void EditExcelFileFromInsideApp()
        {    //Microsoft Excel -IT Metrics[Read - Only]
            // Microsoft Excel -IT Metrics[Read - Only]
     
          //  Console.WriteLine("Microsoft Excel - IT Metrics[Read - Only]");
            autoit.WinActivate("Microsoft Excel - "+currentWorkingDocTitle+"  [Read-Only]");
           if(autoit.WinWaitActive("Microsoft Excel - " + currentWorkingDocTitle + "  [Read-Only]", "", 10) == 1)
            {
                Thread.Sleep(3000);
                autoit.ControlSend("Microsoft Excel - " + currentWorkingDocTitle + "  [Read-Only]", currentWorkingDocTitle + "  [Read-Only]", "EXCEL71", "{DOWN}");
                Thread.Sleep(3000);
                autoit.ControlClick("Microsoft Excel - " + currentWorkingDocTitle + "  [Read-Only]", "", "NetUIHWND2", "LEFT", 1, 523, 16);
                Thread.Sleep(1000);
                autoit.ControlSend("Microsoft Excel - " + currentWorkingDocTitle, currentWorkingDocTitle, "EXCEL71", "Adding this line from Word Desktop Client At: " + DateTime.Now);
                Thread.Sleep(2000);
     
            }
            else
            {
                Console.WriteLine("Couldn't Open Excel Document, Can't locate Excel Window");
            }
          
        }
      //  Microsoft Excel - IT Metrics[Read - Only]


        public static void EditPPTFileFromInsideApp()
        {
            //Sample AV metrics [Read-Only] - Microsoft PowerPoint
            //Sample AV metrics [Read-Only] - Microsoft PowerPoint
            //Sample AV metrics [Read-Only] - Microsoft PowerPoint
            //Sample AV metrics [Read-Only] - Microsoft PowerPoint
            //Sample AV metrics.pptx - Microsoft PowerPoint
          
            autoit.WinActivate(currentWorkingDocTitle + " [Read-Only] - Microsoft PowerPoint");
            if(autoit.WinWaitActive(currentWorkingDocTitle + " [Read-Only] - Microsoft PowerPoint", "", 20) == 1)
            {
                Thread.Sleep(2000);
                autoit.ControlClick(currentWorkingDocTitle, "", "NetUIHWND1", "LEFT", 1, 511, 17);
                Thread.Sleep(2000);
                autoit.ControlClick(currentWorkingDocTitle, "", "NetUIHWND1", "LEFT", 1, 177, 76);
                Thread.Sleep(2000);
                autoit.ControlSend(currentWorkingDocTitle + ".pptx - Microsoft PowerPoint", "Slide", "paneClassDC1", "Adding this line from Word Desktop Client At: " + DateTime.Now);
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Couldn't Open PowerPoint Document, Can't locate PowerPoint Window");
            }
          
        }
    }
}
