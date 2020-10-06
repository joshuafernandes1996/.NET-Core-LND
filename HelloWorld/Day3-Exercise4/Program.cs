using System;
using System.Collections.Generic;

namespace Day3_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            Console.WriteLine("Enter Numbers or type quit");
            while (true)
            {
                string num = Console.ReadLine();

                if (!String.IsNullOrEmpty(num))
                {
                    if(num == "quit")
                    {
                        var uList = new List<int>();

                        foreach (var n in numbers) {
                            if (uList.IndexOf(n) == -1)
                            {
                                uList.Add(n);
                            }
                        }

                        Console.WriteLine("UNIQUE LIST");
                        foreach(var u in uList)
                        {
                            Console.WriteLine(u);
                        }

                        break;

                    }
                    else
                    {
                        numbers.Add(Convert.ToInt32(num));
                        continue;
                    }
                }
            }
        }
    }
}
