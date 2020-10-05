using System;
using System.Runtime.InteropServices.ComTypes;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Landscpae or Portrait!");
            Console.WriteLine("Enter Width");
            string width = Console.ReadLine();
            Console.WriteLine("Enter Height");
            string height = Console.ReadLine();

            var type = (Convert.ToInt32(width) > Convert.ToInt32(height)) ? "Landscape" : "Portrait"; ;

            Console.WriteLine("Image is of type {0}", type);
        }
    }
}
