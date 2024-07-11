using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDiff
{
    public static class DateDiff360
    {
        public static string GetDiffYMD(DateTime from, DateTime to)
        {
            var (y, m, d) = GetDiff(from, to);

            return $"{y:00}-{m:00}-{d:00}";
        }

        public static (int years, int months, int days) GetDiff(DateTime from, DateTime to)
        {
            var d360From = Get360days(from);
            var d360To = Get360days(to);
            var d360Diff = d360To - d360From + 1;

            var y = d360Diff / 360;
            d360Diff %= 360;
            var m = d360Diff / 30;
            var d = d360Diff % 30;
            return (y, m, d);
        }

        static int Get360days(DateTime dt)
        {
            //var cal = System.Globalization.CultureInfo.InvariantCulture.Calendar;
            //return dt.Year * 360 + dt.Month * 30 + ((dt.Day > 30) ? 30 : dt.Day);
            return dt.Year * 360 + dt.Month * 30 + (DateTime.DaysInMonth(dt.Year, dt.Month) == dt.Day ? 30 : dt.Day);
        }
    }
}
