using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    class ConfDefaultProcessRunsPttnObj
    {
        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/ConfDefaultProcessRunPttnImgs/";
        private SikuliHelper sikuliHelper;

        public ConfDefaultProcessRunsPttnObj()
        {
            sikuliHelper = SikuliHelper.GetInstance();

        }

        public IPattern GetNewHire => sikuliHelper.GetPattern(PATH + "NewHire.PNG", 5);

        public IPattern GetEnrollmentResults => sikuliHelper.GetPattern(PATH + "EnrollmentResults.PNG", 5);

    }
}
