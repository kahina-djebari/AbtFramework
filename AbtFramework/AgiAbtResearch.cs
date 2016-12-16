using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace AbtFramework
{
    public class AgiAbtResearch : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Abt Research Library")]
        private IWebElement AbtResearchLink;
        [FindsBy(How=How.LinkText,Using = "Document Delivery via Copyright Clearance Center | RightFind")]
        private IWebElement RightFindLink;

        [FindsBy(How=How.LinkText,Using ="EBSCO Discovery Service")]
        private IWebElement EbscoDS;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Abt Research Library"));

            if (AbtResearchLink.Displayed)
            {
                Console.WriteLine("Abt Research Library Link Opened Succesfully");
                return true;
            }

            return false;
        }

        public string GoToRightFind()
        {

            finder = new PopupWindowFinder(SeleniumDriver.Instance);
            string  RightFindWinHandle= finder.Click(RightFindLink);
            StartTimer();
            return RightFindWinHandle;

         
            
        }

        public string GoToEbscoDS()
        {
             
             finder = new PopupWindowFinder(SeleniumDriver.Instance);
            string EbscoWinHandle= finder.Click(EbscoDS);
             StartTimer();
            return EbscoWinHandle;

           

        }
    }
}