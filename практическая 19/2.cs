class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        string[] arr = a.ToLower().Split(' ');
        Dictionary<string, int> keys = new Dictionary<string, int>();
        foreach (string s in arr)
        {
            string s1 = s.Trim();
            if (keys.ContainsKey(s1))
            {
                keys[s1]++;
            }
            else
            {
                keys[s1] = 1;
            }
        }
        foreach (var s in keys)
        {
            Console.WriteLine($"{s.Key} - {s.Value}");
        }
    }
}