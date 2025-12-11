class Programm
{
    static void Main()
    {
        List<string> names = new List<string>() { "Анна", "Петр", "Анна", "Ольга", "Петр", "Иван" };
        List<string> uniqNames = new List<string>();
        foreach (string name in names)
        {
            if (!uniqNames.Contains(name))
            {
                uniqNames.Add(name);
            }
        }
        Console.WriteLine(string.Join(", ", names));
        Console.WriteLine(string.Join(", ", uniqNames));
    }
}
