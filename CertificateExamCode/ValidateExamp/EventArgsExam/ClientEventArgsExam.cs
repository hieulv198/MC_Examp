using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.ValidateExamp.EventArgsExam
{
    public class ClientEventArgsExam
    {
        public static void DoSample()
        {
            Subscriber1 subscriber1 = new Subscriber1();
            Subscriber2 subscriber2 = new Subscriber2();
            Subscriber1 subscriber3 = new Subscriber1();
            Subscriber2 subscriber4 = new Subscriber2();

            subscriber1.SubscriptPub();
            subscriber2.SubscriptPub();
            subscriber3.SubscriptPub();
            subscriber4.SubscriptPub();

            Pub pub  = new Pub();
            pub.DoPub();
        }
    }
}
