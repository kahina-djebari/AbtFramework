using System;
using Microsoft.Office.Interop.Outlook;
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
                string WindowsUser= de.Properties["fullName"].Value.ToString();
           
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
