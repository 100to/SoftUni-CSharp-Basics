using System;

namespace ForLoopSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string jury;
            double juryPoints;
            for (int i = 0; i < n; i++)
            {
                jury = Console.ReadLine();
                juryPoints = double.Parse(Console.ReadLine());
                points += Math.Round(((juryPoints * jury.Length) / 2), 2, MidpointRounding.AwayFromZero);
                if (points > 1250.5)
                {
                    i = n;
                }
            }
            if (points > 1250.5)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - points:f1} more!");
            }
        }
    }
}
