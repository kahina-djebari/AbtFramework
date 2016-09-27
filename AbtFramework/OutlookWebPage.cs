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

        [FindsBy(How = How.ClassName,Using = "PersonaPaneLauncher")]
        private IWebElement ProfileInfo;
        [FindsBy(How=How.LinkText,Using ="Outlook Web Access")]
        private IWebElement outlookLink;
        [FindsBy(How = How.TagName, Using = "div")]
        private IList<IWebElement> divs;

        [FindsBy(How = How.ClassName, Using = "_fce_c")]
        private IWebElement newMailWrapper;

        [FindsBy(How = How.TagName, Using = "input")]
        private IList<IWebElement> inputs;
        [FindsBy(How=How.Id,Using = "MailFolderPane.FavoritesFolders")]
        private IWebElement EmailFolders;

        [FindsBy(How = How.ClassName, Using = "findControlWrapper")]
        private IWebElement recipientWrapper;
        [FindsBy(How = How.ClassName, Using = "conductorContent")]
        private IWebElement EmailList;

        [FindsBy(How=How.CssSelector,Using = "#O365_TopMenu > div > div > div:nth-child(1) > div:nth-child(14) > button")]
        private IWebElement profilePic;
        [FindsBy(How=How.CssSelector,Using = "#_ariaId_147 > div > div._abs_b.ms-bg-color-white > span > div > div > span._pe_l._pe_N > div > span:nth-child(1)")]
        private IWebElement UserName;
        [FindsBy(How = How.Id, Using = "MailFolderPane.FavoritesFolders")]
        private IWebElement FolderPane;
           public IWebElement InboxFolder { get { return FolderPane.FindElements(By.TagName("span")).Single(e => e.Text.Equals("Inbox")); } }


        public bool IsAt() {


             wait.Until(e=>SeleniumDriver.Instance.Title.Equals("Mail - "+SSOCrendentials.CurrentUser+" - Outlook"));
         //  wait.Until(e => SeleniumDriver.Instance.Title.Equals("Mail - " +"Sofiane Oumsalem"+ " - Outlook"));
            StopTimer();
            PrintResponseTime("Outlook Web");
            return true;
           
          
            
            
        }

    


        public bool SendEmail(string receipient, string subjectText, string bodyText)
        {
           
          
            action.Click(getEmailBtn()).Perform(); 
            getRecipientElement().SendKeys(receipient);
            getRecipientElement().SendKeys(Keys.Enter);
            getSubjectInput().SendKeys(subjectText);
            getSubjectInput().SendKeys(Keys.Tab);
            IWebElement body = SeleniumDriver.Instance.SwitchTo().ActiveElement();
            body.SendKeys(bodyText);
            body.SendKeys(Keys.Tab);
            IWebElement sendBtn = SeleniumDriver.Instance.SwitchTo().ActiveElement();
            action.Click(sendBtn).Perform();
            // now check if it was sent
            action.Click(GetSentItemsFolder()).Perform();

            var LastEmail = GetEmailList().First();

            Console.WriteLine(LastEmail.GetAttribute("aria-label").Split(',')[2]);
            return LastEmail.GetAttribute("aria-label").Split(',')[2].Contains(subjectText);

        }

        public void OpenEmail()
        {
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.Until(e => GetEmailList());
            var emails = GetEmailList();
            var randomMail = emails.First();


            wait.Timeout = TimeSpan.FromSeconds(20);
            wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.Until((Func<IWebDriver, bool>)((e) =>
            {
                if (SeleniumDriver.Instance.WindowHandles.Count < 2)
                {
                    action.DoubleClick(randomMail).Perform();

                }
                else
                {

                    return true;
                }

                return false;

            }));

            SeleniumDriver.Close();
            
            IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
            alert.Accept();

            SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.Instance.WindowHandles.Last());
      
      
           

        }

        private IWebElement GetSentItemsFolder()
        {
            return EmailFolders.FindElements(By.TagName("span"))
                           .Single(e => e.Text.Equals("Sent Items"));
        }

        public IEnumerable<IWebElement>  GetEmailList()
        {
                     

              return EmailList.FindElements(By.TagName("div"))
                                  .Where(e => e.GetAttribute("autoid") != null && e.GetAttribute("autoid")
                                  .Equals("_lvv_3"));
        }

        private IWebElement getSendBtn()
        {
            var elements = buttons.Where(e => e.GetAttribute("aria-label") != null);
            return elements.Where(e => e.GetAttribute("aria-label").Equals("Send")).First();
        }

        private IWebElement getSubjectInput()
        {
            var elements = inputs.Where(e => e.GetAttribute("placeholder") != null);
            return elements.Single(e => e.GetAttribute("placeholder").Equals("Add a subject"));
            
        }

        private IWebElement getBodyInput()
        {
           // var elements = divs.Single(e=>e.Text.Equals("Add a message or drag a file here"));
           // Console.WriteLine("amount of divs overall"+divs.Count());
           // Console.WriteLine("amount of div elements with aria-label:"+elements.Count());
          //  return elements.Single(e => e.GetAttribute("aria-label").Equals("Message body"));
          return divs.Where(e => e.Text.Equals("Add a message or drag a file here")).First();
        }

        public void Go()
        {
            StartTimer();
            SeleniumDriver.Instance.Navigate().GoToUrl("https://outlook.com/abtassoc.com");
        }

        private IWebElement getEmailBtn()
        {
         
          return  newMailWrapper.FindElements(By.TagName("button")).Where(e => e.GetAttribute("title").Equals("Write a new message (N)")).First();
        }

        private IWebElement getRecipientElement()
        {
            //var elements = inputs.Where(e => e.GetAttribute("aria-label") != null);
            // return elements.Single(e => e.GetAttribute("aria-label")
            //   .Equals("To recipients. Enter an email address or a name from your contact list."));

            return recipientWrapper.FindElements(By.TagName("input"))
                .Single(e => e.GetAttribute("aria-label")
                .Equals("To recipients. Enter an email address or a name from your contact list."));

        }

     
    
        public bool IsUserLoggedIn()
        {

            var btns = buttons.Where(b => b.GetAttribute("autoid")!=null); //eliminate btns withouth autoid attribute
            var btn = btns.SingleOrDefault(b => b.GetAttribute("autoid").Equals("_ho2_0")); //get the btn that contains user info
            Console.WriteLine("Outlook Web Page Loaded in: "+LoadTime);
            btn.Click();
         
          
            IWebElement username =ProfileInfo.FindElements(By.TagName("span")).Single(e=>e.Text.Equals(SSOCrendentials.CurrentUser));  //this element contains spans nested and contains username info
            if (username.Text.Equals(SSOCrendentials.CurrentUser))
            {
                return true;

            }


            return false;
           
        }
    }
}