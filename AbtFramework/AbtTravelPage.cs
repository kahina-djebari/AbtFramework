using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Linq;

namespace AbtFramework
{
    public class AbtTravelPage : PageModel
    {
        [FindsBy(How=How.Id,Using = "dnn_dnnUSERNAMEFORMAT_lblUserName")]
         private IWebElement username;
        [FindsBy(How=How.LinkText,Using = "AbtTravel Home")]
        private IWebElement AbtTravelLink;

        public void goTo()
        {
            AbtDriver.TopNavigation.ToolsDropdown.AbtTravelLink();
            wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.Until(DriverExtentions.WaitforWindowsTobe2);
            Driver.seleniumdriver.Close();
            Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
        }

        public bool isAt()
        {
            if (AbtTravelLink.Displayed)
            {
                StopTimer();
                Console.WriteLine("BCD Travel Portal Took : " + LoadTime + " to load");
                return true;

            }

            return false;
        }

        public bool isUserLoggedIn()
        {
            if (isAt())
            {


                if (username.Text.Equals(SSOCrendentials.CurrentUser))
                {
                    
                    return true;
                }
                                
            }

            return false;
        }


        public void Go()
        {
            StartTimer();
            Driver.seleniumdriver.Navigate().GoToUrl("https://daxii.abtassoc.com/openam/idpssoinit?metaAlias=/abt/AbtSaml2Idp&spEntityID=bcdsso.bcdtravel.com&binding=urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST&RelayState=https://bcdpingidgateway.bcdtravel.com/SP/TripSourcePortal/tripsourceportal.aspx&iPSP");
            
        }
    }
}