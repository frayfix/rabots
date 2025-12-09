interface OnOff
{
     void TurnOn();

     void TurnOff();
}

interface Level
{
   void SetLevel(int level);
}

class Lamp : OnOff, Level
{
        public int Level { get; set; }
        public bool IsOn { get; set; }

        public void TurnOn()
        {
            IsOn = true;
            Level = 100;
            Console.WriteLine($"Лампа включена. Уровень: {Level}");
        }

        public void TurnOff()
        {
            IsOn = false;
            Level = 0;
            Console.WriteLine($"Лампа выключена. Уровень: {Level}");
        }

        public void SetLevel(int level)
        {
            if (level < 0) level = 0;
            if (level > 100) level = 100;
            Level = level;
            Console.WriteLine($"Уровень лампы установлен на {Level}");
        }
    }

class Ventilator : OnOff
{
        public void TurnOn()
        {
            Console.WriteLine("Вентилятор включен");
        }

        public void TurnOff()
        {
            Console.WriteLine("Вентилятор выключен");
        }
}

class Program
{
         static void Main()
         {
            Lamp l = new Lamp();
            l.TurnOn();
            l.SetLevel(30);
            l.TurnOff();
            Ventilator v = new Ventilator();
            v.TurnOn();
            v.TurnOff();
         }
}