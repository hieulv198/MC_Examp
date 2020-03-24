using System;
using System.Collections.Generic;
using System.Linq;

namespace CertificateExamCode.ValidateExamp.ImplementingStandardInterface
{
    internal class ImplementingStandardInterfaceClient
    {
        public static void DoSample()
        {
            var students = new List<Student>
                               {
                                   new Student { Name = "aa", Id = 1 },
                                   new Student { Name = "aaa", Id = 3 },
                                   new Student { Name = "aaa", Id = 2 },
                                   new Student { Name = "aaccc", Id = 5 }
                               };
            students.ForEach(i => Console.WriteLine(i.Name));
            //// students = students.OrderBy(i => i.Id).ToList();
            
            students.Sort();
            Console.WriteLine("after sort");
            students.ForEach(i => Console.WriteLine(i.Name));
        }
    }
}