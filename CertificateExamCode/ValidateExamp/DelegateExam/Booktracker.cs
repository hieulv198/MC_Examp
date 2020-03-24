using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace CertificateExamCode.ValidateExamp.DelegateExam
{
    public class Booktracker
    {
        [SuppressMessage(
            "StyleCop.CSharp.MaintainabilityRules",
            "SA1401:FieldsMustBePrivate",
            Justification = "Reviewed. Suppression is OK here.")]
        public Action<int> BooktrackerActionInit = delegate { }; // Violate use public field, can invoke, can be change outsize class

        private readonly List<Book> books = new List<Book>();

        public delegate void EventHandler(object sender, EventArgs e);

        public event Action<int> BooktrackerActionEvent = delegate { }; // Can't be invoke,overide outsize, not null

        public CallBackVerify Verify { get; set; }

        public Action<int> BooktrackerAction
        {
            get;
            set;
        } // Can invoke outsize, can be removed all previous subscriptions outsize class

        // Can invoke outsize, can be removed all previous subscriptions outsize class
        public AddBookCallback Callback { get; set; } 

        public void AddBook(string name, AddBookCallback callback)
        {
            // must declare each function, nullableException
            books.Add(new Book(name));

            Callback(books.Count);
            callback(books.Count);
            bool foo = Verify();

            ////BooktrackerAction.Invoke(books.Count);
            ////BooktrackerActionInit.Invoke(books.Count);
            ////BooktrackerActionEvent(books.Count);
        }
    }
}