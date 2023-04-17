namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPizza pizzaObject = new PlainPizza();
            Console.WriteLine(pizzaObject.MakePizza());

            PizzaDecorator chickenPizza = new ChickenPizzaDecorator(pizzaObject);
            Console.WriteLine(chickenPizza.MakePizza());

            PizzaDecorator vegPizza = new VegPizzaDecorator(pizzaObject);
            Console.WriteLine(vegPizza.MakePizza());
        }
    }
}