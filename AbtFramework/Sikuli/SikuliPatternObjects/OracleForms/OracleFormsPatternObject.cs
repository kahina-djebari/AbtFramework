using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SikuliSharp;

namespace AbtFramework.Sikuli.SikuliPatternObjects.OracleForms
{
    /// <summary>
    /// Object class that holds all patterns for Oracle Forms
    /// </summary>

     public class OracleFormsPatternObject
    {
        public IPattern GetTestPattern => Patterns.FromFile("C:/Users/bernhardtj/Pictures/calculatorBtn8.PNG");
      
    }
}
