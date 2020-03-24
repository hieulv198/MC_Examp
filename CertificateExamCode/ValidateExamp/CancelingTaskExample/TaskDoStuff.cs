using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CertificateExamCode.ValidateExamp.CancelingTaskExample
{
    public class TaskDoStuff
    {
        public Task<int> DoStuff(CancellationToken cancellation)
        {
            int display = 0;
            Task.Run(
                () =>
                    {
                        for (int i = 0; i < 100000; i++)
                        {
                            display = i;
                            Console.WriteLine($"print: {display}");
                            if (cancellation.IsCancellationRequested) break;
                        }
                    },
                cancellation);
            return Task.FromResult(display);
        }
    }
}
