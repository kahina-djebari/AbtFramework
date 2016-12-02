using System;

namespace AbtFramework
{
    public class MyIRRSubmition
    {
        private static string Id;

        internal static void SetNumber(string IRRNumber)
        {
            Id = IRRNumber; 
        }

        public static string GetNumber()
        {
            return Id;
        }
    }
}