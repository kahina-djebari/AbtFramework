using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using AbtFramework.Utils_Classes;
using AbtFramework.Utils_Classes.SeleniumUtils;

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
            SeleniumDriver.DriverInstance.SwitchTo().Frame("header");
          
            loginbtn.Click();
                      
            StartTimer();
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
            SeleniumDriver.DriverInstance.Navigate().GoToUrl(url);
            StartTimer();
                            
                    
         
         

           

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

        public void WaitForHomePageToLoad()
        {
            wait.Until(e => StartMeeting.Displayed);
            StopTimer();
        }

        public string GetResponseTime()
        {
            return LoadTime;
        }
    }
}