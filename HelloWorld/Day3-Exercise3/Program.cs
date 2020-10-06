using System;

namespace Day3_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new int[5];
            var count = 0;

            Console.WriteLine("Enter 5 Numbers:");
            while (true)
            {
                string n = Console.ReadLine();
                if (!String.IsNullOrEmpty(n))
                {
                    if (Array.IndexOf(num, Convert.ToInt32(n)) != -1)
                    {
                        Console.WriteLine("re-try");
                    }
                    else
                    {
                        if (count < 5)
                        {
                            num[count] = Convert.ToInt32(n);
                            count++;
                            continue;
                        }
                        else {
                            var sum = 0;
                            foreach (var i in num) {
                                sum += i;
                            }
                            Console.WriteLine("Sum: {0}", sum);
                        }
                    }


                }
                else continue;
            }
        }
    }
}
