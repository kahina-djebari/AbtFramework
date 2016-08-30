using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;

namespace AbtFramework
{
    public class WeSpireInvitePage : PageModel
    {
        [FindsBy(How=How.Id,Using = "token-input-invite_email")]
        private IWebElement InviteTextBox;
        [FindsBy(How = How.Id, Using = "new_invite")]
        private IWebElement newInvite;
        [FindsBy(How=How.Id,Using = "js-submit-invites")]
        private IWebElement submitBtn;
        [FindsBy(How=How.CssSelector,Using = "#flash-wrapper > div > p")]
        private IWebElement SuccessfullMsg;

        public bool InviteUser(string user)
        {
            wait.Until(e => InviteTextBox.Displayed);
            InviteTextBox.SendKeys(user);
            Thread.Sleep(1000);
            newInvite.Click();
            submitBtn.Click();

            wait.Until(e=>SuccessfullMsg.Displayed);
            Console.WriteLine("You Have Succesfully sent 1 invite to user : "+user);

            return true;
        }
    }
}