using Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        CachingClassA a = new CachingClassA();
        CachingClassB b = new CachingClassB();
        SingletonCache c = SingletonCache.Instance;
        foreach (var item in c.GetAll())
        {
            Console.WriteLine($"item is {item}");
        }
    }
}