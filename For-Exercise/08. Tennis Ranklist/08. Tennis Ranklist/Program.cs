using System;

namespace ForLoopSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double newPoints = double.Parse(Console.ReadLine());
            double points = 0, win = 0;
            string game;
            for (int i = 0; i < n; i++)
            {
                game = Console.ReadLine();
                switch (game)
                {
                    case "W":
                        {
                            points += 2000;
                            win++;
                            break;
                        }
                    case "F":
                        points += 1200;
                        break;
                    case "SF":
                        points += 720;
                        break;
                }
            }
            points += newPoints;
            double percent = 100 / Convert.ToDouble(n);
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Round((Convert.ToDouble(points - newPoints)) / n, MidpointRounding.ToNegativeInfinity)}");
            Console.WriteLine($"{Math.Round(win * percent, 2, MidpointRounding.AwayFromZero):f2}%");

        }
    }
}
