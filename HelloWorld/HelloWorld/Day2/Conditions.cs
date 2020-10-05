using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace HelloWorld.Day2
{
    partial class Conditions
    {
        int hour = 10;
        bool isGoldCustomer = true;

        public void GetDay() {
            if (this.hour > 0 && hour < 12)
            {
                Console.WriteLine("It is morning");
            }
            else if (this.hour > 12 && hour < 18)
            {
                Console.WriteLine("It is afternoon");
            }
            else Console.WriteLine("It is night");
        }

        public void GetSeason(Season season)
        {
            switch (season)
            {
                case Season.Autumn: {
                        Console.WriteLine("It is Autumn");
                        break;
                }
                case Season.Summer:
                    {
                        Console.WriteLine("It is Summer");
                        break;
                    }
                case Season.Spring:
                    {
                        Console.WriteLine("It is Spring");
                        break;
                    }
                case Season.Winter: {
                        Console.WriteLine("It is Winter");
                        break;
                }
                default: {
                        Console.WriteLine("No Season exist");
                        break;
                }
            }
        }

        public void GetPrice()
        {
            var price = (isGoldCustomer) ? 15 : 20;

            Console.WriteLine("Price is: " + price);
        }
    }
}
