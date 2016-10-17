using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using AbtFramework.Utils_Classes;

namespace AbtFramework
{
    public class WebExPage : PageModel
    {
        [FindsBy(How=How.Id,Using = "wcc-lnk-loginLink")]
        private IWebElement loginbtn;
        [FindsBy(How=How.CssSelector,Using = "#screen2_h1")]
        private IWebElement userFirstName;
        [FindsBy(How=How.Id,Using = "btn_join_room")]
        private IWebElement StartMeeting;

      

        public void Login()
        {
           // SeleniumDriver.seleniumdriver.SwitchTo().Frame("header");
            loginbtn.Click();
        }

        public void Go(WebEnvironment link)
        {
            switch (link)
            {
                case WebEnvironment.TestEnvironment:
                   GoToUrl("https://abtassoc-test.webex.com");
                    Console.WriteLine("WebEx Test HomePage took: "+LoadTime+" to load using okta");
                   
                    break;
                case WebEnvironment.ProductionEnvironment:
                    GoToUrl("https://abtassociates.webex.com");
                    Console.WriteLine("WebEx Production HomePage took: " + LoadTime+"to load using simieo");
                    break;
                default:
                    break;
            }

        }

        private void GoToUrl(string url)
        {
            try
            {
                if (TestCaseGenerator.CurrentTestCase.StepExist("Navigate to Url " + url))
                    TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Navigate to Url " + url);
                
                SeleniumDriver.Instance.Navigate().GoToUrl(url);
              
            }
           
            catch(Exception ex)
            {
                if (TestCaseGenerator.CurrentTestCase.StepExist("Navigate to Url " + url))
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Navigate to Url " + url,ex.Message);

                throw (ex);
            }


            try
            {
                SeleniumDriver.Instance.SwitchTo().Frame("header");
                SeleniumDriver.Instance.FindElement(By.Id("wcc-lnk-loginLink")).Click();
                StartTimer();
                Console.WriteLine("StartTimer="+timer1);
                if (TestCaseGenerator.CurrentTestCase.StepExist("Click on Log In"))
                    TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Click on Log In");


            }

            catch(Exception ex)
            {

                if (TestCaseGenerator.CurrentTestCase.StepExist("Click on Log In"))
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Click on Log In",ex.Message);

                throw (ex);

            }

           

        }

        public bool isUserLoggedIn()
        {
            if (isAt())
            {
               
                if (userFirstName.Text.Split(',')[1].Substring(1,5).Equals(SSOCrendentials.CurrentUser.Split(' ')[0]))
                {
                    return true;
                }
            }

            return false;
        }

        public bool isAt()
        {
            try
            {
                wait.Until(e => StartMeeting.Displayed);
                StopTimer();
                if (TestCaseGenerator.CurrentTestCase.StepExist("Check if Start Meeting is Displayed"))
                {
                    if (TestCaseGenerator.CurrentTestCase.IsResponseTimeRequired)
                    {
                        Console.WriteLine("is at startmeeting:" + (timer2 - timer1));
                        TestCaseGenerator.CurrentTestCase.SetResponseTime(timer2 - timer1);
                        TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Check if Start Meeting is Displayed");
                    }
                }
                 

               
                   

            }

            catch(Exception ex)
            {
                if (TestCaseGenerator.CurrentTestCase.StepExist("Check if Start Meeting is Displayed"))
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Check if Start Meeting is Displayed",ex.Message);

                throw (ex);
            }
            return true;

        }
    }
}