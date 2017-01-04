using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Linq;

namespace AbtFramework
{
    public class TodayILearnedPage : PageModel
    {
        [FindsBy(How=How.Id,Using ="relatedcontent")]
        private IWebElement relatedContent;
        [FindsBy(How=How.ClassName,Using ="col1")]
        private IWebElement _author;
        [FindsBy(How=How.ClassName,Using ="welcome")]
        private IWebElement _welcomeTitle;

        public string Author { get { return _author.Text.Split(':')[1].TrimStart(); } }
          public string WelcomeTitle { get { return _welcomeTitle.Text; } }

        public bool isAt()
        {
           
            return false;
        }

       
    }
}