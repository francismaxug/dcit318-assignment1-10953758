using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ticketPriceCalculator
{
    internal class Program
    {

        static void Main(string[] args)

        {
            int age;
            Console.Write("Please Enter Your age and get your ticked amount ");
            age = Convert.ToInt32(Console.ReadLine());
           PrintDiscountAlert(age);
            Console.ReadKey();
        }

        static void PrintDiscountAlert(int age)
        {
            int originalPrice = 10;
            int discountAmount = 7;
            int discountedPrice = originalPrice - discountAmount;
            bool discountForSeniorCitizenAndChildren = age <= 12 || age >= 65;

            if(age<0)
            {
                Console.WriteLine("Negative ages are not allowed");
                return;
            }

            if (discountForSeniorCitizenAndChildren)
            {
                Console.WriteLine($"Your ticket amount is {discountedPrice}. You were given a discount of {discountAmount} Ghana Cedis");
            }
            else
            {
                Console.WriteLine($"Your ticket amount is {discountAmount}. No discount was applied!!!");

            }
        }
    }
}