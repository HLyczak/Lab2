using System;
using System.Collections.Generic;
using System.Linq;

//+ to składnik publiczny (public)
//# to składnik chroniony (protected)
//-to składnik prywatny(private)
//~to składnik dostępny w obrębie projektu (package)
// dziedziczy rozszerza 

namespace Lab2
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        protected string imie;
        protected int age;

        public string Name { get; set; }
        public int Age { get; set; }

        public bool Equals(Person other)
        {
          return (this.Age == other.Age && this.Name == other.Name);
        }

        public override string ToString() => $" {Name}, ({Age} y.o.)";      
    }

    //+ to składnik publiczny (public)
    //# to składnik chroniony (protected)
    //-to składnik prywatny(private)
    //~to składnik dostępny w obrębie projektu (package)
    // dziedziczy rozszerza 

    public class Student : Person
    {
        public Student( string name,int age, string group) : base(name, age)
        {
            this.group = group;
        }
        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {

        }
        protected string group;

        protected List<Task> tasks = new List<Task>();

        public string Group { get; set; }

        public void AddTask(string taskName, TaskStatus taskStatus)
        {         
        }
        public void RemoveTask(int index)
        { 
        }
        public void UpdateTask(int index, TaskStatus taskStatus)
        { 
        }
        public void RenderTask(string prefix, TaskStatus taskStatus)
        { 
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public bool Equals(Student other)
        {
            return (this.Age == other.Age && this.Name == other.Name && this.Group == other.Group);
        }
        private static bool SequenceEqual(List<Task> a, List<Task> b)
        { 
            bool equal=  a.SequenceEqual.(b);
            return equal;
        }

    }

    public class Classroom
    {
        string name;
        Person

        private Person_classes

        //public string Name { get; set; }
        public void Person (Classroom classes)
        { 
            _
        }

    }

    public class Task
    {
        public string name;
        public TaskStatus status;

        public string Name { get; set; }
        public TaskStatus Status { get; set; }
    }

    public enum TaskStatus
    {
        Waiting,
        Progress,
        Done,
        Rejected
    }
}