using System;

namespace RoomCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to James' Room Calculator");

            Console.WriteLine();
            Console.WriteLine();

            bool again = true;

            do
            {


                Console.WriteLine("Enter Room Length");

                string inputLength = Console.ReadLine();

                double numLength = double.Parse(inputLength);

                Console.WriteLine("Enter Room Width");

                string inputWidth = Console.ReadLine();

                double numWidth = double.Parse(inputWidth);

                Console.WriteLine("Enter Room Height: ");

                string inputHeight = Console.ReadLine();

                double numHeight = double.Parse(inputHeight);

                double area = numLength * numWidth;

                double perimeter = (numLength * 2) + (numWidth * 2);

                double volume = area * numHeight;


                Console.WriteLine("Area: " + area);

                Console.WriteLine();

                Console.WriteLine("Perimeter: " + perimeter);

                Console.WriteLine();

                Console.WriteLine("Volume: " + volume);

                Console.WriteLine();

                Console.WriteLine("Continue? (y/n)");

                string input = Console.ReadLine();

                if (input != "y")
                {
                    again = false;

                }

            } while (again == true);

            

            






            
        }
    }
}
