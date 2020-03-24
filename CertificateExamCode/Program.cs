using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using CertificateExamCode.Chapter1.Thead;
using CertificateExamCode.ObjectiveReview;
using CertificateExamCode.ValidateExamp;
using CertificateExamCode.ValidateExamp.CancelingTaskExample;
using CertificateExamCode.ValidateExamp.DelegateExam;
using CertificateExamCode.ValidateExamp.DElegateExam2;
using CertificateExamCode.ValidateExamp.ImplementingStandardInterface;

namespace CertificateExamCode
{
    using CertificateExamCode.Chapter3;
    using CertificateExamCode.Practice.TestRef;
    using CertificateExamCode.ValidateExamp.Q181_118;
    using CertificateExamCode.ValidateExamp.TestRegex;

    // ReSharper disable once ArrangeTypeModifiers
    class Program
    {
        // ReSharper disable once ArrangeTypeMemberModifiers
        static void Main(string[] args)
        {
            ////Listing11.DoSample();
            ////Console.WriteLine("CreatingThreadWithThreadClass End, test join");

            ////Listing0118.DoSampleDoubleAwait();
            ////Console.WriteLine("This String print before DoSampleDoubleAwait because DoSampleDoubleAwait not use Task.Result");

            ////Listing0118.DoSample();
            ////Console.WriteLine("This String print After DoSample");

            Listing0317.DoSample();
            Console.Read();
        }
    }
}
