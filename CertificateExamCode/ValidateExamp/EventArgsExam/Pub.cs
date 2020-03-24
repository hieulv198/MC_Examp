using System;

namespace CertificateExamCode.ValidateExamp.EventArgsExam
{
    public class Pub
    {
        private readonly int privateInt = 1;
        public void DoPub()
        {
            Console.WriteLine("dopub");

            privateInt;
        }
    }
}