using System;
using System.Collections.Generic;
using System.Linq;

using CertificateExamCode.ValidateExamp.DelegateExam;

namespace CertificateExamCode.ValidateExamp.DElegateExam2
{
    public class Pub
    {
        private List<Book> _books = new List<Book>();

        public static OnchangeCallback Onchange { get; set; }

        public void AddBook(string name)
        {
            _books.Add(new Book(name));
            Raise();
        }

        private void Raise()
        {
            if (Onchange == null) return;

            var invocationList = Onchange.GetInvocationList();
            foreach (var del in invocationList)
            {
                var delOnchange = del as OnchangeCallback;
                if (delOnchange == null) continue;

                bool isSuccess = delOnchange.Invoke(_books.Count);
                Console.WriteLine(isSuccess);
            }
        }
    }
}