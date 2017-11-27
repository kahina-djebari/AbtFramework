using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    public class GradeRatePatternObject
    {
        private SikuliHelper sikuliHelper;

        public GradeRatePatternObject()
        {
            sikuliHelper = SikuliHelper.GetInstance();
        }

        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/GradeRateImgs/";

        public IPattern GetNoBtn => sikuliHelper.GetPattern(PATH + "NoBtn.PNG");

        public IPattern GetGradeName => sikuliHelper.GetPattern(PATH + "GradeName.PNG");


    }
}
