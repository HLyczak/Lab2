namespace Lab2
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        protected string name;
        protected int age;

        public string Name
        {
            get => name;
            set { name = value; }
        }

        public int Age
        {
            get => age;
            set { age = value; }
        }

        public bool Equals(Person other)
        {
            return this.Age == other.Age && this.Name == other.Name; //można usunąć this
        }

        public override string ToString() => $" {Name}, ({Age} y.o.)";
    }
}