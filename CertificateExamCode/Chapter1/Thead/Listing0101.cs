using System;
using System.Threading;

namespace CertificateExamCode.Chapter1.Thead
{
    /// <summary>
    /// Creating a thread with the Thread class
    /// </summary>
    public class Listing0101
    {
        public static void DoSample()
        {
            var t = new Thread(ThreadMethod);
            t.Start();
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }

            t.Join();
        }

        public static void DoSample(int a)
        {
            var t = new Thread(ThreadMethod);
            t.Start();
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }

            t.Join();
        }

        private static void ThreadMethod()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
    }
}