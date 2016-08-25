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

        public bool isAt()
        {
            if (relatedContent.Displayed)
            {
                return true;
            }

            return false;
        }

       
    }
}