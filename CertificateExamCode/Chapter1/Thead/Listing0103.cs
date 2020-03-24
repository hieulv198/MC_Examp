using System;
using System.Threading;

namespace CertificateExamCode.Chapter1.Thead
{
    /// <summary>
    /// Using the ParameterizedThreadStar
    /// </summary>
    public class Listing0103
    {
        public static void DoSample()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start("dumpData");
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }
            t.Join();
        }

        private static void ThreadMethod(object dumpString)
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
    }
}