using System;
using System.DirectoryServices;

namespace AbtFramework
{
    internal class SSOCrendentials
    {
        private static string _user;

        public static string CurrentUser { get {

                                
                    DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
                   return _user=de.Properties["fullName"].Value.ToString();
            } }
    }
}