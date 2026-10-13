using System;

public abstract class Shape
{
    public String Name { get; set; } = String.Empty;

    public abstract double Area();

    public virtual void Display()
    {
        Console.WriteLine($"Area of shape {Name} is: {Area()}");        
    }

}

public class Circle : Shape
{
    double Radius { get; set; }
    public Circle(double radius)
    {
        Name = "Circle";
        Radius = radius;
    }
    public override double Area()
    {
        return 3.14 * (Radius * Radius); 
    }

}

public class Rectangle : Shape
{
    double Width { get; set; }
    double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Name = "Rectangle";
        Width = width;
        Height = height;
    }
   public override double Area()
   {
        return Width * Height;        
   }

}

class MainEntry
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(5,10);
        circle.Display();
        rectangle.Display();
    }

}
