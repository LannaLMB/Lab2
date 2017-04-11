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


            // Validation
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please Enter a Number Between 1 and 100: ");
            }


            if (input % 2)
        }
    }
}
