using System;

namespace CertificateExamCode.Chapter1.Thead
{
    /// <summary>
    ///     A multicast delegate
    /// </summary>
    public class Listing0176
    {
        private delegate int ListingCanculate(int a, int b);

        public void DoSample()
        {
            ListingCanculate canculate = Add;
            Console.WriteLine(canculate(1, 2));
        }

        private int Add(int a, int b)
        {
            return a + b;
        }
    }
}