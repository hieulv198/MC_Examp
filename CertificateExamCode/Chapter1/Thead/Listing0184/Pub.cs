using System;

namespace CertificateExamCode.Chapter1.Thead.Listing0184
{
    public class Pub
    {
        public event EventHandler<MyArgs> OnChange = delegate { };

        public void Raise()
        {
            OnChange(this, new MyArgs(42));
        }
    }
}