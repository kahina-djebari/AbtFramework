using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    class ConfProcessPttnObj
    {
        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/ConfProcessPttnImgs/";
        private SikuliHelper sikuliHelper;

        public ConfProcessPttnObj()
        {
            sikuliHelper = SikuliHelper.GetInstance();

        }

        public IPattern GetTerminate => sikuliHelper.GetPattern(PATH + "Terminate.PNG", 5);

       
    }
}
