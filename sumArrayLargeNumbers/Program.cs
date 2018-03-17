using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumArrayLargeNumbers
{
    class Program
    {
        static long aVeryBigSum( long[] ar)
        {
            // sums up array and store value in a Long data type
            long sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }

            return sum;

        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            long result = aVeryBigSum( ar);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

}

