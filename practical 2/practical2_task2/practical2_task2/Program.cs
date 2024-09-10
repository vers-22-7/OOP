using System;
//Гра в кості. Програма та гравець викидають кості від 1 до 6 протягом 5 раундів. Виграє той, хто набрав найбільшу суму.  Вивести кожен раунд та переможця.

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random chislo = new Random();
            int[] RollsP = new int[5];
            int[] RollsPC = new int[5];
            int P = 0;
            int PC = 0;
            int round = 0;

            for (int i = 0; i < 5; i++)
            {
                RollsP[i] = chislo.Next(1, 7);
                RollsPC[i] = chislo.Next(1, 7);
            }
            while (true)
            {
                if (round >= 5)
                    break;
                Console.WriteLine($"Раунд {round + 1}: Гравець викинув {RollsP[round]}, Комп'ютер викинув {RollsPC[round]}");
                if (RollsP[round] > RollsPC[round])
                {
                    Console.WriteLine("Гравець виграв цей раунд!");
                    P++;
                }
                else if (RollsPC[round] > RollsP[round])
                {
                    Console.WriteLine("Комп'ютер виграв цей раунд!");
                    PC++;
                }
                else
                {
                    Console.WriteLine("Нічия в цьому раунді!");
                }
                round++;
                Console.WriteLine();
            }
            Console.WriteLine($"Загальний рахунок: Гравець {P}, Комп'ютер {PC}");
            if (P > PC)
            {
                Console.WriteLine("Гравець виграв гру!");
            }
            else if (PC > P)
            {
                Console.WriteLine("Комп'ютер виграв гру!");
            }
            else
            {
                Console.WriteLine("Гра закінчилася внічию!");
            }
        }

    }
}