public struct Color
{
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }
    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }
    public override string ToString()
    {
        return $"RGB({R}, {G}, {B})";
    }
}
class Program
{
    static void Main()
    {
        Color c = new Color(255, 128, 0);
        Color c1 = c;
        c1.R = 100;
        Console.WriteLine(c);
        Console.WriteLine(c1);
    }
}