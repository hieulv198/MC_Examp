using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.Practice.TestRef
{
    class TestRefClient
    {
        public static void DoSample()
        {
            TestRefClient  client = new TestRefClient();
            client.DoTestRef();
        }

        public void DoTestRef()
        {
            TestRef testRef = new TestRef();
            testRef.Name = "1";
            Console.WriteLine(testRef.Name);
            ChangeName(testRef);
            Console.WriteLine(testRef.Name);

            string sint = "";
            ChangeName(sint);
            Console.WriteLine(sint);
        }

        public void ChangeName(TestRef testRef)
        {
            testRef.Name = "testRef";
        }

        public void ChangeName(string testRef)
        {
            testRef = "testRef";
        }
    }
}
