using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");

            bool run = true;
            double length;
            double width;
            double height;
            double area;
            double perimeter;
            double volume;

            //inputs
            while (run == true)
            {
                Console.WriteLine("Please enter the length of the room, in inches:");
                length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the room, in inches:");
                width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height of the room, in inches:");
                height = double.Parse(Console.ReadLine());

                area = Area(length, width);
                perimeter = Perimeter(length, width);
                volume = Volume(length, width, height);

                //output
                Console.WriteLine("The area of the room is {0} square inches, the perimeter is {1} inches, \n and the volume is {2} cubic inches", area, perimeter, volume);

                //asks user if they want to continue calculations
                while (true)
                {
                    Console.WriteLine("Would you like to continue? (y/n)");
                    string choice = Console.ReadLine();

                    if (choice.ToUpper() == "Y" || choice.ToUpper() == "YES")
                    {
                        break;
                    }
                    else if (choice.ToUpper() == "N" || choice.ToUpper() == "NO")
                    {
                        run = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'y' or 'n'.");
                    }
                }

            }
        }


        //calculations for area and perimeter
        public static double Area(double l, double w)
        {
            double A = l * w;
            return A;
        }

        public static double Perimeter(double l, double w)
        {
            double P = 2 * l + 2 * w;
            return P;
        }

        public static double Volume(double l, double w, double h)
        {
            double V = l * w * h;
            return V;
        }
    }
}