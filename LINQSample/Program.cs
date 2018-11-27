using System;

namespace LINQSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // UsingQuerySyntax.IntegerTestUsingLinq();
            // UsingQuerySyntax.StringTestUsingLinq();
            UsingQuerySyntax.ObjectTestUsingLinq();
            UsingMethodSyntax.ObjectTestUsingLinq();

            Console.ReadLine();
        }
    }

    class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
    }
}
