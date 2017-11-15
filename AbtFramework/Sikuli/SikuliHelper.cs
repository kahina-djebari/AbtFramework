using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SikuliSharp;


namespace AbtFramework.Sikuli
{   /// <summary>
    /// Helper class that contains all methods helpers for Sikuli.
    /// </summary>
    public class SikuliHelper
    {
        private static SikuliHelper instance = null;
        private static ISikuliSession session;

        private SikuliHelper()
        {

            //no instnce directly
        }

        /// <summary>
        /// Singelton pattern for one instance of Sikuli.
        /// Inits Sikuli session on the current object.
        /// </summary>
        /// <returns></returns>
        public static SikuliHelper GetInstance()
        {
            if (instance == null)
            {
                instance = new SikuliHelper();
                session = SikuliSharp.Sikuli.CreateSession();
            }

            return instance;
        }
        /// <summary>
        /// Clicks on a pattern. Default time is to 
        /// wait for ever.
        /// </summary>
        /// <param name="pattern"></param>
        public void ClickPattern(IPattern pattern)
        {
            session.Click(pattern);
        }

        /// <summary>
        /// Set value on the input text box specified
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="text"></param>
        public void SetInputValue(IPattern pattern, string text)

        {
            session.Click(pattern);
            session.Type(text);

        }



    }
}
