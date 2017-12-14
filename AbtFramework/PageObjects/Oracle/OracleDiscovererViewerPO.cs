using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.PageObjects.Oracle
{
    public class OracleDiscovererViewerPO
    {
        public IWebElement GetDetailActiveEmployeeOptn()
        {
            string xpath = "//a[contains(text(),'Detail Active Employee')]/preceding-sibling::a//img";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public List<IWebElement> GetExpandedOptionToClick()
        {
            string xpath = "//a[contains(@href, 'javascript:discoOpen')]";
            return SeleniumDriver.GetListElementByXpath(xpath);
        }

        public List<IWebElement> GetSelectToExpandIcons()
        {
            string xpath = "//img[@alt = 'Select to expand']";
            return SeleniumDriver.GetListElementByXpath(xpath);
        }
    }
}
