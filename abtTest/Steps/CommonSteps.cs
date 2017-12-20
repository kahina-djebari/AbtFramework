using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbtFramework.Utils_Classes.SeleniumUtils;
using TechTalk.SpecFlow;

namespace abtTest.Steps
{
    /// <summary>
    /// Holds all common steps for all steps classes. Any step that is going 
    /// to be used in more than one feature should be here.
    /// </summary>
    [Binding]
    public sealed class CommonSteps
    {

        // kill all the selenium drivers after a successfull test.
        [AfterScenario]
        public void CleanUp()
        {
            SeleniumDriver.QuitDriverInstance();
        }

        [Given(@"I have Open IE Test")]
        public void GivenIHaveOpenIETest()
        {
            SeleniumDriver.InitBrowser("IE");
        }

        [Given(@"I have Open Chrome Test")]
        public void GivenIHaveOpenChromeTest()
        {
            SeleniumDriver.InitBrowser("Chrome");
        }

        

       
    }
}
