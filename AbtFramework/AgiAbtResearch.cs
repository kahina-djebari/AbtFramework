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

        public void GoToRightFind()
        {
            try
            {
                popupWindowHandle = SeleniumDriver.Instance.CurrentWindowHandle;
                RightFindLink.Click();
                StartTimer();
                if (TestCaseGenerator.CurrentTestCase.StepExist("Click on Document Delivery via Copyright Clearance Center | RightFind"))
                {
                    TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Click on Document Delivery via Copyright Clearance Center | RightFind");
                }

            }

            catch(Exception ex)
            {
                if (TestCaseGenerator.CurrentTestCase.StepExist("Click on Document Delivery via Copyright Clearance Center | RightFind"))
                {
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Click on Document Delivery via Copyright Clearance Center | RightFind",ex.Message);
                }

                throw (ex);
            }
            var handles = SeleniumDriver.Instance.WindowHandles;
            SeleniumDriver.Close();
            var switchtohandle = "";
            foreach(var handle in handles)
            {
                if (popupWindowHandle != handle)
                {
                     switchtohandle = handle;
                }
            }
            SeleniumDriver.Instance.SwitchTo().Window(switchtohandle);
           
        }

        public void GoToEbscoDS()
        {
             try
             {
             finder = new PopupWindowFinder(SeleniumDriver.Instance);
            popupWindowHandle = finder.Click(SeleniumDriver.Instance.FindElement(By.LinkText("EBSCO Discovery Service")));
            
                StartTimer();
                if (TestCaseGenerator.CurrentTestCase.StepExist("Click on EBSCO Discovery Service"))
                {
                    TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Click on EBSCO Discovery Service");

                }

                SeleniumDriver.Close();
                SeleniumDriver.Instance.SwitchTo().Window(popupWindowHandle);
                
                    
            }

           catch(Exception ex)
           {
                if (TestCaseGenerator.CurrentTestCase.StepExist("Click on EBSCO Discovery Service"))
               {
                  TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Click on EBSCO Discovery Service",ex.Message);
               }

              throw (ex);
           }


        }
    }
}