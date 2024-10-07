using System;
// Напишіть метод рекурсивного знаходження суми елементів масиву.
// ну це gpt бо я нічо не пон
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        int sum = SumArray(array, array.Length - 1);

        Console.WriteLine("Сума елементів масиву: " + sum);
    }

    static int SumArray(int[] arr, int index)
    {
        if (index == 0)
        {
            return arr[0];
        }

        return arr[index] + SumArray(arr, index - 1);
    }
}
