using System;

namespace CSharpBasics
{
    class FizzBuzzImperativeRepresentation
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 100; i++)
            {
                var div3 = i % 3;
                var div5 = i % 5;

                if (div3 == 0 && div5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (div3 == 0)
                    Console.WriteLine("Fizz");
                else if (div5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
