
class Instrument
{
    public virtual void Play()
    {
        Console.WriteLine("Играет музыка...");
    }
}

class Guitar : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Брень-брень!");
    }
}

class Drum : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Бум-бум!");
    }
}

class ProgramMusicInstruments
{
    static void Main()
    {
        Instrument[] band = { new Guitar(), new Drum(), new Instrument() };
        foreach (var i in band)
        {
            i.Play();
        }
        Console.ReadLine();
    }
}