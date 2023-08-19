using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = new int [10]; 
            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
