using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter2.Listing0256
{
    public class Listing0256
    {
        public static void doSample()
        {
            Person person = new Person("a", "b");
            Person person2 = new Person("a", "b");
            Person[] persons = new Person[2];
            persons[1] = person;
            persons[2] = person2;

            People people = new People(persons);
            var abc = people.GetEnumerator();
        }
    }
}
