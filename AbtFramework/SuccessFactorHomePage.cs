using System;
using AbtFramework.Utils_Classes;

namespace AbtFramework
{
    public class SuccessFactorHomePage : PageModel
    {
        public void Go(WebEnvironment link)
        {
            switch (link)
            {
                case WebEnvironment.TestEnvironment:
                    GoToUrl("https://hcm4preview.sapsf.com/login?company=AbtTEST");
                    Console.WriteLine("Success Factor Test Home Page Took: " + LoadTime + " to load");
                    break;
                case WebEnvironment.ProductionEnvironment:
                    GoToUrl("https://daxii.abtassoc.com/openam/idpssoinit?metaAlias=/abt/AbtSaml2Idp&spEntityID=https://www.successfactors.com&binding=HTTP-POST&NameIDFormat=urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified&RelayState=/sf/home/&iPSPCookie=Yes");
                    Console.WriteLine("Success Factor Production Home Page Took: " + LoadTime + " to load");
                    break;
                default:
                    break;
            }
        }

        private void GoToUrl(string url)
        {
            Driver.seleniumdriver.Navigate().GoToUrl(url);
            StartTimer();
            // wait.Until(e => LoginBtn.Displayed);
            StopTimer();
        }
    }
}