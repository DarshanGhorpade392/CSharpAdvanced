using System;

namespace CSharpFunctionalImperativeOOPDynamicProgramming
{
    delegate void FizzBuzzOutput(string output);
    // Q2. If I have another delegate with exact same signature as another delegate will this cause a compiler error? No
    //delegate void secondDel(string output);

    class FizzBuzzDelegate1
    {
        static void WriteFizzBuzz(string output)
        {
            Console.WriteLine(output);
        }

        static void WriteFizzBuzz2(string output)
        {
            Console.WriteLine("2: {0}", output);
        }

        static void WriteFizzBuzz(int myNumber)
        { }

        static void Main(string[] args)
        {
            Run(WriteFizzBuzz, 1, 3);
            Run(WriteFizzBuzz2, 1, 3);

            // Q1. Can we pass Console.WriteLine to delegate? Yes
            // Run(Console.WriteLine, 1, 100);
            Console.ReadKey();
        }

        public static void Run(FizzBuzzOutput output, int from, int count)
        {
            for (var i = from; i < from + count; i++)
            {
                var div3 = i % 3;
                var div5 = i % 5;

                if (div3 == 0 && div5 == 0)
                    output("FizzBuzz");         //output.Invoke("FizzBuzz");
                else if (div3 == 0)
                    output("Fizz");
                else if (div5 == 0)
                    output("Buzz");
                else
                    output(i.ToString());
            }
        }
    }
}
