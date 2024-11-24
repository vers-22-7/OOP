using System;

abstract class BankAccount
{
    protected double Balance;

    public BankAccount(double initialBalance)    {
        Balance = initialBalance;
    }

    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);

    public override string ToString()    {
        return $"Баланс: {Balance} грн";
    }
}

class DepositAccount : BankAccount{
    public DepositAccount(double initialBalance) : base(initialBalance) { }

    public override void Deposit(double amount)    {
        Balance += amount;
        Console.WriteLine($"Ви поповнили рахунок на {amount} грн. Поточний баланс: {Balance} грн.");
    }

    public override void Withdraw(double amount)    {
        if (amount > Balance)        {
            Console.WriteLine("Недостатньо коштів на рахунку! Зняття неможливе.");
        }
        else        {
            Balance -= amount;
            Console.WriteLine($"Ви зняли {amount} грн. Поточний баланс: {Balance} грн.");
        }
    }
}

class CreditAccount : BankAccount{
    private double Limit;
    private const double FeeRate = 0.05;

    public CreditAccount(double initialBalance, double limit) : base(initialBalance)    {
        Limit = limit;
    }

    public override void Deposit(double amount)    {
        Balance += amount;
        Console.WriteLine($"Ви поповнили рахунок на {amount} грн. Поточний баланс: {Balance} грн.");
    }

    public override void Withdraw(double amount)    {
        double totalAmount = amount > Balance ? amount + (amount * FeeRate) : amount;

        if (Balance - totalAmount < -Limit)        {
            Console.WriteLine("Перевищено кредитний ліміт! Зняття неможливе.");
        }
        else        {
            Balance -= totalAmount;
            Console.WriteLine($"Ви зняли {amount} грн (з урахуванням комісії). Поточний баланс: {Balance} грн.");
        }
    }
}

class Program{
    static void Main(string[] args)    {
        while (true)        {
            Console.WriteLine("\nВиберіть дію:");
            Console.WriteLine("1 - Вибрати тип рахунку");
            Console.WriteLine("2 - Завершити програму");
            int mainAction = int.Parse(Console.ReadLine());

            if (mainAction == 2)            {
                Console.WriteLine("Дякуємо за використання програми! До побачення!");
                break;
            }
            else if (mainAction == 1)            {
                BankAccount account = null;

                Console.WriteLine("\nВиберіть тип рахунку (1 - Депозитний, 2 - Кредитний): ");
                int accountType = int.Parse(Console.ReadLine());

                if (accountType == 1)                {
                    account = new DepositAccount(1000);
                }
                else if (accountType == 2)                {
                    account = new CreditAccount(500, 1000);
                }
                else                {
                    Console.WriteLine("Неправильний вибір типу рахунку! Спробуйте ще раз.");
                    continue;
                }

                while (true)                {
                    Console.WriteLine("\nВиберіть дію:");
                    Console.WriteLine("1 - Поповнити рахунок");
                    Console.WriteLine("2 - Зняти кошти");
                    Console.WriteLine("3 - Перевірити баланс");
                    Console.WriteLine("4 - Повернутися до вибору типу рахунку");
                    int action = int.Parse(Console.ReadLine());

                    if (action == 1)                    {
                        Console.Write("Введіть суму для поповнення: ");
                        double amount = double.Parse(Console.ReadLine());
                        account.Deposit(amount);
                    }
                    else if (action == 2)                    {
                        Console.Write("Введіть суму для зняття: ");
                        double amount = double.Parse(Console.ReadLine());
                        account.Withdraw(amount);
                    }
                    else if (action == 3)                    {
                        Console.WriteLine(account.ToString());
                    }
                    else if (action == 4)                    {
                        Console.WriteLine("Повертаємося до вибору типу рахунку...");
                        break;
                    }
                    else                    {
                        Console.WriteLine("Неправильний вибір! Спробуйте ще раз.");
                    }
                }
            }
            else            {
                Console.WriteLine("Неправильний вибір! Спробуйте ще раз.");
            }
        }
    }
}
