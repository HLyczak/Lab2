namespace Lab2
{
    public class Classroom
    {
        private string name;
        private Person[] persons;

        public string Name
        {
            get => name;
            set { name = value; }
        }

        private Classroom(string Name, Person[] persons)
        {
            this.Name = name;
            this.persons = persons;
        }

        public override string ToString() => $" {Name}, ({persons[0]} )({persons[1]} )";
    }
}