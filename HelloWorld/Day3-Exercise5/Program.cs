using System;

namespace Day3_Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Enter Comma Seprated List:");
                string list = Console.ReadLine();

                var arr = list.Split(",");

                if (arr.Length < 5)
                {
                    Console.WriteLine("Invalid List. re-try.");
                    continue;
                }
                else
                {
                    Array.Sort(arr);
                    for(var i=0; i <3;i++)
                    {
                        Console.WriteLine(arr[i]);
                    }
                    break;
                }
            }
            
        }
    }
}
