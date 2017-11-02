using AbtFramework.Utils_Classes;
using System;
using AbtFramework.SeleniumUtils;

namespace AbtFramework
{
    public class SANSHomepage : PageModel
    {
        public void Go()
        {
            try
            {
                StartTimer();
                if (TestCaseGenerator.CurrentTestCase.StepExist("Navigate To Url http://abt.securingthehuman.org"))
                {
                    TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Navigate To Url http://abt.securingthehuman.org");
                }
                 SeleniumDriver.DriverInstance.Navigate().GoToUrl("http://abt.securingthehuman.org");
            }

            catch(Exception ex)
            {
                TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Navigate To Url http://abt.securingthehuman.org",ex.Message);
            }
        }

        public bool IsAt()
        {
            return true;
            
        }
    }
}