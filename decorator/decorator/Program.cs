namespace decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new Coffee();
            coffee = new SugarDecorator(coffee);
            coffee = new MilkDecorator(coffee);
            Console.WriteLine(coffee.ToString());
        }
    }
}
