using System;
using System.Collections.Generic;

namespace AbtFramework.Utils_Classes
{
    internal class HtmlRepository
    {
        private static List<string> BootstrapLines;

        internal static List<string> GetAbtHtmlHeader()
        {
            BootstrapLines = new List<string>();
            BootstrapLines.Add("<html><head><title>Test Results</title>");
            BootstrapLines.Add("<meta charset=\"utf - 8\">");
            BootstrapLines.Add("<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1\">");
            BootstrapLines.Add("<link rel=\"stylesheet\" href=\"http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\">");
            BootstrapLines.Add("<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js\"></script>");
            BootstrapLines.Add("<script src=\"http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js\"></script></head><body><div class=\"container\">");
            return BootstrapLines;

        }
    }
}