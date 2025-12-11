using System;

public struct Weather
{
    public string City { get; set; }
    public double? Temperature { get; set; }

    public override string ToString()
    {
        string tempStr = Temperature.HasValue ? $"{Temperature.Value}°C" : "Нет данных";
        return $"{City}: {tempStr}";
    }
}
class Program
{
    static void Main()
    {
        Weather w = new Weather { City = "Москва", Temperature = 20.5 };
        Weather w1 = new Weather { City = "Сочи", Temperature = null };

        Console.WriteLine(w);
        Console.WriteLine(w1);
        Console.WriteLine(w1.Temperature ?? -999);
    }
}