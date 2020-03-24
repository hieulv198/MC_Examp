using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter1.Thead
{
    public class SelfExamInfiityLoop
    {
        public static void DoSample()
        {
            for (int i = 0;; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
