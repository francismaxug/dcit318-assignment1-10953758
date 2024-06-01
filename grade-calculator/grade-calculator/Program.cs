using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {

        static void Main(string[] args)

        {
            int number;
            Console.WriteLine("Hello User, please enter a number from 0 t0 100 and i will tell you the grade in which that number falls ");
            number = Convert.ToInt32(Console.ReadLine());
            PrintGrade(number);
            Console.ReadKey();
        }

        static void PrintGrade(int number)
        {
            bool grade_A = number >= 90 && number <=100;
            bool grade_B = number >= 80 && number <= 89;
            bool grade_C = number >= 70 && number <= 79;
            bool grade_D = number >= 60 && number <= 69;
            if (number< 0 || number>100)
            {
                Console.WriteLine($"{number} is not permisible");
            }
            else if(grade_A)
            {
                Console.WriteLine($"{number} is an A grade");
            }
            else if (grade_B)
            {
                Console.WriteLine($"{number} corresponds to a  B grade");
            }
            else if (grade_C)
            {
                Console.WriteLine($"{number} corresponds to a  C grade");
            }
            else if (grade_D)
            {
                Console.WriteLine($"{number} corresponds to a  D grade");
            }
            else
            {
                Console.WriteLine($"{number} is an F grade");
            };
            
        }
    }
}