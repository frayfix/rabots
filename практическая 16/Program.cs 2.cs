class Score
{
        private string[] subjects = new string[100];
        private int[] scores = new int[100];
        private int count = 0;

        public int GetScore(string subject)
        {
            for (int i = 0; i < count; i++)
            {
                if (subjects[i] == subject)
                {
                    return scores[i];
                }
            }
            return 0;
        }

        public void SetScore(string subject, int score)
        {
            for (int i = 0; i < count; i++)
            {
                if (subjects[i] == subject)
                {
                    scores[i] = score;
                    return;
                }
            }
            subjects[count] = subject;
            scores[count] = score;
            count++;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += $"{subjects[i]}: {scores[i]}\n";
            }
            return result.TrimEnd();
        }
}

 class Program
 {
    static void Main()
    {
            Score s = new Score();
            s.SetScore("Математика", 4);
            s.SetScore("Русский", 5);
            s.SetScore("Физика", 2);

            Console.WriteLine(s.GetScore("Математика"));
            Console.WriteLine(s);
     }
 }