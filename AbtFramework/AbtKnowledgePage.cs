using System;

namespace AbtFramework
{
    public class AbtKnowledgePage : PageModel
    {
        public void goTo()
        {
            AbtDriver.TopNavigation.ToolsDropdown.AbtKnowledgeLink();
        }
    }
}