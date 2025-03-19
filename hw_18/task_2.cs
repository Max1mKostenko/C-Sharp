abstract class Shape
{
    public abstract double GetArea();
}

class Rectangle : Shape
{
    private double width, height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea() => width * height;
}

class Circle : Shape
{
    private double radius;
    private const double PI = 3.141592;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea() => PI * radius * radius;
}

class Triangle : Shape
{
    private double base_length, height;

    public Triangle(double base_length, double height)
    {
        this.base_length = base_length;
        this.height = height;
    }

    public override double GetArea() => 0.5 * base_length * height;
}

class Trapezoid : Shape
{
    private double base1, base2, height;

    public Trapezoid(double base1, double base2, double height)
    {
        this.base1 = base1;
        this.base2 = base2;
        this.height = height;
    }

    public override double GetArea() => 0.5 * (base1 + base2) * height;
}

class Program
{
    static void Main()
    {
        Shape[] shapes = {
            new Rectangle(4, 6),
            new Circle(5),
            new Triangle(6, 8),
            new Trapezoid(4, 6, 8)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}

