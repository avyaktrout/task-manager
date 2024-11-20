public class Task
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }

    // Constructor to initialize a Task
    public Task(string name, string description, DateTime dueDate)
    {
        Name = name;
        Description = description;
        DueDate = dueDate;
        IsCompleted = false; // Default to not completed
    }
}
