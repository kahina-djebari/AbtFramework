using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Linq;
namespace AbtFramework
{
    public class OutlookEmailViewerPage : PageModel
    {

        [FindsBy(How = How.ClassName, Using = "allowTextSelection")]
        private IWebElement headerWrapper;


        public bool isEmailOpen()
        {
            if (GetEmailSubject() == null)
            {
                return false;
            }
            else
            {
                
                return true;
            }
        }

        private string GetEmailSubject()
        {
           return headerWrapper.FindElements(By.TagName("span"))[1].Text;
        }
    }
}