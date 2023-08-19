using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipliesElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            
            int multiply()
            {
                int mul = 1;
                for (int i = 0; i < arr.Length; i++)
                    mul = mul * arr[i];
                return mul;
            }

            Console.Write(multiply());
        }
    }
}
