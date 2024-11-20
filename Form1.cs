using System;
using System.Windows.Forms;

namespace TaskManagerApp
{
    public partial class Form1 : Form
    {
        private TaskManager taskManager;

        public Form1()
        {
            InitializeComponent();
            taskManager = new TaskManager();
            UpdateTaskList();
        }

        // Add task logic
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string name = txtTaskName.Text;
            string description = txtDescription.Text;
            DateTime dueDate = dtpDueDate.Value;

            taskManager.AddTask(name, description, dueDate);
            UpdateTaskList();
        }

        // Update task list in the ListBox
        private void UpdateTaskList()
        {
            lstTasks.Items.Clear();
            foreach (var task in taskManager.GetTasks())
            {
                lstTasks.Items.Add($"{task.Name} - {task.DueDate.ToShortDateString()} - {(task.IsCompleted ? "Completed" : "Pending")}");
            }
        }

        // Search tasks logic
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            var results = taskManager.SearchTasks(searchTerm);

            lstTasks.Items.Clear();
            foreach (var task in results)
            {
                lstTasks.Items.Add($"{task.Name} - {task.DueDate.ToShortDateString()} - {(task.IsCompleted ? "Completed" : "Pending")}");
            }
        }

        // Delete task logic
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            string taskToDelete = lstTasks.SelectedItem?.ToString()?.Split('-')[0]?.Trim();
            if (taskToDelete != null)
            {
                taskManager.DeleteTask(taskToDelete);
                UpdateTaskList();
            }
        }
    }
}
