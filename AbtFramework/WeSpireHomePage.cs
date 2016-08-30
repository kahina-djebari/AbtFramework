using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using AbtFramework.Utils_Classes;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AbtFramework
{
    public class WeSpireHomePage : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Log In")]
        private IWebElement LoginBtn;
        [FindsBy(How=How.LinkText,Using ="Dashboard")]
        private IWebElement Dashboard;
        [FindsBy(How = How.CssSelector, Using = "body > div.site-wrapper > div.jPanelMenu-panel > nav > ul.nav-options.unstyled.right > li.nav-user > ul > li.user-options.hide-for-small-only > div > a > span")]
        private IWebElement userFirstName;
        [FindsBy(How=How.LinkText,Using = "Update Your Interests")]
        private IWebElement UpdateInterests;
        [FindsBy(How=How.ClassName,Using ="js-like")]
        private IList<IWebElement> PostLikesList;
        [FindsBy(How=How.LinkText,Using ="Invite")]
        private IWebElement Invite;
        [FindsBy(How=How.TagName,Using ="textarea")]
        private IList<IWebElement> PostTextArea;
        private Random random;
        private string pattern;
        private string input;
        private Regex regex;
        private int PostIndex;
        private IWebElement LikeLink;

        public bool isAt()
        {
            if(userFirstName.Text.Equals(SSOCrendentials.CurrentUser.Split(' ')[0]))
            {
                return true;
            }

            return false;
        }

        public void LikeOrUnlikeRandomComment()
        {
            random = new Random();
            pattern = @".*id=(\d*).*type=(.*)";
            regex = new Regex(pattern, RegexOptions.IgnoreCase);
            var LikeLinkIndex = random.Next(PostLikesList.Count - 1);
            LikeLink = PostLikesList[PostIndex];
            if (LikeLink.Text.Equals("Unlike"))
            {
                input = LikeLink.GetAttribute("href");
                var matches = regex.Match(input);
                var postId = matches.Groups[1].ToString();
                var postType = matches.Groups[2].ToString();
                postType = SetPostType(postType);
                
                Console.WriteLine("Unliking post: " + "https://abtxchange.staging.wespire.com/" + postType + "/" + postId);
          
                LikeLink.Click();

            }
            else
            {
                if (LikeLink.Text.Equals("Like") || LikeLink.FindElement(By.TagName("span")).GetAttribute("title").Equals("Like this")) //there are 2 links with likes link per post, one is the actual "Like" link and the icon heart that also allows you to like a post
                {
                    input = LikeLink.GetAttribute("href");
                    var matches = regex.Match(input);
                    var postId= matches.Groups[1].ToString();
                    var postType=matches.Groups[2].ToString();
                    postType = SetPostType(postType);
                    Console.WriteLine("liking post: " + "https://abtxchange.staging.wespire.com/"+postType+"/"+postId);
                    LikeLink.Click();
                }

            }


        }

        private string SetPostType(string postType)
        {
            if (postType.Equals("Event"))
            {
               return "events";
            }
            else
            {
                return "stories";
            }
        }

        public void PostOnRandomComment()
        {
            Random random = new Random();
            //int postIndex = random.Next(TextArea.Count - 1);
            
        }

        public void Go(WebEnvironment links)
        {
            switch (links)
            {
                case WebEnvironment.TestEnvironment:
                    GoToUrl("https://abtxchange.staging.wespire.com/");
                    Console.WriteLine("WeSpire Home Page Took: " + LoadTime + " to load Using Okta");
                    break;
                case WebEnvironment.ProductionEnvironment:
                    GoToUrl("https://abtassociates.wespire.com/");
                    Console.WriteLine("WeSpire Production Home Page Took: " + LoadTime + " to load Using Simieo");
                    break;
                default:
                    break;
            }
        }

        private void GoToUrl(string url)
        {
            StartTimer();
            Driver.seleniumdriver.Navigate().GoToUrl(url);
            wait.Until(e => Dashboard.Displayed);
            StopTimer();
           
        }

        public void GoTo(weSpireHomeLinks link)
        {
            switch (link)
            {
                case weSpireHomeLinks.LogIn:
                    break;
                case weSpireHomeLinks.UpdateInterest:
                    UpdateInterests.Click();
                    break;
                case weSpireHomeLinks.Invite:
                    Invite.Click();
                    break;
                default:
                    break;
            }
        }
    }
}