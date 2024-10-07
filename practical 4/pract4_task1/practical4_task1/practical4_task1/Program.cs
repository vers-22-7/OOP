using System;
// Напишіть метод, який приймає два числа і оператор (‘+’, ‘-’, ‘*’, ‘/’), виконує  відповідну математичну операцію і повертає результат. Напишіть програму обрахунку виразів введених користувачем, використовуючи метод.

namespace kankylator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть перше число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введіть дію (+, -, *, /): ");
            char operation = char.Parse(Console.ReadLine());
            double result = 0;

            static int plus(int num1, int num2)
            {return num1 + num2;}

            static int minus(int num1, int num2)
            {return num1 - num2;}

            static int mnogena(int num1, int num2)
            {return num1 * num2;}

            static double dilena(int num1, int num2)
            {
                if (num2 != 0)
                {
                    return (double)num1 / num2;
                }
                else
                {
                    Console.WriteLine("Помилка: ділення на нуль!");
                    return 0;
                }
            }
            
            if (operation == '+')
            {result = plus(a, b);}

            else if (operation == '-')
            {result = minus(a, b);}

            else if (operation == '*')
            {result = mnogena(a, b);}

            else if (operation == '/')
            {result = dilena(a, b);}

            else
            {Console.WriteLine("Невірний оператор!");
                return; 
            }

            Console.WriteLine($"Результат: {a} {operation} {b} = {result}");
        }

    }
}