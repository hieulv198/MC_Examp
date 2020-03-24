using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExplicitImplementInterface;

namespace CertificateExamCode.ValidateExamp.AccessModifier
{
    public class ImplementInterfaceExample
    {
        public static void DoSample()
        {
            ImplementClass implementClass  = new ImplementClass();
            implementClass.DoWork();
            ((IInterface2)implementClass).DoWork();
        }
    }
}
