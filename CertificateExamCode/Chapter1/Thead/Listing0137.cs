using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter1.Thead
{
    /// <summary>
    /// Createing a deadlock
    /// </summary>
    public class Listing0137
    {
        public static void DoSample()
        {
            object lockA = new object();
            object lockB = new object();
            var up = Task.Run(() =>
                {
                    lock (lockA)
                    {
                        Thread.Sleep(1000); // to endsure main thread lock lockB before this thread lockB
                        lock (lockB)
                        {
                            Console.WriteLine("Locked A and B");
                        }
                    }
                });
            lock (lockB)
            {
                lock (lockA)
                {
                    Console.WriteLine("Locked A and B");
                }
            }

            up.Wait();
        }
    }
}
