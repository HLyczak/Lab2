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
        }

        public override string ToString() => $" {Ne}, ({Age} y.o.)";
    }
}