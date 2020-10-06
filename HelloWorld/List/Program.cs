using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 4, 3, 5, 6 };
            numbers.Add(1);

            foreach(var i in numbers)
                Console.WriteLine(i);
            Console.WriteLine();

            numbers.AddRange(new int[3] { 3, 4, 5 });

            foreach (var i in numbers)
                Console.WriteLine(i);
            Console.WriteLine();

            //index of
            Console.WriteLine("Index of 3 => "+ numbers.IndexOf(3));
            Console.WriteLine("Last Index of 3 => " + numbers.LastIndexOf(3));
            Console.WriteLine("Count: "+ numbers.Count);
            Console.WriteLine();

            //Remove

            numbers.Remove(3);
            for (var i = 0; i < numbers.Count; i++) {
                if (numbers[i] == 3)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var i in numbers)
                Console.WriteLine(i);
            Console.WriteLine();

            numbers.Clear();
            Console.WriteLine("Final Count: " + numbers.Count);

            Console.WriteLine();
        }
    }
}
