using System;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter1.Thead
{
    /// <summary>
    ///     Using a Task that returns a value
    /// </summary>
    public class Listing0109
    {
        public static void DoSample()
        {
            Task<int> t = Task.Run(() =>
                {
                    Console.WriteLine("Task runing");
                    return 42;
                });
            Console.WriteLine(t.Result); // Displays 42
        }
    }
}