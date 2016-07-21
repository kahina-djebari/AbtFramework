using System;

namespace AbtFramework
{
    public class AbtTravelPage : PageModel
    {
        public void goTo()
        {
            AbtDriver.TopNavigation.ToolsDropdown.AbtTravelLink();
        }
    }
}