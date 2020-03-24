using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.ValidateExamp.Q181_114
{
    public class Employee
    {
        public string EmplooyeeType { get; protected set; }
    }

    public class Employee2 : Employee 
    {
        public  void DoSample()
        {
           var asdad =  EmplooyeeType;
           EmplooyeeType = "";

        }
    }

    public class Employee3
    {
        public void DoSample()
        {
            Employee employee = new Employee();
            var asda = employee.EmplooyeeType;

#if (DEBUG)
            var asda2 = employee.EmplooyeeType;

#elif (TRACE)
            var asda2 = employee.EmplooyeeType;
#endif

        }
    }
}
