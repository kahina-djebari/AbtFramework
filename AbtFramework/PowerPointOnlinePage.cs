using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using AbtFramework.SeleniumUtils;

namespace AbtFramework
{
    public class PowerPointOnlinePage : PageModel
    {
        [FindsBy(How = How.Id, Using = "WACDialogActionButton")]
        private IWebElement AddSlide;
        [FindsBy(How=How.Id,Using = "PptRibbon.Home.Slides.NewSlide-Large")]
        private IWebElement NewPPTSlide;
        [FindsBy(How=How.CssSelector,Using = "#application > div.FishBowlPanel")]
        private IWebElement SlideWrapper;
        [FindsBy(How = How.CssSelector, Using = "#application > div.FishBowlPanel > div.SlideView.pointer-events-none > svg:nth-child(3) > g > image")]
        private IWebElement ImageTitle;
        [FindsBy(How=How.CssSelector,Using = "#application > div.FishBowlPanel > div.SlideView.pointer-events-none > svg:nth-child(7) > g > path:nth-child(2)")]
        private IWebElement TextArea;
        [FindsBy(How=How.Id,Using = "PptRibbon.Home-title")]
        private IWebElement homeTab;

        public void Edit()
        {


            SeleniumDriver.DriverInstance.SwitchTo().Frame("WebApplicationFrame");
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id("PptRibbon.Home.Slides-LargeMedium-0-0")));
            try
            {
                NewPPTSlide.Click();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           // NewPPTSlide.Click();
           // AddSlide.Click();
           // Thread.Sleep(2000);
           // SlideWrapper.Click();
           // action.SendKeys(Keys.Enter).SendKeys("Adding new Slide at: "+DateTime.Now).Perform();
            

           
        }
    }
}