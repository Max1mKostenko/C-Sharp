abstract class Worker
{
    public abstract void Print();
}

class President : Worker
{
    public override void Print() => Console.WriteLine("I am President");
}

class Security : Worker
{
    public override void Print() => Console.WriteLine("I am Security");
}

class Manager : Worker
{
    public override void Print() => Console.WriteLine("I am Manager");
}

class Engineer : Worker
{
    public override void Print() => Console.WriteLine("I am Engineer");
}

class Program
{
    static void Main()
    {
        Worker[] workers = { new President(), new Security(), new Manager(), new Engineer() };

        foreach (Worker worker in workers)
        {
            worker.Print();
        }
    }
}
