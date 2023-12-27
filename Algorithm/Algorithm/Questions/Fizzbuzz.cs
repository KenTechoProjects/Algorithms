using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Questions
{
   public class Fizzbuzz
    {
        public static string Print(int number)
        {
            if(number %3==0 &&number % 5 != 0)
            {
                return "Fizz";
            }
            else  if (number % 5 == 0 && number % 3 != 0)
            {
                return "Buzz";
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else
            {
                return Convert.ToString(number);
            }
        }

        public static void PrintP(int number)
        {
            for (int i = 0; i <= number; i++)
            {

         
            if(i %3==0 &&i % 5 != 0)
            {
                Console.WriteLine("Fizz");
            }
            else  if (i % 5 == 0 && i % 3 != 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine(Convert.ToString(i));
            }   }
        }
        public static void FizzBuzzPrint(int min ,int max)
        {   Console.WriteLine("Asseement to print string base on multiple of three, Five , both and none");
                Console.WriteLine("==========================================================================");
            
            for(int i = min; i <= max; i++)
            {
                string result=Print(i);
                 Console.WriteLine( string.Format("{0}:{1}",i,result));
            }
        }
    }
}
