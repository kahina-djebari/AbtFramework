using System;
using System.Net;
using System.Net.Sockets;

namespace AbtFramework.Utils_Classes
{
    public class MyUtils
    {
        public static string GetRootSolutionPath()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string path = currentDirectory.Substring(0, currentDirectory.Length - 17);
            return path;
        }

       public static string GetLocalIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                   
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
    }
}