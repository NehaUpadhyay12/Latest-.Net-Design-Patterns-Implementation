namespace FactoryDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubjectFactory factory = new SubjectFactory();
            Console.WriteLine(factory.GetSubject(0).SubjectName);
        }
    }
}