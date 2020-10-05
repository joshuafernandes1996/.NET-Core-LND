using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[8] { 10, 9, 8, 1, 2, 3, 5, 6 };

            //Clear
            Array.Clear(arr, 0, 2);

            foreach(var a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            //Copy
            var arr1 = new int[3];
            Array.Copy(arr, arr1, 3);
            foreach (var a in arr1)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            //IndexOfConsole.WriteLine(a);
            Console.WriteLine(Array.IndexOf(arr,8));
            Console.WriteLine();

            //Reverse
            Array.Reverse(arr);
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            //Reverse
            Array.Sort(arr);
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();


        }
    }
}
