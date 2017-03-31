using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Factorial
{
    class Program
    {
        public static bool Continue()
        {
            Console.WriteLine("Continue? (y/n)");
            string input = Console.ReadLine();

            input.ToLower();
            bool run;

            if(input == "n")
            {
                Console.WriteLine("Goodbye!");
                run = false;
            }
            else if(input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("Sorry, that input is not valid.");
                run = Continue();
            }
            return run;
        }


        static void Main(string[] args)
        {
            //prompt user to enter an integer from 1 to 10
            Console.WriteLine("Please Enter a number from 1 to 10: ");
            long num = long.Parse(Console.ReadLine());
            
            bool run = true;

            long factorial = 1;

            for (long i = 1; i <= num; i ++)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial of is :" + factorial);
            run = Continue();
            //display the factorial of the number entered
            //prompt the user to continue

        }
    }
}
