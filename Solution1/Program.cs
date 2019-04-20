using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumRange(new int[] {3,1}));
            Console.WriteLine(SumRange(new int[] {1,4}));
        }

        static int SumRange(int[] arr)
        {
            int max = Math.Max(arr[0], arr[1]);
            int min = Math.Min(arr[0], arr[1]);
            int res = 0;
            for (int i = min; i <= max; i++)
            {
                res += i;
            }
            return res;
        }
    }
}
