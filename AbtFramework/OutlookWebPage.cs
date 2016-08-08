using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework
{
    public class OutlookWebPage : PageModel
    {

        [FindsBy(How=How.TagName,Using ="span")]
        private IList<IWebElement> spans;
        [FindsBy(How = How.TagName, Using = "button")]
        private IList<IWebElement> buttons;
        [FindsBy(How=How.ClassName,Using = "_ho2_0")]
        private IWebElement userCard;
             
        [FindsBy(How = How.ClassName,Using ="_pe_01")]
        private IWebElement divInfo;
        [FindsBy(How=How.LinkText,Using ="Outlook Web Access")]
        private IWebElement outlookLink;
        [FindsBy(How = How.TagName, Using = "div")]
        private IList<IWebElement> divsEmails;

        public void goTo()
        {
           
            StartTimer();
            outlookLink.Click();
            wait.Until(d => Driver.seleniumdriver.WindowHandles.Count >= 2);
            Driver.Close();
            Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
            StopTimer();
        }

        public bool CanOpenEmail()
        {
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("div")));
          var workingDivs= divsEmails.Where(e => e.GetAttribute("autoid") != null);
          var emails = workingDivs.Where(e => e.GetAttribute("autoid").Equals("_lvv_3"));
          var randomMail= emails.ElementAt(1);

            wait.Until((e) =>
            {
                if (Driver.seleniumdriver.WindowHandles.Count < 2)
                {
                    action.DoubleClick(randomMail);

                }
                else
                {
                    return true;
                }

                return false;

            });
           
           
            return true;
        }

        public bool isAt()
        {

            var btns = buttons.Where(b => b.GetAttribute("autoid")!=null); //eliminate btns withouth autoid attribute
            var btn = btns.SingleOrDefault(b => b.GetAttribute("autoid").Equals("_ho2_0")); //get the btn that contains user info
            Console.WriteLine("Outlook Web Page Loaded in: "+LoadTime);
            btn.Click();
         
          
            IWebElement username =divInfo.FindElements(By.TagName("span"))[0];  //this div element contains to spans nested and the first one is the one that contains the username
            if (username.Text.Equals(SSOCrendentials.CurrentUser))
            {
                return true;

            }


            return false;
           
        }
    }
}