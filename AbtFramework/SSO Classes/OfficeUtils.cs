using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Outlook;
using System.IO;
using System.DirectoryServices;

namespace AbtFramework.SSO_Classes
{
    public static class OfficeUtils
    {
       
        public static class OutlookWrapper
        {
            private static Application outlook;

        
            public static bool isLoggedIn()
            {
                String OutlookUser = outlook.Application.Session.CurrentUser.Name;
                DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
                String WindowsUser= de.Properties["fullName"].Value.ToString();
                Console.WriteLine(OutlookUser);
                Console.WriteLine(WindowsUser);
                if (OutlookUser == WindowsUser)
                {
                    return true;
                }
               

                return false;
            }

            public static void init()
            {
                outlook = new Microsoft.Office.Interop.Outlook.Application();

            }

          
        }
        }
}
