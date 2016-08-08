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
                if (el.Text == Text)
                {
                    return true;
                }
            }
           
            return false;
            
        }

        public static IWebElement ValueForAttributeExists(this IList<IWebElement> Elements,string attribute,string value)
        {
            foreach(var el in Elements)
            {
                string name = el.GetAttribute(attribute);
                Console.WriteLine(name);
                if (el.GetAttribute(attribute).Equals(value))
                {


                    return el;
                }
            }

            return null;

        }
    }
}