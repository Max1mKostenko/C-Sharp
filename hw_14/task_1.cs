class Employee
{
    public string FullName { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public string Email { get; set; }
}

class EmployeeManager
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(string fullName, string position, decimal salary, string email)
    {
        employees.Add(new Employee { FullName = fullName, Position = position, Salary = salary, Email = email });
    }

    public void RemoveEmployee(string email)
    {
        employees.RemoveAll(e => e.Email == email);
    }

    public void UpdateEmployee(string email, string newPosition, decimal newSalary)
    {
        foreach (var e in employees)
            if (e.Email == email)
            {
                e.Position = newPosition;
                e.Salary = newSalary;
                break;
            }
    }

    public void SortEmployeesBySalary()
    {
        employees.Sort((a, b) => a.Salary.CompareTo(b.Salary));
    }

    public void DisplayEmployees()
    {
        foreach (var e in employees)
            Console.WriteLine($"{e.FullName}, {e.Position}, {e.Salary}, {e.Email}");
    }
}

class Program
{
    static void Main()
    {
        EmployeeManager manager = new EmployeeManager();
        manager.AddEmployee("John Doe", "Manager", 5000, "johndoe@example.com");
        manager.AddEmployee("Jane Smith", "Developer", 4000, "janesmith@example.com");

        manager.DisplayEmployees();
        Console.WriteLine("\nSorted by Salary:");
        manager.SortEmployeesBySalary();
        manager.DisplayEmployees();
    }
}
