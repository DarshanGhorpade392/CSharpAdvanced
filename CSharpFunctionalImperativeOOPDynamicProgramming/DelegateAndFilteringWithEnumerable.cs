using System;
using System.Collections.Generic;

namespace CSharpFunctionalImperativeOOPDynamicProgramming
{
    delegate bool IntPredicate(int number);

    class DelegateAndFilteringWithEnumerable
    {
        static bool isMod3 (int num)
        {
            return num % 3 == 0;
        }

        static bool isMod5(int num)
        {
            return num % 5 == 0;
        }

        static void Main(string[] args) {
            var arr = new[] { 1, 2, 3, 4, 5, 6 };

            IntPredicate predicate = isMod3;
            predicate += isMod5;



            var filteredList = Filter(arr, predicate);

            foreach (var item in Filter(arr, isMod3))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        // Invocation List and predicate
        static IEnumerable<int> Filter(IEnumerable<int> source, IntPredicate predicate)
        {
            var list = new List<int>();
            foreach (var item in source)
            {
                if (predicate(item))
                    list.Add(item);
            }
            return list;
        }
    }
}
