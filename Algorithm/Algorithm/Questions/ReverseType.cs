using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Questions
{
    public class ReverseType
    {
        public static void Reverse(string str)
        {
            char[] chr = str.ToCharArray();
            string value = string.Empty;
            for (int i = 0; i < chr.Length; i++)
            {
                value = chr[i] + value;
            }
            Console.WriteLine(value);
        }
        public static void ReverseV2(string str)
        {
            char[] chr = str.ToCharArray();
            var result = chr.OrderByDescending(c => c);
            Console.WriteLine(string.Join("", result));
        }
        public static void ReverseV3(string str)
        {
            string result = string.Join("", str.ToCharArray().OrderByDescending(c => c));

            Console.WriteLine(result);
        }

        public class ReverseInt
        {
            public static void Reverse(int str)
            {
                string result = string.Join("", str.ToString().ToCharArray().Where(p=>int.TryParse(p.ToString(),out int o)).Select(p=>p).OrderByDescending(c => c));
                var resultV = (Convert.ToInt32(result) * Math.Sign(str));
                Console.WriteLine(resultV);
                 
            }

        }

    }
}
