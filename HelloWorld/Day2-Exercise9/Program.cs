using System;

namespace Day2_Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numArr;

            Console.WriteLine("Enter comma seprated numbers");
            string series = Console.ReadLine();

            numArr = series.Split(",");

            var max = Convert.ToInt32(numArr[0]);

            for (var i = 0; i < numArr.Length; i++) {

                if (int.TryParse(numArr[i], out int n)) {
                    if (Convert.ToInt32(numArr[i]) > max) {
                        max = Convert.ToInt32(numArr[i]);
                    }
                }
            }

            Console.WriteLine("Max is {0}", max);
        }
    }
}
