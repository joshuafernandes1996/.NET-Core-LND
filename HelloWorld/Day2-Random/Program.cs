using System;

namespace Day2_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var passLength = 10;
            var buffer = new char[passLength];

            for (var i = 0; i < passLength; i++) {
                buffer[i] = (char)('a' + random.Next(0,26));
            }

            var pass = new string(buffer);

            Console.WriteLine("Password is: {0}", pass);
        }
    }
}
