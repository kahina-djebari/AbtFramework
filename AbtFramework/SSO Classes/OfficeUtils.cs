using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Outlook;
using System.IO;

namespace AbtFramework.SSO_Classes
{
    public static class OfficeUtils
    {
       
            public static class OutlookWrapper
            {
                public static void SendLog()
                {

                    var outlookApp = new Microsoft.Office.Interop.Outlook.Application();
                    Microsoft.Office.Interop.Outlook.MailItem mailItem = outlookApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                    var watch = System.Diagnostics.Stopwatch.StartNew();

                    mailItem.Subject = "Share Drive Test " + System.DateTime.Now;
                    var user = mailItem.To = GetTesterEmail(mailItem, outlookApp);
                    // mailItem.To = userName + "@abtassoc.com";// Stephen_Darling @abtassoc.com
                    mailItem.Body = "Share Drive Performance Test Log\n" + "Tester: " + user +
                        "\n Note: Some of the Functions will go between 4 and 6 seconds faster than manual test because of the UI interactions";
                    var logPath = Environment.CurrentDirectory + @"\PerformanceTestLog.txt";
                    mailItem.Attachments.Add(logPath);//logPath is a string holding path to the log.txt file
                    mailItem.Importance = Microsoft.Office.Interop.Outlook.OlImportance.olImportanceHigh;
                    mailItem.Display(false);
                    mailItem.Send();
                    // outlookApp.Quit();
                    if (outlookApp != null)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(mailItem);
                    if (outlookApp != null)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(outlookApp);


                    GC.Collect();
                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    LogNDisplay(" Email sent To " + user, elapsedMs); // Success


                }

            public static void LogNDisplay(string action)
            {
                using (StreamWriter w = File.AppendText("PerformanceTestLog.txt"))
                {
                    Log(action, w);
                }
                using (StreamReader r = File.OpenText("PerformanceTestLog.txt"))
                {
                    DumpLog(r);
                }
            }

            private static void LogNDisplay(string action, long elapsedMs)
            {
                using (StreamWriter w = File.AppendText("PerformanceTestLog.txt"))
                {
                    Log(action, w);
                }
                using (StreamReader r = File.OpenText("PerformanceTestLog.txt"))
                {
                    DumpLog(r);
                }

            }

            private static void DumpLog(StreamReader r)
            {
                throw new NotImplementedException();
            }

            private static void Log(object action, StreamWriter w)
            {
                throw new NotImplementedException();
            }

            private static string GetTesterEmail(MailItem mailItem, Application outlook)
            {
                return outlook.ActiveExplorer().Session.CurrentUser.AddressEntry.GetExchangeUser().PrimarySmtpAddress;
            }
        }
        }
}
