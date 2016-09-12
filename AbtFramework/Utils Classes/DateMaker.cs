using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.Utils_Classes
{
    public class DateMaker
    {
        private static DateTime startDate;
        private static DateTime endDate;

        public static string GetStartDate()
        {
           
            startDate = DateTime.Now.AddDays(2);
            return startDate.ToString("yyyy-MM-dd hh:mm:ss");
        }

        public static string GetEndDate()
        {
            endDate = startDate.AddHours(2);
            return endDate.ToString("yyyy-MM-dd hh:mm:ss");
        }
    }
}
