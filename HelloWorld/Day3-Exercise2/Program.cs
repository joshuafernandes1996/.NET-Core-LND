using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Day3_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            char[] arr = name.ToCharArray();

            Array.Reverse(arr);
            Console.WriteLine("REVERSE");
            var rev = new string(arr);

            Console.WriteLine(rev);
        }
    }
}
