using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Input;
using SikuliSharp;
using OpenQA.Selenium;
using System.Threading;

namespace AbtFramework.Sikuli
{   /// <summary>
    /// Helper class that contains all methods helpers for Sikuli.
    /// </summary>
    public class SikuliHelper
    {
        private static SikuliHelper instance;
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
            this.ClickPattern(pattern);
            session.Type(text);      

        }

        /// <summary>
        /// Return true if pattern exists in current view.
        /// </summary>
        /// <param name="pattern"></param>
        public bool IsPatternExisting(IPattern pattern)
        {
            return session.Exists(pattern);

        }

        /// <summary>
        /// Waits for pattern to be visible up to 15 secs, if not, nothing will happen
        /// </summary>
        /// <param name="pattern"></param>
        public void WaitForPattern(IPattern pattern)
        {
            try
            {
                session.Wait(pattern, 15);
            }
            catch (SikuliFindFailedException)
            {
                //nothing, just continue
            }
        }

        /// <summary>
        /// Returns an IPattern object base on path to file, if not present, 
        /// null is returned.
        /// </summary>
        /// <param name="pathToFile"></param>
        public IPattern GetPattern(string pathToFile)
        {
            try
            {
                IPattern pattern = Patterns.FromFile(pathToFile);
                session.Wait(pattern, 15);
                return pattern;
            }
            catch (SikuliFindFailedException)
            {
                Console.WriteLine("Pattern not visible");
                return null;
            }
            catch (FileLoadException)
            {
                Console.WriteLine("Img File not found in the route specify");
                return null;
            }
            catch (SikuliException e)
            {
                Console.WriteLine(e);
                return null;
            }



        }

        /// <summary>
        /// Returns PAtter or null if not present, can especify a time to wait
        /// </summary>
        /// <param name="pathToFile"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public IPattern GetPattern(string pathToFile, int time)
        {
            try
            {
                IPattern pattern = Patterns.FromFile(pathToFile);
                session.Wait(pattern, time);
                return pattern;
            }
            catch (SikuliFindFailedException)
            {
                Console.WriteLine("Pattern not visible");
                return null;
            }
            catch (FileLoadException)
            {
                Console.WriteLine("Img File not found in the route specify");
                return null;
            }
            catch (SikuliException e)
            {
                Console.WriteLine(e);
                return null;
            }
        } 
        
        public void PressEnter()
        {
            session.Type("\\n");
        }   

    }
}
