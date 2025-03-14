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

class CompositeShape : Shape
{
    private Shape shape1, shape2, shape3, shape4;

    public CompositeShape(Shape shape1, Shape shape2, Shape shape3, Shape shape4)
    {
        this.shape1 = shape1;
        this.shape2 = shape2;
        this.shape3 = shape3;
        this.shape4 = shape4;
    }

    public override double GetArea()
    {
        return shape1.GetArea() + shape2.GetArea() + shape3.GetArea() + shape4.GetArea();
    }
}

class Program
{
    static void Main()
    {
        Shape rectangle = new Rectangle(4, 6);
        Shape circle = new Circle(5);
        Shape triangle = new Triangle(6, 8);
        Shape trapezoid = new Trapezoid(4, 6, 8);

        CompositeShape compositeShape = new CompositeShape(rectangle, circle, triangle, trapezoid);

        Console.WriteLine($"Total Composite Shape Area: {compositeShape.GetArea()}");
    }
}
