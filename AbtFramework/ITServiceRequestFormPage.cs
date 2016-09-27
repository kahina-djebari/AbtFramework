using System;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;
using System.Collections.Generic;

namespace AbtFramework
{
    public class ITServiceRequestFormPage : PageModel
    {
        [FindsBy(How=How.Id,Using = "dropzone0")]
        private IWebElement dropzone;
        [FindsBy(How=How.ClassName,Using = "cxs_result")]
        private IList<IWebElement> KnowledgeResults;
        [FindsBy(How=How.Id,Using = "cxs_results_data")]
        private IWebElement KnowledgeResultTable;
     //   [FindsBy(How=How.Id,Using = "IO:8ad5f6349c224200615ec5391ae8d8e5")]
     //   private IWebElement MoreInfoTxtBox;
        [FindsBy(How=How.LinkText,Using ="My Open Incidents")]
        private IWebElement OpenMyIncidentsLink;
     //   [FindsBy(How=How.Id,Using = "IO:b5d5f6349c224200615ec5391ae8d8e4")]
     //   private IWebElement ShortDescriptionTxtBox;
        [FindsBy(How=How.Id,Using = "submit_button")]
        private IWebElement submitBtn;
        [FindsBy(How=How.Id,Using = "cxs_action_button")]
        private IWebElement ThisHelpedBtn;
      //  [FindsBy(How=How.Id,Using = "IO:31d5f6349c224200615ec5391ae8d8e5")]
      //  private IWebElement UrgencyDropdown;
        [FindsBy(How = How.ClassName, Using = "cat_item_option")]
        private IList<IWebElement> IT_Fields;

        public IWebElement ShortDescriptionTxtBox { get { return IT_Fields.Single(e => e.TagName.Equals("input") && e.GetAttribute("type")!="hidden"); } }
        public IWebElement MoreInfoTxtBox { get { return IT_Fields.Single(e => e.TagName.Equals("textarea")); } }

        public IWebElement UrgencyDropdown { get { return IT_Fields.Single(e => e.TagName.Equals("select")); } }

        public void NewRequest(Urgency urgency, string shortDescription, string moreInformation)
        {

            SelectUrgency(urgency);
            ShortDescriptionTxtBox.SendKeys(shortDescription);
            wait.Until(e => KnowledgeResultTable.Displayed);
            KnowledgeResults.First().Click();
            wait.Until(e => ThisHelpedBtn.Displayed);
            ThisHelpedBtn.Click();
            action.SendKeys(Keys.Escape).Perform();
            wait.Until(e => MoreInfoTxtBox.Displayed);
            MoreInfoTxtBox.SendKeys(moreInformation);
            submitBtn.Click();
            wait.Until(e=>OpenMyIncidentsLink.Displayed);
            SeleniumDriver.Instance.SwitchTo().ParentFrame();
            action.MoveToElement(dropzone).Perform();
          //  action.SendKeys(Keys.ArrowUp).SendKeys(Keys.ArrowUp).SendKeys(Keys.ArrowUp).Perform();
          

        }

        public void NewRequest(IncidentType iT_Incident, Urgency high, string v1, string v2)
        {
            throw new NotImplementedException();
        }

        private void SelectUrgency(Urgency urgency)
        {
            switch (urgency)
            {
                case Urgency.Low:
                    UrgencyDropdown.FindElements(By.TagName("option")).Single(e => e.GetAttribute("value").Equals("3")).Click();
                    break;
                case Urgency.Medium:
                    UrgencyDropdown.FindElements(By.TagName("option")).Single(e => e.GetAttribute("value").Equals("2")).Click();
                    break;
                case Urgency.High:
                    UrgencyDropdown.FindElements(By.TagName("option")).Single(e => e.GetAttribute("value").Equals("1")).Click();
                    break;
                default:
                    break;
            }

            
        }
    }
}