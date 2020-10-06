using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3_Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter, without supplying an input,
            //    exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
            while (true) {
                Console.WriteLine("Enter a few numbers separated by a hyphen");
                string input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input)) { break; };

                var numbers = new List<int>();
                foreach (var n in input.Split('-'))
                    numbers.Add(Convert.ToInt32(n));

                if (numbers.Count() != numbers.Distinct().Count())
                {
                    Console.WriteLine("Duplicate"); break;
                }
            }
            
        }
    }
}
