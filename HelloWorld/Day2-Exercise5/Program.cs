using System;

namespace Day2_Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (var i = 1; i <= 100; i++) {
                if (i % 3 == 0) {
                    count++;
                }
            }

            Console.WriteLine("{0} numbers are divisible by 3 between 1-100", count);
        }
    }
}
