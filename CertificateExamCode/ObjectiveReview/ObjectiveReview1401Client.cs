using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.ObjectiveReview
{
    public class ObjectiveReview1401Client
    {
        public static void DoSample()
        {
            ObjectiveReview1401 objective = new ObjectiveReview1401();
            SecretMethodCallBack abc = objective.GetSecrestmethod(1);
            abc.Invoke("aaa");
        }

    }
}
