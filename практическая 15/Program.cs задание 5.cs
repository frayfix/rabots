class BankAccount
{
    private decimal Balance { get; set; }

    public BankAccount(decimal b)
    {
        Balance = b;
    }
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Пополнение выполнено успешно. Новый баланс: {Balance}");
        }
        else
        {
            Console.WriteLine("Ошибка: внесите положительное число.");
        }
    }
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Снято {amount}. Остаток: {Balance}");
        }
        else
        {
            Console.WriteLine("Ошибка: недостаточно средств или некорректная сумма.");
        }
    }
    public void Transfer(BankAccount target, decimal amount)
    {
        if (amount > 0 && Balance >= amount)
        {
            Balance -= amount;
            target.Balance += amount;
            Console.WriteLine($"Перечислено {amount} на целевой счёт. Ваш баланс: {Balance}");
        }
        else
        {
            Console.WriteLine("Ошибка: неправильная сумма или нехватка средств.");
        }
    }
    public override string ToString()
    {
        return $"Баланс: {Balance}";
    }
}
class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount(10000);
        BankAccount acc2 = new BankAccount(5000);
        acc1.Transfer(acc2, 3000);
        Console.WriteLine($"Счет 1: {acc1}");
        Console.WriteLine($"Счет 2: {acc2}");
        Console.ReadLine();
    }

}