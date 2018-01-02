using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    public class GradeRatePttnObj
    {
        private SikuliHelper sikuliHelper;

        public GradeRatePttnObj()
        {
            sikuliHelper = SikuliHelper.GetInstance();
        }

        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/GradeRatePttnImgs/";

        public IPattern GetView => sikuliHelper.GetPattern(PATH + "View.PNG");

        public IPattern GetQueryByExample => sikuliHelper.GetPattern(PATH + "QueryByExample.PNG");

        public IPattern GetEnter => sikuliHelper.GetPattern(PATH + "Enter.PNG");

        public IPattern GetNameField => sikuliHelper.GetPattern(PATH + "NameField.PNG");

        public IPattern GetRun => sikuliHelper.GetPattern(PATH + "Run.PNG");

        public IPattern GetGradeNameField => sikuliHelper.GetPattern(PATH + "GradeNameField.PNG");

        public IPattern GetGradeNameInputField => sikuliHelper.GetPattern(PATH + "GradeNameInputField.PNG");








    }
}
