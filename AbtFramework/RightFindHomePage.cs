using System;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AbtFramework
{
    public class RightFindHomePage : PageModel
    {
        [FindsBy(How=How.Id,Using = "RightHeaderToolbar")]
        private IWebElement RightHeaderToolbar;
        [FindsBy(How=How.CssSelector,Using = "#RightHeaderToolbar > div > div > div > ul > li:nth-child(1) > a > span > span > span > span.rtbText")]
        private IWebElement User;

        public void Go(WebEnvironment environment)
        {
            switch (environment)
            {
                case WebEnvironment.TestEnvironment:
                    _Environment = "Test";
                    SingleSignOnProvider = "Okta";
                  //  GoToUrl("https://rfetest.infotrieve.com/vlib/logon.aspx?clientid=11397");
                    GoToUrl("https://abtassociates.okta.com/home/abtassociatesinc_rightfindtest_1/0oa7irrou8UflAXZJ0x7/aln7irw3gcNMEvNG60x7");
                    break;
                case WebEnvironment.ProductionEnvironment:
                    _Environment = "Production";
                    SingleSignOnProvider = "Simieo";
                    GoToUrl("https://www.rightfind.com/vlib/logon.aspx?clientid=11397");
                    break;
                default:
                    break;
            }
        }

        private void GoToUrl(string url)
        {


            try
            {
                StartTimer();

                if (TestCaseGenerator.CurrentTestCase.StepExist("Navigate to Url " + url))
                    TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Navigate to Url " + url);

                SeleniumDriver.Instance.Navigate().GoToUrl(url);

            }

            catch(Exception ex)
            {
                if (TestCaseGenerator.CurrentTestCase.StepExist("Navigate to Url " + url))
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Navigate to Url " + url, ex.Message);


                throw (ex);
            }
          
           
        }

        public bool IsUserLoggedIn()
        {
            if (IsAt())
            {
                //  if (User.Text.Equals(SSOCrendentials.CurrentUser))
                if (User.Text.Equals("David Acuna"))
                {
                    //PrintSuccesfullLogin(User.Text);
                    return true;
                }
                               
            }


            return false;
        }

        public bool IsAt()
        {

            try
            {
                if (RightHeaderToolbar.Displayed)
                {
                    StopTimer();

                    if (TestCaseGenerator.CurrentTestCase.StepExist("Right Find Header is Displayed"))
                    {
                        if (TestCaseGenerator.CurrentTestCase.IsResponseTimeRequired)
                        {
                            TestCaseGenerator.CurrentTestCase.SetResponseTime(timer2 - timer1);
                            TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Right Find Header is Displayed");
                        }
                    }
                    PrintResponseTime("RightFind");

                    return true;
                }

            }

            catch(Exception ex)
            {
                if (TestCaseGenerator.CurrentTestCase.StepExist("Right Find Header is Displayed"))
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Right Find Header is Displayed",ex.Message);

                throw (ex);
            }



            return false;
        }
    }
}