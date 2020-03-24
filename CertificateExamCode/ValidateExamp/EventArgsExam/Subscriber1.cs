using System;
using System.Runtime.InteropServices;

namespace CertificateExamCode.ValidateExamp.EventArgsExam
{
    public class Subscriber1
    {
        public void SubscriptPub()
        {
            Pub.OnChange += (sender, args) => Console.WriteLine($"Subscriber1 {args.Value}");
        }
    }
}
