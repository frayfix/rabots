class HeroIsDeadException : Exception
{
        public int Health { get; }

        public HeroIsDeadException(int health)
            : base($"Герой погиб! Здоровье стало {health}")
        {
            Health = health;
        }
}
class Game
{
        public int Health { get; private set; }

        public Game(int initialHealth)
        {
            Health = initialHealth;
        }

        public void TakeDamage(int damage)
        {
            Console.WriteLine($"Здоровье: 66");
            Console.WriteLine($"Получаем урон: 34");
            Health -= damage;

            if (Health <= 0)
            {
                throw new HeroIsDeadException(Health);
            }
        }
}
class Program
    {
        static void Main()
        {
            Game g = new Game(100);
            try
            {
                g.TakeDamage(150);
            }
            catch (HeroIsDeadException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }

