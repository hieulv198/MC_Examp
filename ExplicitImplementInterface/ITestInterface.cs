using System;

namespace ExplicitImplementInterface
{
    internal interface ITestInterface
    {
        event EventHandler ResultRetrieved;

        int Value { get; set; }

        int this[string index] { get; set; }

        string GetResult();
    }
}