using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitImplementInterface
{
    public class ImplementClass : IInterface1, IInterface2
    {
        public string DoWork()
        {
            return "IInterface1.DoWork";
        }

        string IInterface2.DoWork()
        {
            return "IInterface2.DoWork";
        }
    }
}
