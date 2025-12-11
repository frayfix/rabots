class Money
{
    public int Rubles { get; set; }
    public int Kopecks { get; set; }

    public Money(int r, int k)
    {
        Rubles = r + k / 100;
        Kopecks = k % 100;
    }

    public static Money operator +(Money m1, Money m2)
    {
        return new Money(m1.Rubles + m2.Rubles, m1.Kopecks + m2.Kopecks);
    }

    public static bool operator ==(Money m1, Money m2)
    {
        return m1.Rubles == m2.Rubles && m1.Kopecks == m2.Kopecks;
    }

    public static bool operator !=(Money m1, Money m2)
    {
        return !(m1 == m2);
    }

    public override string ToString()
    {
        return $"{Rubles} руб {Kopecks} коп";
    }
}
class Program
{
    static void Main()
    {
        Money m1 = new Money(30, 70);
        Money m2 = new Money(15, 50);

        Console.WriteLine($"Сумма денег: {m1 + m2}");
        Console.WriteLine($"Сравнение денег: {m1 == new Money(30, 70)}");
    }
}

