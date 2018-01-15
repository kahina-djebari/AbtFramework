using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    public class HiringInInbountPttnObj
    {
        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/HiringInInbountPttnImgs/";
        private SikuliHelper sikuliHelper;

        public HiringInInbountPttnObj()
        {
            sikuliHelper = SikuliHelper.GetInstance();
        }

        public IPattern GetSubmitNewRequestBtn => sikuliHelper.GetPattern(PATH + "SubmitNewRequestBtn.PNG", 5);
    }
}
