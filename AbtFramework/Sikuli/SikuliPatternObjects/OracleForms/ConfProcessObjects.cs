using SikuliSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    class ConfProcessObjects
    {
        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/ConfProcessImgs/";
        private SikuliHelper sikuliHelper;

        public ConfProcessObjects()
        {
            sikuliHelper = SikuliHelper.GetInstance();

        }

        public IPattern GetTerminate => sikuliHelper.GetPattern(PATH + "Terminate.PNG", 5);

       
    }
}
