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

        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/GradeRateImgs/";

        public IPattern GetRunBtn => Patterns.FromFile(PATH + "RunBtn.PNG");

        public IPattern GetNoBtn => Patterns.FromFile(PATH + "NoBtn.PNG");

        public IPattern GetGradeName => Patterns.FromFile(PATH + "GradeName.PNG");
    }
}
