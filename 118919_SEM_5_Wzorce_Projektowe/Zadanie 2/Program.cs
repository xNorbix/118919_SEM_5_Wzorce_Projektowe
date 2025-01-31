// -------------------- Factory Method --------------------
public interface IAnimal
{
    void Speak();
}

public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Hau hau!");
    }
}

public class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Miau!");
    }
}

public abstract class AnimalFactory
{
    public abstract IAnimal CreateAnimal();
}

public class DogFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Dog();
    }
}

public class CatFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Cat();
    }
}

// -------------------- Abstract Factory --------------------

public interface IDog
{
    void SetColor();
}

public class Black : IDog
{
    public void SetColor()
    {
        Console.WriteLine("Pies koloru czarnego.");
    }
}

public class White : IDog
{
    public void SetColor()
    {
        Console.WriteLine("Pies koloru białego.");
    }
}

public interface IDogColorFactory
{
    IDog CreateColor();
}

public class BlackFactory : IDogColorFactory
{
    public IDog CreateColor()
    {
        return new Black();
    }
}

public class WhiteFactory : IDogColorFactory
{
    public IDog CreateColor()
    {
        return new White();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Factory Method ---");

        AnimalFactory dogFactory = new DogFactory();
        IAnimal dog = dogFactory.CreateAnimal();
        dog.Speak(); 

        AnimalFactory catFactory = new CatFactory();
        IAnimal cat = catFactory.CreateAnimal();
        cat.Speak(); 

        Console.WriteLine("\n--- Abstract Factory ---");

        IDogColorFactory blackFactory = new BlackFactory();
        IDog black = blackFactory.CreateColor();
        black.SetColor();

        IDogColorFactory whiteFactory = new WhiteFactory();
        IDog white = whiteFactory.CreateColor();
        white.SetColor(); 
    }
}