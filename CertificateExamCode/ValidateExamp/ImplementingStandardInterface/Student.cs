using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.ValidateExamp.ImplementingStandardInterface
{
    class Student : IComparable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (!(obj is Student o))
            {
                throw new ArgumentException("Object is not an Order");
            }

            return string.Compare(this.Name, o.Name, StringComparison.Ordinal);
        }
    }
}
