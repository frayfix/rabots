class Program
    {
        static void Main()
        {
            var s = new Score();

            s["Математика"] = 5;
            s["Русский"] = 4;

            Console.WriteLine(s["Математика"]);
            Console.WriteLine(s);
        }
}
