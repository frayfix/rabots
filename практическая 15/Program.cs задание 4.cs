interface Attack
{
    void Attack();
}
interface Heal
{
    void Heal();
}
class Warrior : Attack
{
    public void Attack()
    {
        Console.WriteLine("Воин атакует!");
    }
}

class Mage : Attack, Heal
{
    public void Attack()
    {
         Console.WriteLine("Маг атакует!");
    }

     public void Heal()
     {
         Console.WriteLine("Маг лечит!");
     }
}
class Program
{
      static void Main()
      {
            List<object> characters = new List<object>
            {
                new Warrior(),
                new Mage()
            };

            Console.WriteLine("Все умеющие атаковать:");
            foreach (var character in characters)
            {
                if (character is Attack attacker)
                {
                    attacker.Attack();
                }
            }

            Console.WriteLine("Только умеющие лечить:");
            foreach (var character in characters)
            {
                if (character is Heal healer)
                {
                    healer.Heal();
                }
            }
      }
}


