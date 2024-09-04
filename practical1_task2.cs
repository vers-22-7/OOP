using System;

namespace SimpleCalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть значення a (тип float): ");
            string inputA = Console.ReadLine();

            float a = float.Parse(inputA);

            float result = a * (a + a / 2);

            Console.WriteLine("Результат обчислення a * (a + a / 2): " + result);
        }
    }
}
