using System;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace AbtFramework
{
   public static class WebElementExtensions
    {
        public static bool ElementWithTextExists(this IList<IWebElement> Elements, String Text)
        {
            foreach(var el in Elements)
            {
                Console.WriteLine(el.Text);
                if (el.Text == Text)
                {
                    return true;
                }
            }
           
            return false;
            
        }
    }
}