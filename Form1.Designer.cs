namespace TaskManagerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteTask;

        // Form Cleanup
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initialize the form components
        private void InitializeComponent()
        {
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(120, 30);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(200, 20);
            this.txtTaskName.TabIndex = 0;
            
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 70);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 20);
            this.txtDescription.TabIndex = 1;
            
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(120, 110);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDueDate.TabIndex = 2;
            
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(120, 150);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.Location = new System.Drawing.Point(120, 200);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(300, 160);
            this.lstTasks.TabIndex = 4;
            
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(120, 370);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 5;
            
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(340, 370);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(120, 440);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTask.TabIndex = 7;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeleteTask);
            this.Name = "Form1";
            this.Text = "Task Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
