using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AbtFramework
{
    public class WeSpireUpdateInterestsPage : PageModel
    {
        [FindsBy(How=How.ClassName,Using ="category-interest")]
        private IList<IWebElement> CategoryList;
        [FindsBy(How=How.Name,Using ="commit")]
        private IWebElement Save;
       
 

        public void RandomInterestUpdate()
        {
            MakeRandomInterestSelection();
            Save.Click();
        }

        private void MakeRandomInterestSelection()
        {
         
            Random random = new Random();
            int interestIndex = random.Next(CategoryList.Count-1);
           
        
            //need to implement check if item is selected to display wether the interest was added or removed.
            CategoryList[interestIndex].Click();
         

        }

     
       }
}