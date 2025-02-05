namespace ConsoleApp9
{
    class Airplane
    {
        public string name;
        public string manufacturer;
        public int year;
        public string type;
        public Airplane() {}
        public Airplane(string name, string manufacturer, int year, string type)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.year = year;
            this.type = type;
        }

        public void SetName(string name) => this.name = name;
        public string GetName() => name;

        public void SetManufacturer(string manufacturer) => this.manufacturer = manufacturer;
        public string GetManufacturer() => manufacturer;

        public void SetYear(int year) => this.year = year;
        public int GetYear() => year;

        public void SetType(string type) => this.type = type;
        public string GetType() => type;

        public void InputData()
        {
            Console.Write("Enter airplane name: ");
            name = Console.ReadLine();

            Console.Write("Enter manufacturer: ");
            manufacturer = Console.ReadLine();

            Console.Write("Enter year of manufacture: ");
            year = int.Parse(Console.ReadLine());

            Console.Write("Enter airplane type: ");
            type = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine($"Airplane Name: {name}");
            Console.WriteLine($"Manufacturer: {manufacturer}");
            Console.WriteLine($"Year of Manufacture: {year}");
            Console.WriteLine($"Type: {type}");
        }
    }

    class Program
    {
        static void Main()
        {
            Airplane airplane = new Airplane();
            airplane.InputData();
            Console.WriteLine("\nAirplane Information:");
            airplane.DisplayData();
        }
    }
}



