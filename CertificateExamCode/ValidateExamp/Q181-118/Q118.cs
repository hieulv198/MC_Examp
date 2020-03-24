using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.ValidateExamp.Q181_118
{
    class Q118
    {
        public static int Count(System.Threading.CancellationToken ct)
        {
            var countSoFar = 0;
            while (!ct.IsCancellationRequested)
            {
                countSoFar++;
            }

            return countSoFar;
        }

        public static void DoSample()
        {
            var cancellationTokenSource = new System.Threading.CancellationTokenSource();
            var task = System.Threading.Tasks.Task.Factory.StartNew<int>(() => Count(cancellationTokenSource.Token));
            
            Console.WriteLine("Press [Enter] to stop counting.");
            Console.ReadLine();

            cancellationTokenSource.Dispose();

            Console.WriteLine("Counting stopped at {0}", task.GetAwaiter().GetResult());
            Console.ReadLine();
        }
    }
}
