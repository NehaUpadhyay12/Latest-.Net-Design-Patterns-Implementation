namespace FactoryMethodDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubjectFactory factory = new ChemistrySubjectFactory();
            Console.WriteLine(factory.GetSubject().SubjectName);
        }
    }
}