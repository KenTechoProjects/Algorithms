using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
   public class BuiltDemo
    {

        public class BuiltInList
        {
            public static void BIL()
            {
            var data=    SampleObjects.SampleIntList();
                data.Sort((left, right) =>
                {
                    if (left > right)
                    {
                        return 1;
                    }
                    else if (right > left)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                });
                Console.Write(string.Join(" ", data));
            }
        }

      
    }
}
