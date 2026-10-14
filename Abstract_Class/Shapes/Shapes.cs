using System;

public abstract class Shape
{
    public string Name { get; set; } = string.Empty;

    public abstract double Area();

    public virtual void Display()
    {
        Console.WriteLine($"Area of shape {Name} is: {Area()}");        
    }
}

public class Circle : Shape
{
    private readonly double _radius { get; set; }
    public Circle(double radius)
    {
        Name = "Circle";
        _radius = radius;
    }
    public override double Area()
    {
        return Math.PI * (_radius * _radius); 
    }
}

public class Rectangle : Shape
{
    private readonly double _width { get; set; }
    private readonly double _height { get; set; }

    public Rectangle(double width, double height)
    {
        Name = "Rectangle";
        _width = width;
        _height = height;
    }
   public override double Area()
   {
        return _width * _height;        
   }
}

class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(5, 10);

        circle.Display();
        rectangle.Display();
    }
}