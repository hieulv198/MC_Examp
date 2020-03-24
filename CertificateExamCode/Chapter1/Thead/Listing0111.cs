using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter1.Thead
{
    /// <summary>
    ///  Scheduling different continuation tasks
    /// </summary>
    public class Listing0111
    {
        public static void DoSample()
        {
            Task<int> t = Task.Run(() => 42);
            t.ContinueWith((i) => { Console.WriteLine("Canceled"); }, TaskContinuationOptions.OnlyOnCanceled);
            t.ContinueWith((i) => { Console.WriteLine("Faulted"); }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith( 
                (i) => { Console.WriteLine("Completed"); },
                TaskContinuationOptions.OnlyOnRanToCompletion);
            completedTask.Wait();
        }
    }
}
