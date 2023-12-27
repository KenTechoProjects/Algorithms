using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Questions
{
   public class Fibonacci
    {
        public static int Fib(int n)
        {
            int result = 0;
            if (n < 2) { return n; }
            else
            {
             return  Fib(n - 1) + Fib(n - 2);
            }
            
        }

        public static void PrintFibonacci(int numberCount)
        {
            Console.WriteLine("Series Problem");
            for(int n = 1; n <= numberCount; n++)
            {
                int result = Fib(n);
                Console.Write(" " + result);
            }
        }
    }
}
