using System;

namespace CertificateExamCode.Chapter1.Thead.Listing0184
{
    public class MyArgs : EventArgs
    {
        public MyArgs(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }
}