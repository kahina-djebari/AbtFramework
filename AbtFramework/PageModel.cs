using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace AbtFramework
{
    public class PageModel
    {
       public WebDriverWait wait;
        public Actions action;
        public static long timer1;
        public static long timer2;
        public string LoadTime { get { return ((timer2 - timer1)).ToString()+"ms"; } }
        public PopupWindowFinder finder;
        public string popupWindowHandle;
        public void StartTimer()
        {
          timer1=  DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
           
        }

        public void StopTimer()
        {
          timer2 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

        }





    }
}