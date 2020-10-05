using System;

namespace Day2_Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            while (true) {

                Console.WriteLine("Enter number or 'ok' to exit");
                string res = Console.ReadLine();

                if (res == "ok")
                {
                    Console.WriteLine("Sum is: {0}", sum);
                    break;
                }
                else
                {
                    sum += Convert.ToInt32((string)res);
                    continue;
                }
            }


        }
    }
}
