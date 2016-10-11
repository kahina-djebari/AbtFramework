using System;

namespace AbtFramework.Utils_Classes
{
    internal class MyUtils
    {
        internal static string GetRootSolutionPath()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string path = currentDirectory.Substring(0, currentDirectory.Length - 17);
            return path;
        }
    }
}