namespace Lab2
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        { }

        public override string ToString() => $" {Name}, ({Age} y.o.)";
    }
}