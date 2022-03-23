using System;

namespace Lab2
{
    public class Task
    {
        public string name;
        public TaskStatus status;

        public string Name { get; set; }
        public TaskStatus Status { get; set; }

        public Task(string Name, TaskStatus Status)
        {
            this.Name = Name;
            this.Status = Status;
        }

        public override string ToString() => $" {Name} [{Status}]{Environment.NewLine}";
    }
}