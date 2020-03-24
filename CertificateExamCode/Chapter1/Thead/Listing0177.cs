using System;
using System.IO;

namespace CertificateExamCode.Chapter1.Thead
{
    /// <summary>
    ///    Covariance
    /// </summary>
    public class Listing0177
    {
        public delegate TextWriter CovarianceDel();

        public void DoSample()
        {
            CovarianceDel del;
            del = MethodStream; // StreamWriter kế thừa TextWriter
        }

        public StreamWriter MethodStream()
        {
            return null;
        }
    }
}