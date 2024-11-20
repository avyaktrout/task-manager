using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class TaskManager
{
    private List<Task> tasks;
    private string filePath = "tasks.json";  // File path to store tasks

    // Constructor to initialize TaskManager and load tasks
    public TaskManager()
    {
        tasks = LoadTasks();
    }

    // Add a new task
    public void AddTask(string name, string description, DateTime dueDate)
    {
        try
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Task name cannot be empty.");

            var task = new Task(name, description, dueDate);
            tasks.Add(task);
            SaveTasks();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Load tasks from a JSON file
    public List<Task> LoadTasks()
    {
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Task>>(json) ?? new List<Task>();
        }
        else
        {
            return new List<Task>();  // Return an empty list if the file doesn't exist
        }
    }

    // Save tasks to a JSON file
    public void SaveTasks()
    {
        var json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    // Get all tasks
    public List<Task> GetTasks()
    {
        return tasks;
    }

    // Delete a task by name
    public void DeleteTask(string name)
    {
        var task = tasks.FirstOrDefault(t => t.Name == name);
        if (task != null)
        {
            tasks.Remove(task);
            SaveTasks();
        }
        else
        {
            Console.WriteLine("Task not found.");
        }
    }

    // Search tasks by name
    public List<Task> SearchTasks(string searchTerm)
    {
        return tasks.Where(task => task.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
