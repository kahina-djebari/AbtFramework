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

        public static void EditExcelFile()
        {
            HandleWindowPopUp();
            autoit.WinActivate("Microsoft Excel - " + currentWorkingDocTitle.ToString());
            autoit.WinWaitActive("Microsoft Excel - " + currentWorkingDocTitle.ToString(), "", 20);
            Thread.Sleep(2000);
            autoit.ControlSend("Microsoft Excel - " + currentWorkingDocTitle.ToString(), currentWorkingDocTitle.ToString(), "EXCEL71", "{DOWN}");
            Thread.Sleep(1000);
            autoit.ControlSend("Microsoft Excel - " + currentWorkingDocTitle.ToString(), currentWorkingDocTitle.ToString(), "EXCEL71", "Adding this line from Word Desktop Client At: " + DateTime.Now);
            Thread.Sleep(2000);
            autoit.ControlClick("Microsoft Excel - " + currentWorkingDocTitle.ToString(), "", "NetUIHWND2", "LEFT", 1, 36, 20);
            Thread.Sleep(7000);
            autoit.WinClose("Microsoft Excel - " + currentWorkingDocTitle.ToString(), "");


        }

        private static void HandleWindowPopUp()
        {
            autoit = new AutoItX3();
            autoit.WinActivate("Open Document");
            autoit.WinWaitActive("Open Document", "", 3);
            Thread.Sleep(2000);
            autoit.ControlClick("Open Document", "&Edit", "1202", "LEFT", 1);
            Thread.Sleep(1000);
            autoit.ControlClick("Open Document", "OK", "1", "LEFT", 1);
            Thread.Sleep(1000);
            autoit.WinActivate("Internet Explorer Security");
            Thread.Sleep(2000);
            autoit.ControlClick("Internet Explorer Security", "&Allow", "1", "LEFT", 1);
            Thread.Sleep(1000);
        }

        public static void EditWordFile()
        {
            HandleWindowPopUp();
            autoit = new AutoItX3();
            autoit.WinActivate(currentWorkingDocTitle.ToString() + " - Microsoft Word");
            autoit.WinWaitActive(currentWorkingDocTitle.ToString() + " - Microsoft Word", "", 20);
            Thread.Sleep(2000);
            autoit.ControlSend(currentWorkingDocTitle.ToString() + " - Microsoft Word", "Microsoft Word Document", "_WwG1", "{ENTER}");
            Thread.Sleep(1000);
            autoit.ControlSend(currentWorkingDocTitle.ToString() + " - Microsoft Word", "Microsoft Word Document", "_WwG1", "{UP}");
            Thread.Sleep(1000);
            autoit.ControlSend(currentWorkingDocTitle.ToString() + " - Microsoft Word", "Microsoft Word Document", "_WwG1", "Adding this line from Word Desktop Client At: " + DateTime.Now);
            Thread.Sleep(2000);
            autoit.ControlClick(currentWorkingDocTitle.ToString() + " - Microsoft Word", "", "NetUIHWND2", "LEFT", 1, 35, 20);
            Thread.Sleep(5000);
            autoit.WinClose(currentWorkingDocTitle.ToString() + " - Microsoft Word", "");

        }


        public static void EditPowerPointFile()
        {
            HandleWindowPopUp();
            autoit = new AutoItX3();
            autoit.WinActivate(currentWorkingDocTitle.ToString() + " - Microsoft PowerPoint");
            autoit.WinWaitActive(currentWorkingDocTitle.ToString() + " - Microsoft PowerPoint", "", 20);
            Thread.Sleep(2000);
            autoit.ControlClick(currentWorkingDocTitle.ToString(), "", "NetUIHWND1", "LEFT", 1, 177, 76);
            Thread.Sleep(500);
            autoit.ControlSend(currentWorkingDocTitle.ToString() + " - Microsoft PowerPoint", "Slide", "paneClassDC1", "Adding this line from Word Desktop Client At: " + DateTime.Now);
            Thread.Sleep(2000);
            autoit.ControlClick(currentWorkingDocTitle.ToString(),"", "NetUIHWND1","LEFT",1,35,19); //Click on Save Btn
            Thread.Sleep(5000);
            autoit.WinClose("Sample AV metrics - Microsoft PowerPoint", "");                                                                                             //  autoit.ControlSend("Sample AV metrics - Microsoft PowerPoint","",)


        }
    }
}
