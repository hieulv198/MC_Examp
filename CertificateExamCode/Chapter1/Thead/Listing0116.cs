using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter1.Thead
{
    public class Listing0116
    {
        public static void DoSample()
        {
            Parallel.For(0, 10, i => { Thread.Sleep(1000); });
            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i => { Thread.Sleep(1000); });
        }
    }
}