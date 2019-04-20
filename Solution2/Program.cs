using System;

namespace Solution2
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
            Array.Sort(arr);
            int firstNum = arr[0];
            int lastNum = arr[1];
            return (lastNum - firstNum + 1) * (firstNum + lastNum) / 2;
        }
    }
}
