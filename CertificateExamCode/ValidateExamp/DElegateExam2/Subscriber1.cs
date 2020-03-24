using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.ValidateExamp.DElegateExam2
{
    public class Subscriber1
    {
        public void SubscriptPub()
        {
            Pub.Onchange += count => true;
        }
    }
}
