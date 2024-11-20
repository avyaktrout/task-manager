using System;
using System.Windows.Forms;

namespace TaskManagerApp
{
    static class Program
    {
        // The main entry point for the application.
        [STAThread]
        static void Main()
        {
            // Set the application to use visual styles
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Run the main form
            Application.Run(new Form1());
        }
    }
}
