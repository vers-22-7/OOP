using System;
//9 Користувач вводить 2 числа, вивести те з них, для якого залишок від ділення на 9 буде найбільшим.
namespace dILENAnA9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть перше число: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            int num2 = int.Parse(Console.ReadLine());

            int CHISLONA9_1 = num1 % 9;
            int CHISLONA9_2 = num2 % 9;

            if (CHISLONA9_1 > CHISLONA9_2)
            {
                Console.WriteLine("Число з більшим залишком від ділення на 9: " + num1);
            }
            else if (CHISLONA9_1 > CHISLONA9_2)
            {
                Console.WriteLine("Число з більшим залишком від ділення на 9: " + num2);
            }
            else
            {
                Console.WriteLine("Обидва числа мають однаковий залишок від ділення на 9");
            }
        }
    }
}
