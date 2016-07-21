using System;

namespace AbtFramework
{
    public class OraclePage : PageModel
    {
        public void goTo()
        {
            AbtDriver.TopNavigation.ToolsDropdown.OracleLink();
        }
    }
}