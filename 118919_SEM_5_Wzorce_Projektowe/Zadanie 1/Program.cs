class Program
{
    static void Main(string[] args)
    {
        Singleton.Test();
        Singleton instance = Singleton.GetInstance();
        Singleton instance2 = Singleton.GetInstance();
        instance.Start(1,5);
        instance2.Start(5, 5);

        if (instance == instance2)
        {
            Console.WriteLine("instance i instance2 to ta sama instancja.");
        }
    }
}
public sealed class Singleton
{
    private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
    private Singleton()
    {
        Console.WriteLine("Konstruktor Singleton() działa");
    }
    public static Singleton GetInstance()
    {
        return _instance.Value;
    }

    public static void Test()
    {
        Console.WriteLine("Działa Test()");
    }

    public void Start(int x, int y)
    {
        Console.WriteLine($"Działa Singleton.Start({x}, {y})");
        Console.WriteLine($"{x} + {y} = {x + y}");
    }
}
