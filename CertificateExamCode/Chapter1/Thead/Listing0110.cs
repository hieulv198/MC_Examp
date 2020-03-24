using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter1.Thead
{
    /// <summary>
    /// Adding a continuation
    /// </summary>
    public class Listing0110
    {
        public static void DoSample()
        {
            Task<int> t = Task.Run(() => 0)
                .ContinueWith(i => 2 / i.Result) // DeviveByZeroException
                .ContinueWith(i => i.Result * 2);
            Console.WriteLine(t.Result);
        }
    }
}
