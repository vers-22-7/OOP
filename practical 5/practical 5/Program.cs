using System.Text.RegularExpressions;

public class Program{
    public static void Main(){
        Regex regex = new Regex(@"(\d{1,3})([+-])(\d{1,3})=(\d{1,4})");

        Console.WriteLine("Введіть вираз: ");
        string input = Console.ReadLine();

        Match match = regex.Match(input);

        if (match.Success)
        {
            int leftOperand = int.Parse(match.Groups[1].Value);   // перше число
            string operation = match.Groups[2].Value;             // оператор (+ або -)
            int rightOperand = int.Parse(match.Groups[3].Value);  // друге число
            int result = int.Parse(match.Groups[4].Value);        // результат

            int calculatedResult = 0;
            if (operation == "+"){
                calculatedResult = leftOperand + rightOperand;}

            else if (operation == "-"){
                calculatedResult = leftOperand - rightOperand;}

            if (calculatedResult == result){
                Console.WriteLine("Вираз правильний!");}

            else
            {Console.WriteLine($"Неправильний вираз! Очікуваний результат: {calculatedResult}, але вказано: {result}");}
        }
        else
        {Console.WriteLine("Невірний формат виразу. Підтримувані формати: 15+4=19 або 20-5=15");
        }
    }
}
