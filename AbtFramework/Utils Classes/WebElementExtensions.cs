using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace AbtFramework.Utils_Classes
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

        public static IWebElement SelectOption(this IWebElement element,string option)
        {
           
            return element.FindElements(By.TagName("option")).Single(e => e.Text.Equals(option));

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