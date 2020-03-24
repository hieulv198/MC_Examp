using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter1.Thead
{
    public class Listing0122
    {
        public static void DoSample()
        {
            var numbers = Enumerable.Range(0, 10000000);
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();
        }
    }
}
