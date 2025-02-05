using HomeWork5.Prototype.Extensions;
using HomeWork5.Prototype.Interfaces;

namespace HomeWork5.Prototype.Implementations
{
    public class Student : Person 
    {
        public int Course {  get; set; }
        public Student(Student student) : base(student)
        {
            Course = student.Course;
        }

        public Student(string name, int age,int course) : base(name, age)
        {
            Course = course;
        }

        public override Student DeepCopy()
        {
            return CopyHelper.CreateDeepCopy(this);
        }

        public override Student MyClone()
        {
            return new Student(this);
        }

        public override object Clone()
        {
            return MemberwiseClone();
        }

    }
}
