using System;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
     
                Console.WriteLine("Enter Number between 1-10");
                string v = Console.ReadLine();
                num = Convert.ToInt32(v);

                if (num >= 1 && num <= 10) Console.WriteLine("Valid"); else Console.WriteLine("Invalid");

            
        }
    }
}
