using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter1.Thead
{
    public class Listing0106
    {
        private static readonly ThreadLocal<int> Field  = new ThreadLocal<int>(() => Thread.CurrentThread.ManagedThreadId);

#pragma warning disable SA1600 // Elements should be documented
        public static void doSample()
#pragma warning restore SA1600 // Elements should be documented
        {
            new Thread(() =>
                {
                    for (var x = 0; x < Field.Value; x++)
                    {
                        Console.WriteLine("Thread A: {0}", x);
                    }
                }).Start();

            new Thread(() =>
                {
                    for (var x = 0; x < Field.Value; x++)
                    {
                        Console.WriteLine("Thread B: {0}", x);
                    }
                }).Start();

            Console.ReadKey();
        }

        public static void DoSample2()
        {
            
        }
    }
}

