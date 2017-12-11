using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AbtFramework.Utils_Classes.SeleniumUtils;

namespace AbtFramework
{
    public class WordOnlinePage : PageModel
    {
        [FindsBy(How = How.Id, Using = "WACDialogActionButton")]
        private IWebElement convertLink;
        [FindsBy(How = How.Id, Using = "WACDialogSecondaryButton")]
        private IWebElement edit;
        [FindsBy(How = How.Id, Using = "flyoutWordViewerEdit-Medium20")]
        private IWebElement EditDropdown;
        [FindsBy(How = How.Id, Using = "btnFlyoutConvertToEditOnWeb-Menu32")]
        private IWebElement EditLink;
        [FindsBy(How = How.Id, Using = "WACViewPanel_EditingElement")]
        private IWebElement DivTextArea;
        [FindsBy(How = How.ClassName, Using = "OutlineGroup")]
        private IWebElement OutlineGroup;
        [FindsBy(How = How.Id, Using = "flyInsertSymbols-Large")]
        private IWebElement symbolDropdown;
        [FindsBy(How = How.Id, Using = "symbol_0_•-Menu")]
        private IWebElement Symbol;
        [FindsBy(How=How.Id,Using = "tabInsert-title")]
        private IWebElement insertTab;

        public void Edit()
        {
            SeleniumDriver.Instance.SwitchTo().Frame("WebApplicationFrame");
            Thread.Sleep(5000);
            action.SendKeys(Keys.Enter).SendKeys(Keys.Up).SendKeys("Knowledge Hub Word Document Edit Test at: " + DateTime.Now).Perform();
            Console.WriteLine("Edited Word Document Sucesfully");
            Thread.Sleep(5000);

        }


    }
}