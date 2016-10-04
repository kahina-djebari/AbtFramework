using System;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AbtFramework
{
    public class SuccessFactorHomePage : PageModel
    {
        [FindsBy(How=How.Id,Using = "6__moduleLinksDropDown")]
        private IWebElement HomeDropdown;
        [FindsBy(How = How.ClassName, Using = "dropDownButtonText")]
        private IList<IWebElement> dropdowns;


        public IWebElement Username { get { return dropdowns.Single(e => e.Text.Equals("David Acuna")); } }

        public void Go(WebEnvironment link)
        {
            switch (link)
            {
                case WebEnvironment.TestEnvironment:
                    GoToUrl("https://abtassociates.okta.com/home/successfactors/0oa7asr5nxwVWgWVw0x7/38");
                    Environment = "Test";
                    SingleSignOnProvider = "Okta";
                    break;
                case WebEnvironment.ProductionEnvironment:
                    GoToUrl("https://daxii.abtassoc.com/openam/idpssoinit?metaAlias=/abt/AbtSaml2Idp&spEntityID=https://www.successfactors.com&binding=HTTP-POST&NameIDFormat=urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified&RelayState=/sf/home/&iPSPCookie=Yes");
                    Environment = "Production";
                    SingleSignOnProvider = "Simieo";
                    break;
                default:
                    break;
            }
        }

        private void GoToUrl(string url)
        {
            StartTimer();
            SeleniumDriver.Instance.Navigate().GoToUrl(url);
      

        

        
        }

        public bool isUserLoggedIn()
        {

            if (isAt())
            {

                if (Username.Text.Equals("David Acuna"))
                {
                   // Console.WriteLine("User: David Acuna successfully logged in using " + SingleSignOnProvider);
                    return true;
                }

                else
                {
                    return false;
                }

            }

            else
            {
                return false;
            }

            
          
        }

      public bool isAt()
        {
           
            wait.Until(e=>SeleniumDriver.Instance.Title.Equals("SuccessFactors: Home"));
            StopTimer();
            if (dropdowns.Single(a => a.Text.Equals("Home")).Displayed)
            {
                
                PrintResponseTime("SuccessFactors");
                return true;
            }
           else
            {
                return false;
            }
        }
    }
}