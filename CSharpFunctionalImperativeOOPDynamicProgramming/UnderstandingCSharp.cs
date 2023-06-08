using System;

namespace CSharpBasics
{
    class Person
    {
        public string Name { get; set; }
    }

    class UnderstandingCSharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var x = 10;

            Console.WriteLine(x);
            x = 20;
            Console.WriteLine(x);

            var person = new Person();
            person.Name = "Darshan";
            Console.WriteLine(person.Name);
        }
    }
}
