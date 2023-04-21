namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILumiaXMLTarget target = new LumiaXMLAdapter();
            Console.WriteLine(target.GetLumiaXMLSpecifications().InnerXml);
        }
    }
}