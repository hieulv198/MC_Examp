using System;

namespace CertificateExamCode.Chapter1.Thead
{
    /// <summary>
    /// Using a delegate.
    /// </summary>
    public class Listing0175
    {
        public delegate int Calculate(int x, int y);

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }

        public void UseDelegate()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4)); // Displays 7
            calc = multiply;
            Console.WriteLine(calc(3, 4)); // Displays 12
        }
    }
}