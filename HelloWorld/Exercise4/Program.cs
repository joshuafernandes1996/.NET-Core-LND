using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit = 0;
            int carSpeed = 0;
            int demirit = 0;

            Console.WriteLine("Enter Speed Limit");
            speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Car Speed");
            carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else {
                var limit = speedLimit;

                while (limit <= carSpeed) {
                    demirit = demirit + 1;
                    limit = limit + 5;
                }

                if (demirit > 12)
                {
                    Console.WriteLine("LICENSE SUSPENDED");
                }
            }
        }
    }
}
