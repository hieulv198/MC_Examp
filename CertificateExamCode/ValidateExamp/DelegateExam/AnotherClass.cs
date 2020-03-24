using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.ValidateExamp.DelegateExam
{
    public class AnotherClass
    {
        public void DoSomeThing()
        {
            Booktracker booktracker = new Booktracker();
            booktracker.AddBook("a", Callback);
        }

        private void Callback(int i)
        {
            Calculate(i);
            Calculate2(i);
            Calculate3(i);
            Calculate4(i);
        }

        private void Calculate(int i)
        {
        }

        private void Calculate2(int i)
        {
        }

        private void Calculate3(int i)
        {
        }

        private void Calculate4(int i)
        {
        }
    }
}
