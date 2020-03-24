using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.ValidateExamp.EventArgsExam
{
    public class MyArgs : EventArgs
    {
        public MyArgs(int value, int value2)
        {
            Value = value;
        }

        public int Value { get; set; }
    }
}
