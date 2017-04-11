using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {


            // Declare Variables
            int input;
            string name;
           


            // Name Input
            Console.WriteLine("Please Enter Your Name: ");
            name = Console.ReadLine();
            Console.WriteLine();


            // Number Input
            Console.WriteLine(name + ", Enter a Number Between 1 and 100: ");
            Console.WriteLine();


            // Number Validation
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine(name + ", Please Enter a Number Between 1 and 100:   ");
                Console.WriteLine();
            }


            // Spacing
            Console.WriteLine();


            // Process
            //if (input > 100 || input < 1)
            //{
            //    Console.WriteLine("Please Enter a Valid Number Between 1 and 100");
            //}
            if (input % 2 != 0)
            {

                Console.WriteLine("The Number " + input + " is Odd.");
            }

            else if (input % 2 == 0 && input >= 2 && input <= 25)
            {

                Console.WriteLine("The Number " + input + " is Even and Less Than 25.");
            }

            else if (input % 2 == 0 && input >= 26 && input <= 60)
            {

                Console.WriteLine("The Number " + input + " is Even.");
            }

            else if (input % 2 == 0 && input > 60)
            {

                Console.WriteLine("The Number " + input + " is Even.");
            }

            else if (input % 2 != 0 && input > 60)
            {

                Console.WriteLine("The Number " + input + " is Odd.");
            }

        }
    }
}
