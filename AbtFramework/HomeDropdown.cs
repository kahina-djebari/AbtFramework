using OpenQA.Selenium;
using System;
using System.Linq;
using System.Threading;

namespace AbtFramework
{
    public class HomeDropdown : PageModel
    {
        public IWebElement HomeLink { get { return SeleniumDriver.Instance.FindElements(By.LinkText("Home")).Single(e=>e.GetAttribute("target").Equals("_self")); } }

        public IWebElement AboutAbt { get { return SeleniumDriver.Instance.FindElement(By.LinkText("About Abt")); } }

        public IWebElement AbtStrategyLink { get { return SeleniumDriver.Instance.FindElement(By.LinkText("Abt Strategy")); } }

        public IWebElement Subsidiaries { get { return SeleniumDriver.Instance.FindElement(By.LinkText("Subsidiaries")); } }

        public IWebElement AbtValue { get { return SeleniumDriver.Instance.FindElement(By.LinkText("Abt Values")); } }

        public IWebElement Departments { get { return SeleniumDriver.Instance.FindElement(By.LinkText("Departments")); } }

        public IWebElement AgiHelp { get { return SeleniumDriver.Instance.FindElement(By.LinkText("AGI Help")); } }

        public IWebElement Communities { get { return SeleniumDriver.Instance.FindElement(By.LinkText("Communities")); } }

        public IWebElement EAC { get { return SeleniumDriver.Instance.FindElement(By.LinkText("Employee Advisory Council (EAC)")); } }

        public void GoTo_AboutABt()
        {
            GoTo(Abtlinks.AboutAbt);
        }

        private void GoTo(Abtlinks linkText)
        {
            switch (linkText)
            {


                case Abtlinks.EAC:
                    while (SeleniumDriver.Instance.Title.Equals("Home"))
                    {
                        try
                        {
                            action.MoveToElement(HomeLink).Perform();
                            action.MoveToElement(Departments).Perform();
                            EAC.Click();

                        }

                        catch
                        {

                        }

                    }

                    Console.WriteLine("Clicking on AGI Top Navigation ->Home->Employee Advisory Council(EAC)");
                    Console.WriteLine("</br>");

                    break;
                case Abtlinks.Communities:
                    while (SeleniumDriver.Instance.Title.Equals("Home"))
                    {
                        try
                        {
                            action.MoveToElement(HomeLink).Perform();
                            action.MoveToElement(Departments).Perform();
                            Communities.Click();

                        }

                        catch
                        {

                        }

                    }

                    Console.WriteLine("Clicking on AGI Top Navigation ->Home->Communities");
                    Console.WriteLine("</br>");

                    break;

                case Abtlinks.AgiHelp:

                    while (SeleniumDriver.Instance.Title.Equals("Home"))
                    {
                        try
                        {
                            action.MoveToElement(HomeLink).Perform();
                            action.MoveToElement(Departments).Perform();
                            AgiHelp.Click();

                        }

                        catch
                        {

                        }

                    }

                    Console.WriteLine("Clicking on AGI Top Navigation ->Home->AGI Help");
                    Console.WriteLine("</br>");
                    break;


                case Abtlinks.AbtValues:
                    while (SeleniumDriver.Instance.Title.Equals("Home"))
                    {
                        try
                        {
                            action.MoveToElement(HomeLink).Perform();
                            action.MoveToElement(Departments).Perform();
                           AbtValue.Click();

                        }

                        catch
                        {

                        }

                    }

                    Console.WriteLine("Clicking on AGI Top Navigation ->Home->Abt Values");
                    Console.WriteLine("</br>");

                    break;
                case Abtlinks.AbtStrategy:

                    OpenSpecialLink(AbtStrategyLink,"Abt Strategy");
                 
                    break;

                case Abtlinks.Divisions:
                    OpenLink("Divisions");
                    break;
                case Abtlinks.Subsidaries:
                    OpenLink("Subsidiaries");
                    break;
                case Abtlinks.Initiatives:
                    OpenLink("Initiatives & Programs");

                    break;
                case Abtlinks.Departments:
                    OpenLink("Departments");
                    break;
                case Abtlinks.AboutAbt:
                    OpenLink("About Abt");
                    break;
               
            }
          
        }

        private void OpenSpecialLink(IWebElement element,String linkName)
        {
            while (SeleniumDriver.Instance.Title.Equals("Home"))
            {
                try
                {
                    action.MoveToElement(HomeLink).Perform();
                    action.MoveToElement(Subsidiaries).Perform();
                    element.Click();

                }

                catch
                {

                }

            }

            Console.WriteLine("Clicking on AGI Top Navigation ->Home->"+linkName);
            Console.WriteLine("</br>");
        }

        public void GoTo_EAC()
        {
            GoTo(Abtlinks.EAC);
        }

        private void OpenLink(string linkText)
        {
            while (SeleniumDriver.Instance.Title.Equals("Home"))
            {
                try
                {
                    action.MoveToElement(HomeLink).Perform();
                    Thread.Sleep(500);
                    SeleniumDriver.Instance.FindElement(By.LinkText(linkText)).Click();
                    Thread.Sleep(1000);
                }

                catch
                {

                }

            }

            Console.WriteLine("Clicking on AGI Top Navigation ->Home->" + linkText);
            Console.WriteLine("</br>");
        }

        public void GoTo_Communities()
        {
            GoTo(Abtlinks.Communities);
        }

        public void GoTo_AgiHelp()
        {
            GoTo(Abtlinks.AgiHelp);
        }

        public void GoTo_Departments()
        {
            GoTo(Abtlinks.Departments);
        }

        public void GoTo_Initiatives()
        {
            GoTo(Abtlinks.Initiatives);
        }

        public void GoTo_Subsidaries()
        {
            GoTo(Abtlinks.Subsidaries);
        }

        public void GoTo_Divisions()
        {
            GoTo(Abtlinks.Divisions);
        }

        public void GoTo_AbtStrategy()
        {
            GoTo(Abtlinks.AbtStrategy);
        }

        public void GoTo_AbtValues()
        {
            GoTo(Abtlinks.AbtValues);
        }
    }
}