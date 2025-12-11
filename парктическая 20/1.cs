class NotEnoughMoneyExption : Exception
{
    public decimal Balance { get; }
    public decimal Summa { get; }
    public NotEnoughMoneyExption(decimal balance, decimal summa)
        : base($"Недостаточно средств! Баланс: {balance}, нужно: {summa}")
    {
        Balance = balance;
        Summa = summa;
    }
}
class WrongPinExption : Exception
{
    public int Attempst { get; }
    public WrongPinExption(int attempst)
        : base($"Неверный PIN! Осталось попыток: {attempst}")
    {
        Attempst = attempst;
    }
}
class ATM
{
    decimal balance;
    int PIN = 1234;
    int attempst = 3;
    public ATM(decimal balance)
    {
        this.balance = balance;
    }
    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            throw new NotEnoughMoneyExption(balance, amount);
        }
        balance -= amount;
        Console.WriteLine($"Снято: {amount}, остаток: {balance}");
    }
    public void EnterPin(int pin)
    {
        if (attempst == 1)
        {
            Console.WriteLine("Карта заблокирована!");
            return;
        }
        if (pin != PIN)
        {
            attempst--;
            throw new WrongPinExption(attempst);
        }
        Console.WriteLine("Пароль принят");
    }
}
class Programm
{
    static void Main()
    {
        ATM atm = new ATM(100);
        Console.WriteLine("Баланс: 500");
        Console.WriteLine("Снимаем: 300...");
        try
        {
            atm.Withdraw(300);
        }
        catch (NotEnoughMoneyExption ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        try
        {
            atm.EnterPin(1000);
        }
        catch (WrongPinExption ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        try
        {
            atm.EnterPin(2000);
        }
        catch (WrongPinExption ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        try
        {
            atm.EnterPin(3000);
        }
        catch (WrongPinExption ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);

        }

    }
}
