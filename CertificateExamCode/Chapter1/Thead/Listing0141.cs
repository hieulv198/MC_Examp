using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter1.Thead
{
    /// <summary>
    /// Compare and exchange as a nonatomic operation
    /// </summary>
    public class Listing0141
    {
        static int value = 1;

        public static void DoSample()
        {
            Task t1 = Task.Run(
                () =>
                    {
                        // nonatomic đọc
                        if (value == 1)
                        {
                            Thread.Sleep(100); // Giả lập máy chạy chậm, bi thread khác thay đổi value =))))
                            // nonatomic ghi
                            value = 2;
                        }
                    });
            Task t2 = Task.Run(() => { value = 3; });
            Task.WaitAll(t1, t2);
            Console.WriteLine(value);
        }

        public static void DoSample2()
        {
            Task t1 = Task.Run(
                () =>
                    {
                        Interlocked.CompareExchange(ref value, 2, 1);
                    });
            Task t2 = Task.Run(() => { value = 3; });
            Task.WaitAll(t1, t2);
            Console.WriteLine(value); 
        }
    }
}