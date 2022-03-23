using System;

namespace Lab2
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        { }

        public override string ToString() => $"Treacher:  {Name}, ({Age} y.o.){Environment.NewLine}";
    }
}