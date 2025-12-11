public class Order
{
    public int Id { get; set; }
    public decimal Total { get; set; }
}
class Program
{
    static void Main()
    {
        Order o = new Order { Id = 1001, Total = 1500.50m };
        Order order1 = o;
        order1.Total = 2000.00m;

        Console.WriteLine(o.Total);
    }
}