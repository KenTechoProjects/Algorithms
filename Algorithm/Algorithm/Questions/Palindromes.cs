using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Questions
{
    public class Palindromes
    {
        public static void IsPalindrome(string str)
        {
            string revers = Rervers(str);
            if (revers == str) Console.WriteLine(revers + " " + true.ToString());
            Console.WriteLine(revers + " " + false.ToString());

        }
        public static void IsPalindromeV2(string str)
        {
            bool result = ValidatePalindrome(str);
            Console.WriteLine(str + " " + result.ToString());


        }

        private static bool ValidatePalindrome(string str)
        {
            bool isPal = true;
            int count = str.Length;
            if (count == 1)
            { return true; }
            else
            {


                if (count % 2 == 0)
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] != ' ' && str[i] != ',')
                        { if (str[i] != str[count - (i + 1)]) return false; }
                        
                    }

                }
                else
                {
                   
                    for (int i = 0; i < str.Length; i++)
                    {

                        if (i == (count - i))
                        { break; }
                        else
                        {
                            if (str[i] != ' ' && str[i] != ',')
                            {
                                if (str[i] != str[count - (i + 1)]) return false;
                            }
                             

                        }


                    }
                }
            }
            return isPal;
        }
        private static string Rervers(string value)
        {
            char[] str = value.ToArray();
            string data = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                data = str[i] + data;
            }

            return data;
        }
    }
}
