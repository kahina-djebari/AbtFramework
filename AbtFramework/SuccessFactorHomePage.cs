using System;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework
{
    public class SuccessFactorHomePage : PageModel
    {
        [FindsBy(How=How.Id,Using = "6__moduleLinksDropDown")]
        private IWebElement HomeDropdown;
        [FindsBy(How = How.ClassName, Using = "dropDownButtonText")]
        private IList<IWebElement> dropdowns;
        private static string SSOProvider;

        public IWebElement Username { get { return dropdowns.Single(e => e.Text.Equals("Sofiane Oumsalem")); } }

        public void Go(WebEnvironment link)
        {
            switch (link)
            {
                case WebEnvironment.TestEnvironment:
                    GoToUrl("https://abtassociates.okta.com/home/successfactors/0oa7asr5nxwVWgWVw0x7/38");
                    Console.WriteLine("Success Factor (Test) Home Page Took: " + LoadTime + " to load using Okta");
                    Console.WriteLine("</br>");
                    SSOProvider = "Okta";
                    break;
                case WebEnvironment.ProductionEnvironment:
                    GoToUrl("https://daxii.abtassoc.com/openam/idpssoinit?metaAlias=/abt/AbtSaml2Idp&spEntityID=https://www.successfactors.com&binding=HTTP-POST&NameIDFormat=urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified&RelayState=/sf/home/&iPSPCookie=Yes");
                    Console.WriteLine("Success Factor Production Home Page Took: " + LoadTime + " to load using Simieo");
                    Console.WriteLine("</br>");
                    SSOProvider = "Simieo";
                    break;
                default:
                    break;
            }
        }

        private void GoToUrl(string url)
        {
            Driver.seleniumdriver.Navigate().GoToUrl(url);
            StartTimer();
            wait.Until(e => dropdowns.Single(a=>a.Text.Equals("Home")).Displayed);

            StopTimer();
        }

        public bool isUserLoggedIn()
        {
            if(Username.Text.Equals("Sofiane Oumsalem"))
            {
                Console.WriteLine("User: Sofiane Oumsalem successfully logged in using " + SSOProvider);
                return true;
            }

            else { return false; }
        }
    }
}