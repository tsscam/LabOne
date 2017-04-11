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
            {
            start:
                Double Length = new Double();
                Double Width = new Double();
                {
                    Console.WriteLine("Welcome to Grand Circus' Room Detail Generator! ");
                    Console.WriteLine("Please enter the Length of room: ");
                    //double is to allow decimals allows the user type decimal
                    Double.TryParse(Console.ReadLine(), out Length);
                    
                    Console.WriteLine("Please enter the Width of room: ");
                    Double.TryParse(Console.ReadLine(), out Width);

                    Console.WriteLine("The Area of the Room is: " + (Length * Width));
                    //double used to allow decimals within the the answer for perimeter
                    Double Perimeter = (Convert.ToDouble(Length) + Convert.ToDouble(Width)) * 2;
                    Console.WriteLine("The Perimeter of the Room is: " + Perimeter);

                    Console.WriteLine("Do you want to continue? Type 'Y' or 'N': ");
                    string answerYOrN = Console.ReadLine();
                    //if YOrN is the same as if YesOrNo
                    if (answerYOrN == "y")
                    {
                        //returns to the beginning
                        goto start;
                    }
                    if (answerYOrN == "n")
                    {
                        //exits the program
                        return;
                    }
                }
            }
        }
    }
}