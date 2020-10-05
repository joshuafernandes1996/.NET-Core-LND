using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Day2.Exercises
{
    class IsValidNumber
    {
        int num = 0;
        public void CheckNumber() {
            Console.WriteLine("Enter Number between 1-10");
            string v = Console.ReadLine();
            num = Convert.ToInt32(v);

            if (num >= 1 && num <= 10) Console.WriteLine("Valid"); else Console.WriteLine("Invalid");
            
        }
    }
}
