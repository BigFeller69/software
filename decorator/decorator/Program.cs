namespace decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client c = new();

            ConcreteComponent comp = new();
            c.ClientCode(comp);
            

            ConcreteDecorator1 dec1 = new(comp);

            c.ClientCode(dec1);
        }
    }
}
