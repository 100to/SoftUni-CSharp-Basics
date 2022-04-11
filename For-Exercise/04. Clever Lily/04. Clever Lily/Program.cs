using System;

namespace ForLoopSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double wash = double.Parse(Console.ReadLine());
            int toy = int.Parse(Console.ReadLine());
            int numberToy = 0, brother = 0, cashMultiplayer = 1;
            double money = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10 * cashMultiplayer;
                    cashMultiplayer++;
                    brother++;
                }
                else
                {
                    numberToy++;
                }
            }
            money += (numberToy * toy) - brother;
            if (money >= wash)
            {
                Console.WriteLine($"Yes! {(money - wash):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(wash - money):f2}");
            }
        }
    }
}
