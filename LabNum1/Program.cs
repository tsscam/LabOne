using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator! ");

            //variables
            Double Length = new Double();
            Double Width = new Double();
            
            while (true)
            {

                Console.WriteLine("Please enter the Length of room: ");
                //double is to allow decimals allows the user type decimal
                Double.TryParse(Console.ReadLine(), out Length);
              
                Console.WriteLine("Please enter the Width of room and Hit Enter: ");
                Double.TryParse(Console.ReadLine(), out Width);
                //validation
               

                Console.WriteLine("The Area of the Room is: " + (Length * Width));
                //double used to allow decimals within the the answer for perimeter
                Double Perimeter = (Convert.ToDouble(Length) + Convert.ToDouble(Width)) * 2;
                Console.WriteLine("The Perimeter of the Room is: " + Perimeter);
                if (ContinueProgram())
                {
                    continue;
                }
                return;

            }
        }
        public static void error()
        {
            Console.WriteLine("Input was not entered correctly. Try Again: ");
        }
        //Console.WriteLine("Do you want to continue? Type 'Y' or 'N': ");
        public static bool ContinueProgram()
        {
            Console.WriteLine("\nContinue? (y / n): ");

            string loop = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (loop == "y")
            {
                return true;

            }
            if (loop == "n")
            {
                return false;
            }
            else
            {
                error();
                return false;
            }
        }
    }
}