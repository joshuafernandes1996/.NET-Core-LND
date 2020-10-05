using HelloWorld.Day1.Enum;
using HelloWorld.Day2;
using HelloWorld.Day2.Exercises;
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

            Console.WriteLine("==========ENUM===========");
            Console.WriteLine("Enum", EnumExample.example1,EnumExample.example2, EnumExample.example3);
            var method = EnumExample.example3;
            Console.WriteLine((int)method);

            var methodID = 3;
            Console.WriteLine((EnumExample)methodID);
            Console.WriteLine(EnumExample.example3.ToString());

            //Parsing
            var newMethod = "example1";
            var newEnum = (EnumExample)Enum.Parse(typeof(EnumExample), newMethod);
            Console.WriteLine(newEnum);

            Console.WriteLine("==========================");

            Console.WriteLine("\n\n");

            Console.WriteLine("============Ref and Value Types==============");
            var a = 10;
            var b = a;

            ++a;

            Console.WriteLine("a:{0},b:{1}",a,b);

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;

            array2[0] = 0;

            Console.WriteLine("arr1[0]={0} , arr2[0]={1}", array1[0],array2[0]);

            Console.WriteLine("=============================================");

            Console.WriteLine("===================CONDITIONS===================");
            var cond = new Conditions();

            cond.GetDay();
            cond.GetPrice();
            cond.GetSeason(Conditions.Season.Winter);

            Console.WriteLine("===================EXERCISE 1===================");
            var ex1 = new IsValidNumber();
            ex1.CheckNumber();

        }
    }
}
