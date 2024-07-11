using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                throw new NotSupportedException("Pass 2 date arguments");
            }
            var from = DateTime.Parse(args[0]);
            var to = DateTime.Parse(args[1]);

            var (y, m, d) = DateDiff360.GetDiff(from, to);

            Console.WriteLine($"{y:00}-{m:00}-{d:00}");
        }
    }
}
