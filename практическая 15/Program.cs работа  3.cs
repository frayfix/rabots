 interface Price
 {
    double GetPrice(); 
 }

 interface Garant
 {
     int GetGarant();
 }

class Phone : Price, Garant
{
    private double price;
    private int srok;

    public Phone(double p, int s)
    {
         price = p; 
         srok = s;
    }

    public double GetPrice()
    {
        return price;
    }

    public int GetGarant()
    {
        return srok;
    }
}

class Laptop : Price
{
    private double price;

    public Laptop(double p)
    {
        price = p;
    }

     public double GetPrice()
     {
        return price;
     }
}

 class Program
 {
    static void Main()
    {
        var products = new List<object>
        {
            new Phone(20000, 24),
            new Laptop(98000),
            new Phone(15000, 12),
            new Laptop(47000)
        };

        double totalCost = 0;

        foreach (var product in products)
        {
            if (product is Price priceProvider)
            {
                double price = priceProvider.GetPrice();
                totalCost += price;
                Console.WriteLine($"Цена товара: {price}");

                if (product is Garant garantiya)
                {
                    int srok = garantiya.GetGarant();
                    Console.WriteLine($"Срок гарантии: {srok} месяцев");
                }
            }
        }

        Console.WriteLine($"Общая стоимость товаров: {totalCost}");
    }
 }

