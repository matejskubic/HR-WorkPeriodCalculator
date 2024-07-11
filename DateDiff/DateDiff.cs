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
            var cal = System.Globalization.CultureInfo.InvariantCulture.Calendar;

            var d = to.Day - from.Day + 1;
            var m = to.Month - from.Month;
            var y = to.Year - from.Year;

            if (d < 0)
            {
                d += 30;
                m--;
            }
            if (d == cal.GetDaysInMonth(to.Year, to.Month) || d == 30)
            {
                d = 0;
                m++;
            }

            if (m < 0)
            {
                m += 12;
                y--;
            }
            if (m == 12)
            {
                m = 0;
                y++;
            }

            return (y, m, d);
        }
    }
}
