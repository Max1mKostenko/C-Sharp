class MusicalInstrument
{
    protected string name, description, history;

    public MusicalInstrument(string name, string description, string history)
    {
        this.name = name;
        this.description = description;
        this.history = history;
    }

    public virtual void Sound() => Console.WriteLine($"{name} sounds.");
    public void Show() => Console.WriteLine($"Name: {name}");
    public void Desc() => Console.WriteLine($"Description: {description}");
    public void History() => Console.WriteLine($"History: {history}");
}

class Guitar : MusicalInstrument
{
    private int numberOfStrings = 6;
    private string material = "Wood";

    public Guitar() : base("Guitar", "String instrument, played by strumming.", "Originated in ancient Spain.") { }
    public override void Sound() => Console.WriteLine($"{name} strums with {numberOfStrings} strings on {material} body.");
}

class Drum : MusicalInstrument
{
    private string drumType = "Snare";
    private int diameter = 14;
    private string material = "Wood";

    public Drum() : base("Drum", "Percussion instrument, produces beats.", "Used for thousands of years.") { }
    public override void Sound() => Console.WriteLine($"{name} beats with a {diameter}-inch {drumType} made of {material}.");
}

class Piano : MusicalInstrument
{
    private int numberOfKeys = 88;
    private string pianoType = "Grand";
    private string brand = "Top Piano";

    public Piano() : base("Piano", "Keyboard instrument, uses hammers.", "Invented by Cristofori.") { }
    public override void Sound() => Console.WriteLine($"{name} plays {numberOfKeys} keys on a {pianoType} by {brand}.");
}

class Program
{
    static void Main()
    {
        Guitar guitar = new Guitar();
        Drum drum = new Drum();
        Piano piano = new Piano();

        guitar.Show();
        guitar.Desc();
        guitar.Sound();
        guitar.History();
        drum.Show();
        drum.Desc();
        drum.Sound();
        drum.History();
        piano.Show();
        piano.Desc();
        piano.Sound();
        piano.History();
    }
}
