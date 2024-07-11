using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DateDiffTest
{
    public class Diff
    {
        [Theory]
        [InlineData("2000-02-05", "2021-06-02", "21-03-28")]
        [InlineData("2016-01-31", "2020-02-29", "04-01-00")]
        [InlineData("2016-02-01", "2020-02-29", "04-01-00")]
        [InlineData("2016-02-01", "2021-03-30", "05-02-00")]
        [InlineData("2016-02-01", "2021-03-31", "05-02-00")]
        [InlineData("2016-02-28", "2021-03-31", "05-01-04")]
        [InlineData("2016-02-29", "2021-03-31", "05-01-03")]
        [InlineData("2020-01-01", "2020-01-31", "00-01-00")]
        [InlineData("2020-01-01", "2020-02-01", "00-01-01")]
        [InlineData("2020-01-01", "2020-12-31", "01-00-00")]
        [InlineData("2020-01-01", "2021-01-01", "01-00-01")]
        [InlineData("2020-02-01", "2020-02-28", "00-00-28")]
        [InlineData("2020-02-01", "2020-02-29", "00-01-00")]
        [InlineData("2020-02-01", "2020-03-01", "00-01-01")]
        [InlineData("2020-02-01", "2021-03-30", "01-02-00")]
        [InlineData("2020-02-15", "2020-09-03", "00-06-19")]
        [InlineData("2020-08-05", "2020-10-10", "00-02-06")]
        [InlineData("2020-08-31", "2021-02-01", "00-05-01")]
        [InlineData("2020-10-10", "2021-02-15", "00-04-06")]
        [InlineData("2020-10-15", "2021-02-10", "00-03-26")]
        [InlineData("2021-02-01", "2021-02-28", "00-01-00")]

        public void Ymd(string f, string t, string d)
        {
            var from = DateTime.Parse(f);
            var to = DateTime.Parse(t);
            var dur = DateDiff.DateDiff360.GetDiffYMD(from, to);
            Assert.Equal(d, dur);
        }
    }
}
