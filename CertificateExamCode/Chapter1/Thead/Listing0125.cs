using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter1.Thead
{
    public class Listing0125
    {
        public static void DoSample()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0).Where(i => i % 4 == 0).AsSequential();
            foreach (int i in parallelResult.Take(5))
                Console.WriteLine(i);
        }
    }
}
