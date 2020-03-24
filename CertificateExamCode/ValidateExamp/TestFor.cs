namespace CertificateExamCode.ValidateExamp
{
    using System;

    public class TestFor
    {
        public static void DoSample()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            for (var i = 0; i < intArray.Length; i++)
                intArray[i] += intArray[i];

            foreach (var item in intArray) Console.WriteLine(item);
        }
    }

    internal class TestFor1
    {
        public static void DoSample()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            for (var i = 1; i < intArray.Length; i++) intArray[i] += intArray[i - 1];

            foreach (var item in intArray) Console.WriteLine(item);
        }
    }

    public class TestFor3
    {
        public static void DoSample()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            for (var i = 1; i < intArray.Length; i++) 
                intArray[i] += intArray[i - 1];

            foreach (var item in intArray) Console.WriteLine(item);
        }
    } 

    public class TestFor4
    {
        public static void DoSample()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (var i = 0; i < intArray.Length;)
            {   
                sum += intArray[i];
                intArray[i++] = sum;
            }
            foreach (var item in intArray) Console.WriteLine(item);
        }
    }


}