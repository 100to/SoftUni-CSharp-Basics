using System;

namespace ForLoopSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a, sum = 0, max = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                sum += a;
                if (max < a)
                {
                    max = a;
                }
            }
            int withoutMax = sum - max;
            if (max == withoutMax)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                withoutMax -= max;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(withoutMax)}");
            }
        }
    }
}