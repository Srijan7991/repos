using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int []arr = { 23, 56, 33, 221, 56, 32, 663 };
            Console.WriteLine(string.Join(", ",arr));
            int key = Convert.ToInt32(Console.ReadLine());
            for(int i =  0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    Console.WriteLine("Index no. {0}", i);
                    return;
                }
            }
        }
    }
}
