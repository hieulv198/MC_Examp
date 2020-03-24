using CertificateExamCode.ValidateExamp.DelegateExam;

namespace CertificateExamCode.ValidateExamp
{
    public class TestExampDelegate
    {
        public static void DoSample()
        {
            Runner runner = new Runner();
            AnotherClass anotherClass = new AnotherClass();
            runner.Add("a");
            ////anotherClass.DoSomeThing();
        }
    }
}