using System;

namespace AnnInCoffeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ласкаво просимо до кав'ярні! Як вас звати?: ");
            string name = Console.ReadLine();
            Console.WriteLine("Привіт, " + name + "! Що ви хочете замовити?");
            string choiseDrink = Console.ReadLine();
            Console.WriteLine("Великий або малий розмір?");
            string choiseSize = Console.ReadLine();

            if (choiseSize != "великий" && choiseSize != "малий")
            {
                Console.WriteLine("Розмір має бути тільки великим або малим.");
            }
            else
            {
                Console.WriteLine("Замовлення: Ім’я: " + name);
                Console.WriteLine("Замовлення: " + choiseDrink + " " + choiseSize);
            }
        }
    }
}