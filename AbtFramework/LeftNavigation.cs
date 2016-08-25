using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;
using System.Collections.Generic;

namespace AbtFramework
{
    public class LeftNavigation : PageModel
    {
        [FindsBy(How = How.Id, Using = "zz7_RootAspMenu")]
        private IWebElement leftNavList;

        private List<IWebElement> LinkList;

        private IWebElement WeAreAbtLink
        {
            get { return GetLink("We Are Abt");}
        }

        private IWebElement HistoryLink
        {
            get{ return GetLink("History"); }
        }

        private IWebElement DurhamLink
        {
            get{return GetLink("Durham");}
        }

        private IWebElement CambridgeShuttleScheduleLink
        {
            get{return GetLink("Cambridge Shuttle Schedule");}
        }

        private IWebElement AbtCambridgeSoftballLink
        {
            get{return GetLink("Abt Cambridge Softball");}
        }

        private IWebElement AbtCafeAtCambridgeLink
        {
            get{return GetLink("Abt Café at Cambridge");}
        }

        private IWebElement CambridgeLink
        {
            get { return GetLink("Cambridge"); }
        }

        private IWebElement BethesdaLink
        {
            get  { return GetLink("Bethesda"); }
        }

        private IWebElement MAGLink
        {
            get{return GetLink("Management Advisory Group (MAG)");}
        }

        private IWebElement ElevatorSpeechLink
        {
            get {return GetLink("Elevator Speech");}
        }

        private  IWebElement OfficeLocationsLink
        {
            get{return GetLink("Office Locations"); }
        }

        public  IWebElement GetLink(string value)
        {
            foreach (var el in leftNavList.FindElements(By.TagName("li")))
            {
                foreach (var ele in el.FindElements(By.TagName("span")))
                {
                    if (ele.Text.Equals(value))
                    {
                   
                        return ele;
                    }
                }
            }

            Console.WriteLine("Couldn't Find Link \"" + value + "\" on LeftNavigation");
            return null;

        }


     
      
        public bool isActive()
        {
            LinkList = new List<IWebElement>();
            LinkList.Add(WeAreAbtLink);
            LinkList.Add(HistoryLink);
            LinkList.Add(DurhamLink);
            LinkList.Add(CambridgeShuttleScheduleLink);
            LinkList.Add(AbtCambridgeSoftballLink);
            LinkList.Add(AbtCafeAtCambridgeLink);
            LinkList.Add(CambridgeLink);
            LinkList.Add(BethesdaLink);
            LinkList.Add(MAGLink);
            LinkList.Add(OfficeLocationsLink);
            bool areActives = true;

            foreach(var el in LinkList)
            {
                if (!el.Displayed)
                {
                    Console.WriteLine("Link \"" + el.Text + "\" is not displayed or is not working");
                    Console.WriteLine("</br>");
                    areActives =false;
                }

                else
                {
                    Console.WriteLine("Link \"" + el.Text + "\" is Displaying correctly");
                    Console.WriteLine("</br>");
                }
            }


            return areActives;
        }
    }
}