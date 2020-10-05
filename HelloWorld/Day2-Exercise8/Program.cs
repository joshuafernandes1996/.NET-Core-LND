using System;

namespace Day2_Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            while (true) {
                var num = random.Next(1, 10);
                Console.WriteLine("Guess the number {0}:", num);
                int res = Convert.ToInt32(Console.ReadLine());

                if (res == num) { Console.WriteLine("YOU WON!!!"); break; } else { Console.WriteLine("YOU LOSE!"); break; }

            }

        }
    }
}
