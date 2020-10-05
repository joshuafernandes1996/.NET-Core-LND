using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CHECK WHICH NUMBER IS GREATER");
            Console.WriteLine("Enter Num   1");
            string n1 = Console.ReadLine();
            Console.WriteLine("Enter Num 2");
            string n2 = Console.ReadLine();

            if (Convert.ToInt32(n1) > Convert.ToInt32(n2)) Console.WriteLine("{0} is Greated", n1);
            else Console.WriteLine("{0} is Greater", n2);
        }
    }
}
