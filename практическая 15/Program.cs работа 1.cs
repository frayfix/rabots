
 interface Work
    {
        void Work();
    }

 interface BatteryLevel
    {
    void charger();

    }

 class Robot : Work, BatteryLevel
 {
        public string Name { get; }
        public int Energy { get;  set; }

        public Robot(string n, int e)
        {
            Name = n;
            Energy = e;
        }

        public void Work()
        {
            Energy -= 20;
            if (Energy < 0) Energy = 0;
            Console.WriteLine($"{Name} работает. Энергия: {Energy}");
        }

        public void charger()
        {
            Energy += 50;
            if (Energy > 100) Energy = 100;
            Console.WriteLine($"{Name} заряжается. Энергия: {Energy}");
        }
 }

 class Program
 {
         static void Main()
         {
            Robot robot = new Robot("Робот", 70);
            robot.Work();
            robot.Work();
            robot.charger();
            robot.Work();
         }
 }
