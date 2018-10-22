using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            counter = 0;

            do
            {
                Console.WriteLine($"Hello World again! The counter is {counter}");
                counter++;
            } while (counter < 10);

            for(int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }

            int i;
            int j = 10;
            for (i = 0, Console.WriteLine($"Start: i={i}, j={j}"); i < j; i++, j--, Console.WriteLine($"Step: i={i}, j={j}"))
            {
                // Body of the loop.
            }


        }
    }
}
