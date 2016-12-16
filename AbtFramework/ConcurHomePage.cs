using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using AbtFramework.Utils_Classes;

namespace AbtFramework
{
    public class ConcurHomePage : PageModel
    {
        [FindsBy(How=How.ClassName,Using = "icon-logotype")]
        private IWebElement Logo;
        [FindsBy(How=How.CssSelector,Using = "#cnqr-profile-popup > div.cnqr-avatarred-div > div:nth-child(2) > div")]
        private IWebElement username;
        [FindsBy(How = How.Id, Using = "cnqr-profile-menu-link")]
        private IWebElement userProfile;
        [FindsBy(How=How.Id,Using = "popupdialogBtn_0")]
        private IWebElement warning;
        private static string SSOProvider = "Simieo";
        private static string portalenvironment="Production";

        public void Go()
        {

            try
            {
                StartTimer();
                if (TestCaseGenerator.CurrentTestCase.StepExist("Navigate to Url https://abtassociates.okta.com/home/concur/0oa7nf05pdDTmrMJZ0x7/615"))
                    TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Navigate to Url https://abtassociates.okta.com/home/concur/0oa7nf05pdDTmrMJZ0x7/615");

                SeleniumDriver.Instance.Navigate().GoToUrl("https://abtassociates.okta.com/home/concur/0oa7nf05pdDTmrMJZ0x7/615");
            }

            catch(Exception ex)
            {
                if (TestCaseGenerator.CurrentTestCase.StepExist("Navigate to Url https://abtassociates.okta.com/home/concur/0oa7nf05pdDTmrMJZ0x7/615"))
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Navigate to Url https://abtassociates.okta.com/home/concur/0oa7nf05pdDTmrMJZ0x7/615",ex.Message);


                throw (ex);
            }

          


            SSOProvider = "Okta";
            portalenvironment = "Test";

        }

        public bool isUserLoggedIn()
        {

            if (isAt())
            {
                userProfile.Click();

                if (username.Text.Equals("David Acuna"))
                {
                  //  Console.WriteLine("User: David Acuna succesfully logged in with "+SSOProvider);
                    return true;
                }

                
            }
            return false;
        }

        public void WaitForHomePageToLoad(string abtTravelHandle)
        {
            SeleniumDriver.Instance.SwitchTo().Window(abtTravelHandle);
            wait.Until(e => warning.Displayed);
            warning.Click();
            wait.Until(e => Logo.Displayed);
            StopTimer();

        }

        public string GetResponseTime()
        {
            return LoadTime;
        }

        private bool isAt()
        {
            try
            {
                wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("body")));
                if (Logo.Displayed)
                {
                    StopTimer();
                    if (TestCaseGenerator.CurrentTestCase.StepExist("Verify Trip Search is Displayed on Home Page"))
                    {
                        if (TestCaseGenerator.CurrentTestCase.IsResponseTimeRequired)
                        {
                            TestCaseGenerator.CurrentTestCase.SetResponseTime(timer2 - timer1);
                            TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Verify Trip Search is Displayed on Home Page");
                        }
                    }
                    Console.WriteLine("Concur (" + portalenvironment + ") Home Page Took: " + LoadTime + " to load using " + SSOProvider);
                    Console.WriteLine("</br>");
                    return true;
                }

                
            }

            catch(Exception ex)
            {
                if (TestCaseGenerator.CurrentTestCase.StepExist("Verify Trip Search is Displayed on Home Page"))
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Verify Trip Search is Displayed on Home Page", ex.Message);

                throw (ex);
            }
          

            return false;
        }

        public bool IsAt()
        {
            wait.Timeout = TimeSpan.FromSeconds(20);
            try
            {
                wait.Until(e => warning.Displayed);
                warning.Click();
            }
            catch(Exception ex)
            {
                if (TestCaseGenerator.CurrentTestCase.StepExist("Click Ok on Warning Pop Up"))
                {

                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Click Ok on Warning Pop Up",ex.Message);
                    throw ex;
                }

            }
                   
          
            if (TestCaseGenerator.CurrentTestCase.StepExist("Click Ok on Warning Pop Up"))
                TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Click Ok on Warning Pop Up");


           
            if (Logo.Displayed)
            {
               
                PrintResponseTime("Concur");
                StopTimer();
                if (TestCaseGenerator.CurrentTestCase.StepExist("Verify Trip Search is Displayed on Home Page"))
                {
                    if (TestCaseGenerator.CurrentTestCase.IsResponseTimeRequired)
                    {
                        TestCaseGenerator.CurrentTestCase.SetResponseTime(timer2 - timer1);
                        TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Verify Trip Search is Displayed on Home Page");
                    }
                }
                return true;
            }

            return false;
        }
    }
}