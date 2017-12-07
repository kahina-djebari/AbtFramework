using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    class ConfDefaultProcessRunsObjects
    {
        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/ConfDefaultProcessRunsImgs/";
        private SikuliHelper sikuliHelper;

        public ConfDefaultProcessRunsObjects()
        {
            sikuliHelper = SikuliHelper.GetInstance();

        }

        public IPattern GetNoBtn => sikuliHelper.GetPattern(PATH + "NoBtn.PNG", 5);

        public IPattern GetFullName => sikuliHelper.GetPattern(PATH + "FullName.PNG", 5);

        public IPattern GetFindBtn => sikuliHelper.GetPattern(PATH + "FindBtn.PNG", 5);

        public IPattern GetDownArrow => sikuliHelper.GetPattern(PATH + "DownArrow.PNG", 5);

        public IPattern GetNewHire => sikuliHelper.GetPattern(PATH + "NewHire.PNG", 5);

        public IPattern GetDesktopActivities => sikuliHelper.GetPattern(PATH + "DesktopActivities.PNG", 5);

        public IPattern GetEnrollmentResults => sikuliHelper.GetPattern(PATH + "EnrollmentResults.PNG", 5);

        public IPattern GetName => sikuliHelper.GetPattern(PATH + "Name.PNG", 5);
    }
}
