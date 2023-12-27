using Algorithm.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Models
{
    public class Customer
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<Customer> customers = new List<Customer>
        {
             new Customer{ Age=1, Name="Ken"},
             new Customer{ Age=2, Name="Bill"},
             new Customer{ Age=3, Name="Rose"},
             new Customer{ Age=4, Name="Paul"},
             new Customer{ Age=5, Name="Ben"},
             new Customer{ Age=6, Name="Pet"},
             new Customer{ Age=7, Name="Rob"},
             new Customer{ Age=8, Name="John"}
        };

        public List<int> intList => SampleObjects.SampleIntList();
        public static bool Exists(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return true;
            }
            return false;
        }
        public static int IndexOf(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return 1;

            }
            return -1;
        }


      
    }
}
