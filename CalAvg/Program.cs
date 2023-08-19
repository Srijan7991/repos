using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalAvg
{
    internal class Program
    {
        static void Main(string[] args) {
            int sum = 0;
            int avg;
        float[] arr = new float[10];
            for(int i = 0; i < arr.Length; i++)
            {
               sum = sum + i;
            }
            avg = sum/10;
            Console.WriteLine(avg);
        }
    }
}
