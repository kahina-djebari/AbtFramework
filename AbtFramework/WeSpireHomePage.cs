﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using AbtFramework.Utils_Classes;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using AbtFramework.SeleniumUtils;

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
        private IList<IWebElement> CommentList;
        private Random random;
        private string pattern = @".*id=(\d*).*type=(.*)";  //pattern that maches an id and a type contained in the links for a post in WeSpire
        private string Postinfo;
        private Regex regex;
        private static string SSOProvider;

        public bool isAt()
        {
            //if(userFirstName.Text.Equals(SSOCrendentials.CurrentUser.Split(' ')[0]))
            try
            {
                wait.Until(e => userFirstName.Displayed);
                if (userFirstName.Text.Equals("David"))
                {
                    if (TestCaseGenerator.CurrentTestCase.StepExist("Check if Dashboard is Displayed"))
                    {
                        StopTimer();
                        if(TestCaseGenerator.CurrentTestCase.IsResponseTimeRequired)
                        TestCaseGenerator.CurrentTestCase.SetResponseTime(timer2-timer1);
                        TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Check if Dashboard is Displayed");

                    }
                    return true;
                }
            }
            catch(Exception ex)
            {
                if(TestCaseGenerator.CurrentTestCase.StepExist("Check if Dashboard is Displayed"))
                {
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Check if Dashboard is Displayed",ex.Message);
                }

                throw ex;
            }            

            return false;
        }

        public string GetResponseTime()
        {
            return LoadTime;
        }

        public void WaitForHomePageToLoad(string AbtXchangeHandle)
        {
            //SeleniumDriver.DriverInstance.SwitchTo().Window(AbtXchangeHandle);
            SeleniumDriver.DriverInstance.SwitchTo().Window(SeleniumDriver.DriverInstance.WindowHandles.Last());
            SeleniumDriver.DriverInstance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            try
            {
                LoginBtn.Click();
                StartTimer();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            SeleniumDriver.DriverInstance.SwitchTo().Window(SeleniumDriver.DriverInstance.WindowHandles.Last());
            try
            {
                LoginBtn.Click();
                StartTimer();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            wait.Until(e => userFirstName.Displayed);
          //  Console.WriteLine(userFirstName.Text);
            StopTimer();
        }

        public void LikeOrUnlikeRandomComment()
        {
            random = new Random();
                       
            var LikeLinkIndex = random.Next(PostLikesList.Count - 1);
            var LikeLink = PostLikesList[LikeLinkIndex]; //this is actually the link to like a particular post however it does have info about the post (PostType & PostID)

            if (LikeLink.Text.Equals("Unlike"))
            {
                Postinfo = LikeLink.GetAttribute("href");
                           
                Post post = PostMatcher(Postinfo, pattern);
                Console.WriteLine("Unliking post: " + "https://abtxchange.staging.wespire.com/" + post.PostType + "/" + post.PostID);
          
                LikeLink.Click();

            }
            else
            {
                if (LikeLink.Text.Equals("Like") || LikeLink.FindElement(By.TagName("span")).GetAttribute("title").Equals("Like this")) //there are 2 links with likes link per post, one is the actual "Like" link and the icon heart that also allows you to like a post
                {
                    Postinfo = LikeLink.GetAttribute("href"); //the link for liking a post has information about the post type and post id that we can use to print the path of the post we liked.

                    Post post = PostMatcher(Postinfo, pattern);
                    Console.WriteLine("liking post: " + "https://abtxchange.staging.wespire.com/"+post.PostType+"/"+post.PostID);
                    LikeLink.Click();
                }

            }


        }

        public void GoWithNoOutputResult()
        {
            SeleniumDriver.DriverInstance.Navigate().GoToUrl("https://abtxchange.staging.wespire.com/");
        }

        private Post PostMatcher(string input, string pattern)
        {
            Post post = new Post();
            regex = new Regex(pattern, RegexOptions.IgnoreCase);
            var matches = regex.Match(input);
            post.PostID = matches.Groups[1].ToString();
            post.PostType = SetPostType(matches.Groups[2].ToString());
            

            return post;
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
             random = new Random();
            int CommentIndex = random.Next(CommentList.Count - 1);
            var CommentArea = CommentList[CommentIndex];
            var PostLink = PostLikesList[CommentIndex];
            Postinfo = PostLink.GetAttribute("href");
            Post post = PostMatcher(Postinfo, pattern);
            CommentArea.SendKeys("This is an Automatic post Generated By Selenium at: "+DateTime.Now);
            CommentArea.SendKeys(Keys.Enter);
            Console.WriteLine("a comment has been added to Post : " + "https://abtxchange.staging.wespire.com/" + post.PostType + "/" + post.PostID);


        }

        public void Go(WebEnvironment links)
        {
            switch (links)
            {
                case WebEnvironment.TestEnvironment:
                    // GoToUrl("https://abtxchange.staging.wespire.com/");
                    GoToUrl("https://abtassociates.okta.com/home/abtassociatesinc_wespiretest_1/0oa74oid9ekb7tcYS0x7/aln74op8m0ZOi56TI0x7");
                    Console.WriteLine("WeSpire (Test) Home Page Took: " + LoadTime + " to load Using Okta");
                    Console.WriteLine("</br>");
                    SSOProvider = "Okta";
                    break;
                case WebEnvironment.ProductionEnvironment:
                    GoToUrl("https://abtassociates.wespire.com/");
                    Console.WriteLine("WeSpire (Production) Home Page Took: " + LoadTime + " to load Using Simieo");
                    Console.WriteLine("</br>");
                    SSOProvider = "Simieo";
                    break;
                default:
                    break;
            }
        }

        private void GoToUrl(string url)
        {
           
            try
            {
                StartTimer();
                if (TestCaseGenerator.CurrentTestCase.StepExist("Navigate to WeSpire(Test Environment):" + url))
                {
                    
                    TestCaseGenerator.CurrentTestCase.MarkStepAsDone("Navigate to WeSpire(Test Environment):" + url);

                }
                SeleniumDriver.DriverInstance.Navigate().GoToUrl(url);
                wait.Until(e => Dashboard.Displayed);
                           

            }
            catch(Exception Ex)
            {
                if(TestCaseGenerator.CurrentTestCase.StepExist("Navigate to WeSpire(Test Environment):" + url))
                {
                    TestCaseGenerator.CurrentTestCase.MarkStepAsFailed("Navigate to WeSpire(Test Environment):" + url,Ex.Message);

                }

                throw (Ex);
            }
            
           
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