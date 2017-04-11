using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {


            // Declare Variables
            int input;


            // Input
            Console.WriteLine("Enter a Number Between 1 and 100: ");
            Console.WriteLine();


            // Validation
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please Enter a Number Between 1 and 100:   ");
                Console.WriteLine();
            }


            // Spacing
            Console.WriteLine();


            // Process
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

        }
    }
}
