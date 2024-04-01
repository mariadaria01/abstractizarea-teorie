using teorie;

public abstract class Animal
{
    public abstract void MakeSound();

    public void Sleep()
    {
        Console.WriteLine("zzz..");
    }
}
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows.");
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        /*Animal animal = new Dog();
        animal.MakeSound();
        animal.Sleep();*/
        
        Square square = new Square(0, 0, 10);
        Console.WriteLine(square.CalculateArea());
        square.Draw();
        square.Resize(0.5);
        Console.WriteLine(square.CalculatePerimeter());

        Circle circle = new Circle(5, 5, 4);
        Console.WriteLine(circle.CalculateArea());
        circle.Draw();
        circle.Resize(0.5);
        Console.WriteLine(circle.CalculatePerimeter());
    }
}