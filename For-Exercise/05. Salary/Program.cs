using System;

namespace ForLoopSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            string site;
            for (int i = 0; i < n; i++)
            {
                site = Console.ReadLine();
                switch (site)
                {
                    case "Facebook":
                        money -= 150;
                        break;
                    case "Instagram":
                        money -= 100;
                        break;
                    case "Reddit":
                        money -= 50;
                        break;
                }
            }
            if (money <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(Convert.ToInt32(money));
            }
        }
    }
}
