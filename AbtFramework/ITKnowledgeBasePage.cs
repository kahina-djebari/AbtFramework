using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework
{
    public class ITKnowledgeBasePage : PageModel
    {
        [FindsBy(How=How.ClassName,Using = "cms_kb_list_element")]
        private IList<IWebElement> KBArticleWrapper;
        [FindsBy(How=How.Id,Using = "editArticle")]
        private IWebElement EditBtn;
        [FindsBy(How=How.Id,Using = "tinymce")]
        private IWebElement wordSection;
        [FindsBy(How=How.Id,Using = "sysverb_update")]
        private IWebElement updateBtn;

        public IWebElement RandomArticle { get { return KBArticleWrapper.ElementAt(new Random().Next(KBArticleWrapper.Count - 1))
                                                                        .FindElement(By.TagName("a")); } }

        public void OpenRandomArticle()
        {
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
            RandomArticle.Click();
          
            

        }

        public void EditArticle(string EditionText)
        {
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
    
            EditBtn.Click();
           SeleniumDriver.Instance.SwitchTo().Frame("kb_knowledge.text_ifr");
           wordSection.Click();
           action.SendKeys(Keys.Enter).SendKeys(Keys.ArrowUp).Perform();
            wordSection.FindElements(By.TagName("p")).First().SendKeys("*********");
            updateBtn.Click();
        }
    }
}