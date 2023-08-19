using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLarElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2,5,9,23,6,15,56};
            int largest = 0;
            for(int i =  0; i < arr.Length; i++)
            {
                if (arr[i] >= largest)
                {
                    largest = arr[i];
                }
            }
            Console.WriteLine(largest);
        }
    }
}
