using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 11, 12, 13, 14, 15, 16, 17 };

            Console.WriteLine("Array Initial State: {0}", string.Join(",", inputArray));
       

            Array.Reverse(inputArray);
            Console.WriteLine("Array After Reversal: {0}", string.Join(",", inputArray));
            
        }
    }
}
