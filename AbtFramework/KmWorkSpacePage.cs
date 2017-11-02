using System;
using AbtFramework.SeleniumUtils;
using AbtFramework.Utils_Classes;

namespace AbtFramework
{
    public class KmWorkSpacePage : PageModel
    {
        public void Go()
        {

            SeleniumDriver.DriverInstance.Navigate().GoToUrl("https://abtassoc.sharepoint.com/communities/RepCapIntOps/KMOps/Shared%20Documents/Forms/Organized%20View.aspx?RootFolder=%2Fcommunities%2FRepCapIntOps%2FKMOps%2FShared%20Documents%2FCo%2DAuthoring%20Testing&FolderCTID=0x012000C15FAF5DA976FF4DB39060BA31ED8D67&View=%7B1E5598DD%2D32AB%2D4E67%2DA0DB%2D45F4D9680843%7D");
            
        }

       
    }
}