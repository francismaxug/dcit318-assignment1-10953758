using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace triangleTypeIdentifier
{
    internal class Program
    {

        static void Main(string[] args)

        {
            int firstSize;
            int secondSize;
            int thirdSize;

            Console.Write("Hello User, you are to input three sizes of a Triangle and i will tell you which type of Triangle is is:   ");
            Console.Write("Please Enter FIRST SIZE: ");
            firstSize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter SECOND SIZE: ");
            secondSize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter THIRD SIZE: ");
            thirdSize = Convert.ToInt32(Console.ReadLine());

            PrintDiscountAlert(firstSize, secondSize,thirdSize);
            Console.ReadKey();
        }

        static void PrintDiscountAlert(int firstSize, int secondSize, int thirdSize)
        {
            //Triangle types

            bool equilateral = firstSize == secondSize && firstSize == thirdSize;
            bool isosceles = (firstSize == thirdSize || firstSize == secondSize || secondSize == thirdSize);
            //bool scalene = !equilateral && !isosceles;
           

          

            if (equilateral)
            {
                Console.WriteLine("Triangle with All sizes eqaul is an Equalateral Triangle" );
            }
            else if (isosceles)
            {
                Console.WriteLine("Triangle with two size eqaul is an Isoscele Triangle");
            }
            else
            {
                Console.WriteLine("Triangle with NO size eqaul is a scalen Triangle");
            }
            
        }
    }
}