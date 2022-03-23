using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    public class Student : Person
    {
        public Student(string name, int age, string group) : base(name, age)
        {
            this.Group = group;
        }

        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.Group = group;
            this.tasks = tasks;
        }

        protected string group;

        protected List<Task> tasks = new List<Task>();

        public string Group
        {
            get => group;
            set { group = value; }
        }

        public void AddTask(string taskName, TaskStatus taskStatus) // string Name, TaskStatus Status
        {
            Task task = new Task(taskName, taskStatus);
            this.tasks.Add(task);
        }

        public void RemoveTask(int index)
        {
            this.tasks.RemoveAt(index);
        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            Task update = this.tasks.ElementAt(index);

            if (update != null)
            {
                update.Status = taskStatus;
            }
        }

        public override string ToString()
        {
            string b = $"{Environment.NewLine}Student:  {Name} ({Age} y.o.){Environment.NewLine}Group: {group}{Environment.NewLine}Tasks:{Environment.NewLine}";
            int j = 1;
            foreach (var i in tasks)
            {
                b += j + "." + i.ToString();
                j++;
            }
            return b;
        }

        // $"Student:  {Name}, ({Age} y.o.){Environment.NewLine}Group: {group}{Environment.NewLine}";

        public bool Equals(Student other)
        {
            return (this.Age == other.Age && this.Name == other.Name && this.Group == other.Group);
        }

        private static bool SequenceEqual(List<Task> a, List<Task> b)
        {
            return a.SequenceEqual(b);
        }
    }
}