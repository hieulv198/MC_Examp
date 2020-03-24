using System;

namespace CertificateExamCode.ObjectiveReview
{
    /// <summary>
    ///     You have a private method in your class and you want to make invocation of the
    ///     method possible by certain callers.What do you do
    /// </summary>
    public class ObjectiveReview1401
    {
        public SecretMethodCallBack GetSecrestmethod(int userId)
        {
            if (userId == 1) return SecretMethod;
            return null;
        }

        private void SecretMethod(string sp)
        {
            Console.WriteLine($" {sp}: invocation by certain callers");
        }
    }
}