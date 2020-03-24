using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter1.Thead
{
    /// <summary>
    /// Using the lock keyword
    /// </summary>
    public class Listing0136O2
    {
        public static void DoSample()
        {
            int n = 0;
            object _lock = new object();

            var up = Task.Run(
                () =>
                    {
                        for (var i = 0; i < 1000000; i++)
                        {
                            lock (_lock)
                                n++;
                        }
                    });

            for (var i = 0; i < 1000000; i++)
                lock (_lock)
                    n--;

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
