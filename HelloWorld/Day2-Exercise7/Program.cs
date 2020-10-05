using System;
using System.Runtime.InteropServices.ComTypes;

namespace Day2_Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var fact = 1;

            Console.WriteLine("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (var i = num; i > 0; i--) {
                fact = fact * i;
            }

            Console.WriteLine("{0}! = {1}", num,fact);
        }
    }
}
