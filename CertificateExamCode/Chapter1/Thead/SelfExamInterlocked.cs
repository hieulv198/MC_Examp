using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter1.Thead
{
    public class SelfExamInterlocked
    {
        public static void DoSample2()
        {
            int n = 0;

            var up = Task.Run(
                () =>
                    {
                        Thread.Sleep(10000);
                        for (int i = 0; i < 50000000; i++)
                        {
                            Interlocked.Increment(ref n);
                        }
                    });

            Console.WriteLine(n); // display 0

            ////Interlocked.Exchange(ref n, 10);
            Interlocked.Exchange(ref n, 10);
            Console.WriteLine($"Exchange: {n}");
            up.Wait(); // block UI
            Console.WriteLine(n); // display 50000000
        }

        public static void DoSample()
        {
            int n = 0;
       
            var up = Task.Run(
                () =>
                    {
                        for (int i = 0; i < 50000000; i++)
                        {
                            n++;
                        }
                    });
            Console.WriteLine(n); // display 0
            Thread.Sleep(100); 
            Console.WriteLine(n); // depend
            up.Wait(); // block UI
            Console.WriteLine(n); // display 50000000
        }
    }
}
