namespace teorie;

public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

public interface IDrawable
{
    void Draw();
}

public interface IResizeable
{
    void Resize(double factor);
}

public class Coordinates
{
    public int X { get; set; }
    public int Y { get; set; }

    public Coordinates(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"{X}:{Y}";
    }
}

public abstract class Shape : IShape, IDrawable, IResizeable
{
    public Coordinates Coords { get; set; }

    public Shape(int x, int y)
    {
        Coords = new Coordinates(x, y);
    }

    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
    public abstract void Draw();
    public abstract void Resize(double factor);
}

public class Square : Shape
{
    public double Length { get; set; }

    public Square(int x, int y, double length) : base(x,y)
    {
        Length = length;
    }

    public override double CalculateArea()
    {
        return Length * Length;
    }

    public override double CalculatePerimeter()
    {
        return 4 * Length;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawn square at {Coords}");
    }

    public override void Resize(double factor)
    {
        Length *= factor;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }
    
    public Circle(int x, int y, double radius) : base(x,y)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Radius * Radius * Math.PI;
    }

    public override double CalculatePerimeter()
    {
        return Radius * 2 * Math.PI;
    }
    public override void Draw()
    {
        Console.WriteLine($"Drawn circle at {Coords}");
    }
    public override void Resize(double factor)
    {
        Radius *= factor;
    }
}
