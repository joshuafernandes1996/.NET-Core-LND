using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Day3_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            var fnames = "";

            while (true) {
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(name))
                    names.Add(name);
                else {

                    for (var i = 0; i < names.Count; i++) {
                        if (i == 0)
                            fnames = names[i] + " and ";
                        else if (i != (names.Count -1))
                            fnames = fnames + names[i] + " and ";
                        else
                            fnames = fnames + names[i];
                    }

                    Console.WriteLine("{0} likes your post", fnames);
                    break;
                }
            }
        }
    }
}
