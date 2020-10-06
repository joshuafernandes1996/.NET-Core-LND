using System;
using System.Runtime.InteropServices.ComTypes;

namespace Day3_Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //    Work out if the numbers are consecutive.For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
            //        display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.WriteLine("Enter numbers seprated by hpehn");
            string list = Console.ReadLine();

            var arr = list.Split("-");
            var firstNum = arr[0];

            for(var i=1; i< arr.Length; i++)
            {


                if((Convert.ToInt32(arr[i])) == (Convert.ToInt32(arr[i-1])+1)) {
                    if (i == (arr.Length - 1))
                    {
                        Console.WriteLine("Consecutive"); break;

                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("not Consecutive"); break;
                }
                
            }
        }
    }
}
