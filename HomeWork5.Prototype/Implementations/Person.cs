using HomeWork5.Prototype.Extensions;
using HomeWork5.Prototype.Interfaces;

namespace HomeWork5.Prototype.Implementations
{
    public class Person : IMyCloneable<Person>, ICloneable
    {
        public string Name { get; set; }

        public int Age { get; set; }

        
        public Person(Person person) 
        {
            Name = person.Name;
            Age = person.Age;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual Person MyClone()
        {
           return new Person(this);
        }

        public virtual object Clone()
        {
            return MemberwiseClone();
        }

        public virtual Person DeepCopy()
        {
           return CopyHelper.CreateDeepCopy(this);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
