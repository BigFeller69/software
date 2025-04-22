namespace decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new Coffee();
            ICoffee milkDecorator = new MilkDecorator(coffee);
            ICoffee sugarDecorator = new SugarDecorator(milkDecorator);
            Console.WriteLine(sugarDecorator.GetCoffeeType());
        }
    }
}
