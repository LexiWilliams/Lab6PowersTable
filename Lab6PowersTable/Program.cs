using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                //prompt user to enter integer
                int integer = GetInteger("Please give me an integer.");

                //calculate number squared
                double square1 = GetSquare(integer);

                //calculate number cubed
                double cube1 = GetCube(integer);

                //display a table of squares and cubes from 1 to the value entered
                PrintName("Number", "\t\tSquared", "\t\tCubed");
                PrintLine();

                ListNumbers(integer);

                //prompt user to continue
                bool enterYN = true;
                while (enterYN)
                    {
                    Console.WriteLine("Would you like to enter another number? y/n");
                    string goAgain = Console.ReadLine().ToLower();

                    if (goAgain == "y")
                    {
                        repeat = true;
                        enterYN = false;
                    }
                    else if (goAgain != "y" && goAgain != "n")
                    {
                        Console.WriteLine("Input was not understood.");
                        repeat = false;
                        enterYN = true;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye.");
                        repeat = false;
                        enterYN = false;

                    }
                }


                //
            }
        }

        public static int GetInteger(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                return num;
            }

            return GetInteger($"Invalid input. {message}");
        }

        public static double GetCube(int integer)
        {
            double num1 = Convert.ToDouble(integer);
            double cube = Math.Pow(num1, 3);
            return cube;
        }

        static int tableWidth = 40;

        public static void PrintLine()
        {
            Console.WriteLine(new string('=', tableWidth));
        }

        public static void PrintName(string message1, string message2, string message3)
        {
            Console.WriteLine(message1 + message2 + message3);
        }

        public static void ListNumbers(int integer)
        {
            for (int i = 1; i <= integer; i++)
            {
                Console.WriteLine($"{i}\t\t{GetSquare(i)}\t\t{GetCube(i)}");
            }
        }


        public static double GetSquare(int integer)
        {
            double num1 = Convert.ToDouble(integer);
            double square = Math.Pow(num1, 2);
            return square;
        }
    }
}
