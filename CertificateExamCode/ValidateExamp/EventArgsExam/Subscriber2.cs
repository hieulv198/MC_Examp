using System;

namespace CertificateExamCode.ValidateExamp.EventArgsExam
{
    public class Subscriber2
    {
        public void SubscriptPub()
        {
            Pub.OnChange += delegate(object sender, int i) {  };);
        }
    }
}
