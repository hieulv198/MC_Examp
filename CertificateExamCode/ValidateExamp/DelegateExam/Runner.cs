using System;

namespace CertificateExamCode.ValidateExamp.DelegateExam
{
    public class Runner
    {
        public void Add(string name)
        {
            Booktracker booktracker = new Booktracker();
            AddBookCallback addBookCallback = i => Console.WriteLine($"line1: {i}");
            addBookCallback += i => Console.WriteLine($"line2: {i}");
            addBookCallback += WriteLine3;
            booktracker.Callback = addBookCallback;

            ////AddBookCallback addBookCallbackPram = i => Console.WriteLine($"Param line1: {i}");
            ////addBookCallbackPram += i => Console.WriteLine($"Param line2: {i}");

            ////booktracker.BooktrackerAction += i => Console.WriteLine($"Action line1: {i}");
            ////booktracker.BooktrackerAction.Invoke(1); // Violate Access
            ////booktracker.BooktrackerActionEvent += i => { Console.WriteLine($"Param line1: {i}"); };
            ////booktracker.BooktrackerActionEvent -= null;

            ////booktracker.AddBook("a", booktracker.Callback);
            ////booktracker.AddBook(name, addBookCallbackPram);
        }

        public void WriteLine3(int i)
        {
            Console.WriteLine($"line3: {i}");
        }
    }
}
