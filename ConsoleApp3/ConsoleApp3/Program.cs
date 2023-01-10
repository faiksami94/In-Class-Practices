using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {// See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");


            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + " Please enter any number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
            if (number < 0)
                Console.WriteLine(number + " is smaller than zero");
            else if (number > 0)
                Console.WriteLine(number + " is greater than zero");
            else
                Console.WriteLine(number + " is equal to zero");
            Console.ReadKey();


            Console.WriteLine("Welcome, Please enter your name");
            string name2 = Console.ReadLine();
            Console.WriteLine(name + "Please enter the month you were born as a number");
            string number2 = Convert.ToInt16(Console.ReadLine);
            switch (number <= 13)
            {
                case "1": Console.WriteLine("January"); break;
                case "2": Console.WriteLine("february"); break;
                case "3": Console.WriteLine("march"); break;
                case "4": Console.WriteLine("april"); break;
                case "5": Console.WriteLine("may"); break;
                case "6": Console.WriteLine("june"); break;
                case "7": Console.WriteLine("july"); break;
                case "8": Console.WriteLine("august"); break;
                case "9": Console.WriteLine("september"); break;
                case "10": Console.WriteLine("october"); break;
                case "11": Console.WriteLine("november"); break;
                case "12": Console.WriteLine("december"); break;
                default:
                    Console.WriteLine("There is no such month in a year");
                    break;

            }

            Console.WriteLine("Hello, Please enter the number of the day in a week");
            string number3 = Console.ReadLine();
            switch (number3)
            {
                case "1": Console.WriteLine("The first day of the week is monday"); break;
                case "2": Console.WriteLine("The second day of the week is tuesday"); break;
                case "3": Console.WriteLine("The third day of the week is wednesday"); break;
                case "4": Console.WriteLine("The fourth day of the week is thursday"); break;
                case "5": Console.WriteLine("The fifth day of the week is friday"); break;
                case "6": Console.WriteLine("The sixth day of the week is saturday"); break;
                case "7": Console.WriteLine("The seventh and final day of the week is sunday"); break;
                default:
                    Console.WriteLine("A week is 7 days");
                    break;


            }

            Console.WriteLine("Please enter your color");
            string color = Console.ReadLine();
            switch (color)
            {
                case "red": Console.WriteLine("Stop & Wait"); break;
                case " yellow": Console.WriteLine("Get Ready"); break;
                case " green ": Console.WriteLine("Go"); break;
                default:
                    Console.WriteLine("There is no such color");
                    break;

            }
        }
    }
}
