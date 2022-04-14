using System;

namespace ForLoopSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a, sum = 0;
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a <= 5)
                {
                    p1 += a;
                }
                else if (a > 5 && a < 13)
                {
                    p2 += a;
                }
                else if (a >= 13 && a < 26)
                {
                    p3 += a;
                }
                else if (a >= 26 && a < 41)
                {
                    p4 += a;
                }
                else if (a >= 41)
                {
                    p5 += a;
                }
                sum += a;
            }
            double procent = 100 / Convert.ToDouble(sum);
            p1 *= procent;
            p2 *= procent;
            p3 *= procent;
            p4 *= procent;
            p5 *= procent;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
