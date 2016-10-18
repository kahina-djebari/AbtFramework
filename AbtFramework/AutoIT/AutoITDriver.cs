using AbtFramework.Utils_Classes;
using AutoItX3Lib;
using System;
using System.Collections.Generic;
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
                autoit.ControlSend("Microsoft Excel - " + currentWorkingDocTitle, currentWorkingDocTitle, "EXCEL71", "{DOWN}");
                Thread.Sleep(1000);
                autoit.ControlSend("Microsoft Excel - " + currentWorkingDocTitle, currentWorkingDocTitle, "EXCEL71", "Adding this line from Excel Desktop Client At: " + DateTime.Now);
                Thread.Sleep(2000);
                return true;
            }

            else
            {
                Console.WriteLine("AutoIT was unable to find the Excel document Window for editing");
                return false;
            }


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
                Thread.Sleep(1000);
                autoit.WinActivate("Internet Explorer Security");
                Thread.Sleep(2000);
                autoit.ControlClick("Internet Explorer Security", "&Allow", "1", "LEFT", 1);
                Thread.Sleep(1000);

                return true;
            }

           else
            {
                Console.WriteLine("AutoIT Was unable to open the document");
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
            autoit.ControlSend(currentWorkingDocTitle+ " - Microsoft Word", "Microsoft Word Document", "_WwG1", "Adding this line from Word Desktop Client At: " + DateTime.Now);
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

        public static void EditPowerPointFile()
        {
            OpenDocument(true);
            autoit.WinActivate(currentWorkingDocTitle+ " - Microsoft PowerPoint");
            autoit.WinWaitActive(currentWorkingDocTitle + " - Microsoft PowerPoint", "", 20);
            Thread.Sleep(2000);
            autoit.ControlClick(currentWorkingDocTitle, "", "NetUIHWND1", "LEFT", 1, 177, 76);
            Thread.Sleep(500);
            autoit.ControlSend(currentWorkingDocTitle + " - Microsoft PowerPoint", "Slide", "paneClassDC1", "Adding this line from PPT Desktop Client At: " + DateTime.Now);
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

        public static void init()
        {
            autoit = new AutoItX3();
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
           
            autoit.ControlClick(currentWorkingDocTitle + " - Microsoft Word", "", "NetUIHWND2", "LEFT", 1, 35, 20);
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
