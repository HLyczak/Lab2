using System;
using System.Collections.Generic;
using System.Linq;

//+ to składnik publiczny (public)
//# to składnik chroniony (protected)
//-to składnik prywatny(private)
//~to składnik dostępny w obrębie projektu (package)

namespace Lab2
{
    internal class Person
    {
        public Person(string name, int age)
        {
        }

        private string imie;
        private int age;

        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Student
    { //#->private
        private string group;
        private List<Task> tasks = new List<Task>();
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