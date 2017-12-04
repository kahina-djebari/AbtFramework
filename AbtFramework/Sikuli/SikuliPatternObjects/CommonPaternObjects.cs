using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SikuliSharp;

namespace AbtFramework.Sikuli.SikuliPatternObjects
{
    public class CommonPaternObjects
    {
        private readonly string PATH = "../AbtFramework/Sikuli/SikuliPatternImges/CommonPatternImgs/";
        private SikuliHelper sikuliHelper;

        public CommonPaternObjects()
        {
            sikuliHelper = SikuliHelper.GetInstance();

        }

        public IPattern GetRunOracleBtn => sikuliHelper.GetPattern(PATH + "RunBtn.PNG",5);

        public IPattern GetRunOracleSecurityWarning => sikuliHelper.GetPattern(PATH + "SecurityWarningRunBtn.PNG",5);

        public IPattern GetAcceptCheckBoxSecurityWarning => sikuliHelper.GetPattern(PATH + "SecurityWarningCheckBoxIAccept.PNG",5);
   
    }
}
