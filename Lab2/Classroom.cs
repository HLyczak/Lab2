using System;

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

        public Classroom(string Name, Person[] persons)
        {
            this.Name = name;
            this.persons = persons;
        }

        public override string ToString()
        {
            string a = $"Classroom: Sala Komputerowa {Environment.NewLine}";
            foreach (var i in persons)
            {
                a += i.ToString();
            }
            return a;
        }
    }
}