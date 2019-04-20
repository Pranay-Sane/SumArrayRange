using System;
using System.Linq;

namespace Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumRange(new int[] { 3, 1 }));
            Console.WriteLine(SumRange(new int[] { 1, 4 }));
        }

        static int SumRange(int[] arr)
        {
            int res = 0;
            for(int i = arr.Min(); i <= arr.Max(); i++)
            {
                res += i;
            }
            return res;
        }
    }
}
