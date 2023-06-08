/*
 * Invoke delegate with same method but by different instances
 */

// delegate can either point to static method or instance method

using System;

namespace CSharpFunctionalImperativeOOPDynamicProgramming
{
    delegate void FizzBuzzOutput(string output);
    class Blegh
    {
        private readonly string _prefix;

        public Blegh(string prefix)
        {
            _prefix = prefix;
        }

        public void DoStuff(string output)
        {
            Console.WriteLine("From BLEGH {0} - {1}", _prefix, output);
        }

        public override string ToString()
        {
            return "Blegh with prefix of " + _prefix;
        }
    }

    class FizzBuzzDelegate2
    {
        static void Main(string[] args)
        {
            var blegh1 = new Blegh("Blegh 1");
            var blegh2 = new Blegh("Blegh 2");

            // Run(blegh1.DoStuff, 1, 3);
            // Run(blegh2.DoStuff, 1, 3);

            FizzBuzzOutput myOutput = blegh1.DoStuff;
            myOutput += blegh2.DoStuff;

            Run(myOutput, 1, 3);


            Console.ReadKey();
        }

        private static void Run(FizzBuzzOutput output, int from, int count)
        {
            Console.WriteLine("Target = {0}", output.Target.ToString());
            Console.WriteLine("Method = {0}", output.Method.ToString());

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
