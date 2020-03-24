using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter1.Thead
{
    public class Listing0179
    {
        private delegate int Listing0178Canculate(int a, int b);
        public static void DoSample()
        {
            int Calc(int a, int b) => a + b + 1 + 1 + 1 + 1; // local function

            Listing0178Canculate calc2 = (a, b) => a + b + 1 + 1 + 1 + 1;

            Console.WriteLine(Calc(1, 2));
        }
    }
}
