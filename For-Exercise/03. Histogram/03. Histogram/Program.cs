using System;

namespace ForLoopSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a;
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a < 200)
                {
                    p1++;
                }
                else if (a >= 200 && a < 400)
                {
                    p2++;
                }
                else if (a >= 400 && a < 600)
                {
                    p3++;
                }
                else if (a >= 600 && a < 800)
                {
                    p4++;
                }
                else if (a >= 800 && a <= 1000)
                {
                    p5++;
                }
            }
            double procent = 100 / Convert.ToDouble(n);
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