using System;
using System.Threading;

namespace CertificateExamCode.ValidateExamp.CancelingTaskExample
{
    public class CancelingTaskExample
    {
        public static void DoSample()
        {
            TaskDoStuff taskDoStuff  = new TaskDoStuff();
            CancellationTokenSource cancellationSource  = new CancellationTokenSource();
            CancellationToken token = cancellationSource.Token;
            taskDoStuff.DoStuff(token);
            Thread.Sleep(1000);
            cancellationSource.Cancel();
            Console.WriteLine("stop");
        }
    }
}
