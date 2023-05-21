public abstract class Toy
{
    public string? Name { get; set; }
    public string? Manufacturer { get; set; }
    public decimal Price { get; set; }
    public int AgeLimit { get; set; }

    public Toy(string name)
    {
        Name = name;
        Console.WriteLine("Toy constructor");
    }

    public abstract void Play();

    public virtual void Stop()
    {
        Console.WriteLine("Stopping the toy");
    }

}
public class BoardGame : Toy
{
    public int NumberOfPlayers { get; set; }
    public bool HasDice { get; set; }

    public BoardGame(string Name): base(Name)
    {
        Console.WriteLine("BoardGame constructor");
    }

    public override void Play()
    {
        Console.WriteLine("Playing with toy boardGame");
    }

}
public sealed class ActionFigure : Toy
{
    public string? CharacterName { get; set; }

    public ActionFigure(string name, string characterName)
        : base(name)
    {
        CharacterName = characterName;
        Console.WriteLine("ActionFigure constructor");
    }

    public override void Play()
    {
        Console.WriteLine($"Playing with {Name ?? "Unknown"}, actionFigure");
    }
    public new void Stop()
    {
        Console.Write("ActionFigure ");
        base.Stop();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Toy toy1 = new BoardGame("Monopoly");
        toy1.Manufacturer = "Hasbro";
        toy1.AgeLimit = 8;

        toy1.Play();  // Вызов абстрактного метода Play()
        toy1.Stop();  // Вызов виртуального метода Stop()

        Console.WriteLine();

        Toy toy2 = new ActionFigure("Superman", "Man");
        toy2.Manufacturer = "DC Comics";
        toy2.AgeLimit = 5;

        toy2.Play();  // Вызов абстрактного метода Play()
        toy2.Stop();  // Вызов переопределенного метода Stop()

    }
}
