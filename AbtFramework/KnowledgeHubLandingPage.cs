using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbtFramework.SeleniumUtils;

namespace AbtFramework
{
   public class KnowledgeHubLandingPage : PageModel
    
    {
        [FindsBy(How = How.Id, Using = "DeltaPlaceHolderPageTitleInTitleArea")]
        private IWebElement header;     

        [FindsBy(How = How.Id, Using = "cred_userid_inputtext")]
        private IWebElement email;

        [FindsBy(How = How.Id, Using = "cred_password_inputtext")]
        private IWebElement password;
        
        public void Go()
        {
            StartTimer();
            SeleniumDriver.DriverInstance.Navigate().GoToUrl("https://abtassoc.sharepoint.com/sites/PropProj/KnowledgeHub/SitePages/Home.aspx");
        }

        public void AttemptToLogin()
        {
            //in case the user is prompted with username and password
            try
            {
                if (email != null)
                {
                    email.SendKeys("jose_frometa@abtassoc.com");
                    password.SendKeys("321654kK.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("User and Password field not found");
                Console.WriteLine(e.Message);
            }
        }
 
        public bool isAt()
        {
            if (header.Text.Equals("Knowledge Hub"))
            {
                return true;
            }
            return false;
        }

    }
}
