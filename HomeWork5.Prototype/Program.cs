using HomeWork5.Prototype.Implementations;

namespace HomeWork5.Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person a = new Person("Tom", 20) ;

            var b = (Person)a.Clone();

            b.Name = "Sam";
            b.Age = 25;

            Console.WriteLine(a);

            Console.WriteLine(b);

           Console.ReadLine();
        }
    }
}
