using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class ConfSetupConfirmationPage : PageModel
    {
        [FindsBy(How=How.ClassName,Using = "outputmsg_text")]
        private IWebElement OutputMsg;

        public bool isAt()
        {
            wait.Until(e=>OutputMsg.Displayed);
            if(OutputMsg.Text.Equals("Thank you, your request has been submitted"))
            {
                return true;
            }

            return false;
        }
    }
}