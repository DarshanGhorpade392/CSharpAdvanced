using System;

namespace CSharpBasics
{
    interface IFizzOutput {
        void Write(string output);
    }

    class FizzBuzz
    {
        private readonly IFizzOutput _output;

        public FizzBuzz(IFizzOutput output)
        {
            _output = output;
        }

        public void Run(int from, int count) {
            for (var i = from; i < from + count; i++)
            {
                var div3 = i % 3;
                var div5 = i % 5;

                if (div3 == 0 && div5 == 0)
                    _output.Write("FizzBuzz");
                else if (div3 == 0)
                    _output.Write("Fizz");
                else if (div5 == 0)
                    _output.Write("Buzz");
                else
                    _output.Write(i.ToString());
            }
        }
    }

    class ConsoleFizOutput : IFizzOutput
    {
        public void Write(string output)
        {
            Console.WriteLine(output);
        }
    }

    class FizzBuzzOOPRepresentation
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz(new ConsoleFizOutput());
            fizzBuzz.Run(0,100);
            Console.ReadKey();
        }
    }
}
