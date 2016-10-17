using System;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Drawing.Imaging;

namespace AbtFramework
{
    public class EbscoHomePage : PageModel
    {
        [FindsBy(How=How.LinkText,Using = "EDS")]
        private IWebElement EDSLink;
        [FindsBy(How=How.Id,Using = "SearchTerm1")]
        private IWebElement HomeSearchBar;
        [FindsBy(How=How.LinkText,Using ="Update My Account")]
        private IWebElement UpdateMyAccountLink;

        //ctl00_ctl00_MainContentArea_MainContentArea_EmailAddressTBox
        public void Go(WebEnvironment link)
        {
            switch (link)
            {
                case WebEnvironment.TestEnvironment:
                     GoToUrl("https://search.ebscohost.com/login.aspx?authtype=sso&custid=aspengreg&profile=eds");
                   // GoToUrl("https://abtassociates.okta.com/home/abtassociatesinc_ebsco_1/0oa6yt0cwiVmFJzGB0x7/aln6yt83icACOfcNZ0x7");
                    SingleSignOnProvider = "Okta";
                    _Environment = "Test";
                   
                    break;
                case WebEnvironment.ProductionEnvironment:
                    GoToUrl("http://search.ebscohost.com/login.aspx?authtype=sso&custid=s1139472&profile=eds");
                    SingleSignOnProvider = "Simieo";
                    _Environment = "Production";
                   
                    break;
                default:
                    break;
            }
        }

        private void GoToUrl(string url)
        {
            

            try
            {
                Console.WriteLine("Before navigate to url:"+DateTime.Now);
                StartTimer();
                if (TestCaseGenerator.CurrentTestCase.StepExist("Navigate to Url " + url))
                {
                    TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Navigate to Url " + url);
                }
                SeleniumDriver.Instance.Navigate().GoToUrl(url);
               
                Console.WriteLine("After navigate to url:" + DateTime.Now);
               // TakeScreenshot();
               // Console.WriteLine("After screen shot:" + DateTime.Now);
                                              
                wait.Until(e => e.Title.Equals("Basic Search: Discovery Service for Abt Associates"));
                Console.WriteLine("after title is ebsco:" + DateTime.Now);
                
            }
            catch(Exception ex)
            {
               if(TestCaseGenerator.CurrentTestCase.StepExist("Navigate to Url " + url)){
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Navigate to Url " + url,ex.Message);
                }

                throw (ex);
            }
           
           
        }

        private void TakeScreenshot()
        {
            Screenshot ss = ((ITakesScreenshot)SeleniumDriver.Instance).GetScreenshot();

            //Use it as you want now
            string screenshot = ss.AsBase64EncodedString;
            byte[] screenshotAsByteArray = ss.AsByteArray;
            ss.SaveAsFile("testshot.png", ImageFormat.Png);
        }

        public void GoToMyAccount()
        {
            UpdateMyAccountLink.Click();
        }

        public bool isAt()
        {
            try
            {
                wait.Until(e => HomeSearchBar.Displayed);
                StopTimer();
                if (TestCaseGenerator.CurrentTestCase.StepExist("Check if Home Page Search Bar is Displayed"))
                {
                    if (TestCaseGenerator.CurrentTestCase.IsResponseTimeRequired)
                        TestCaseGenerator.CurrentTestCase.SetResponseTime(timer2 - timer1);
                    TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Check if Home Page Search Bar is Displayed");
                }
                Console.WriteLine("Ebsco (" + _Environment + ") Home Page Took: " + LoadTime + " to load using " + SingleSignOnProvider);
                Console.WriteLine("</br>");
            }

            catch(Exception ex)
            {
                if (TestCaseGenerator.CurrentTestCase.StepExist("Check if Home Page Search Bar is Displayed"))
                {
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Check if Home Page Search Bar is Displayed",ex.Message);
                }
            }
          
            return true;
        }
    }
}