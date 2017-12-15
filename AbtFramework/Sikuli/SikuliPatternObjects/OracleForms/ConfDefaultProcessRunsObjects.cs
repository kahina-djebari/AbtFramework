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

        public IPattern GetNewHire => sikuliHelper.GetPattern(PATH + "NewHire.PNG", 5);        

        public IPattern GetEnrollmentResults => sikuliHelper.GetPattern(PATH + "EnrollmentResults.PNG", 5);
        
    }
}
