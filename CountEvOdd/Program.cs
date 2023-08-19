using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountEvOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countEv = 0;
            int countOdd = 0;
            int[] arr = { 2,3,4,5,9 };
            for(int i =  0; i < arr.Length; i++)
            {
                if ((i%2) == 0)
                {
                    countEv++;
                }
                else if((i%2) != 0)
                {
                    countOdd++;
                }
            }
            Console.WriteLine("Even no are" + countEv);
            Console.WriteLine("odd no are" + countOdd);
        }
    }
}
