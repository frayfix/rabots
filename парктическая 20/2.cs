class ProductOutOfStockException : Exception
{
    string Tovar { get; }

    int Stock {  get; }

    public ProductOutOfStockException(string t, int s)
        : base ($"Товар \"{t}\" закончился! ")
    {
        Tovar = t; 
        Stock = s;
    }
}
class OnlineShop
{
    Dictionary<string, int> product = new Dictionary<string, int>();

    public OnlineShop()
    {
        product["iphone"] = 0;
        product["apple"] = 12;
        product["banan"] = 31;
    }
    public void Buy(string t, int s)
    {
        if(s > product[t])
        {
            throw new ProductOutOfStockException(t, s);
        }
        product[t] -= s;
        Console.WriteLine($"купили {t}, осталось {product[t]} штук ");
    }
}
class Program
{
    static void Main()
    {
        OnlineShop o = new OnlineShop();
        try
        {
            o.Buy("iphone", 4);
        }
        catch (ProductOutOfStockException a)
        {
            Console.WriteLine($"Ошибка {a.Message}");
        }
        try
        {
            o.Buy("banan", 15);
        }
        catch (ProductOutOfStockException a)
        {
            Console.WriteLine($"Ошибка {a.Message}");
        }
    }
}