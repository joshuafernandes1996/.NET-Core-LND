using HelloWorld.Math;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = 0;
            //var count = 10;
            //var totalPrice = 20.99f;
            //double total = 30.45;
            //var character = 'a';
            //string example = "string";
            //bool isTrue = false;
            //Console.WriteLine(number);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(example);

            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            //int i = 1;
            //byte b = (byte)i;

            //Console.WriteLine(b);

            //var bumber = "1234";
            //int i = Convert.ToInt32(bumber);

            //try
            //{
            //    var num = "1234";
            //    int b = Convert.ToByte(num);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Number cannot be converted");
            //}

            var john = new Person();
            john.firstName = "John";
            john.lastName = "Smith";

            john.Introduce();

            Calculator c = new Calculator();
            c.Add(2, 3);

            //var number = new int[3];

            //number[0] = 1;
            //Console.WriteLine(number[0]);
            //Console.WriteLine(number[1]);
            //Console.WriteLine(number[2]);

            //var number = new string[3];

            //number[0] = "test";
            //Console.WriteLine(number[0]);
            //Console.WriteLine(number[1]);
            //Console.WriteLine(number[2]);

            var fn = "Joshua";
            var ln = "Fernandes";

            var name = new string[2] { fn, ln };

            Console.WriteLine(string.Format("My Name is {0} {1}", fn, ln));
            Console.WriteLine(string.Join(",",name));
        }
    }
}
