using HomeWork5.Prototype.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Prototype.Implementations
{
    public class User : Person
    {
        public IdInfo Id { get; set; }
        public User(User user) : base(user) 
        { 
            Id = user.Id;
        }

        public User(string name, int age,IdInfo id) : base(name, age)
        {
            Id = id;
        }

        

        public override object Clone()
        {
            return MemberwiseClone();
        }
        public override User MyClone()
        {
            return new User(this);
        }
        public override User DeepCopy()
        {
            return CopyHelper.CreateDeepCopy(this);
        }
    }
}
