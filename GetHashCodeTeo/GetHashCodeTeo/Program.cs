using GetHashCodeTeo.Entities;

namespace GetHashCodeTeo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };

            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            string f = "(Client) b;";

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }
    }
}