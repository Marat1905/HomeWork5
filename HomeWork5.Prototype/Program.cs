using HomeWork5.Prototype.Implementations;

namespace HomeWork5.Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyCloneableBase a = new MyCloneableBase() { A = 10 , B = 20};

            var b = a.DeepClone();

            Console.WriteLine(b);

           Console.ReadLine();
        }
    }
}
