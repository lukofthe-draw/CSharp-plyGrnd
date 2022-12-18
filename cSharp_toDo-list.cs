// C# task and to do list desktop application

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        List<string> tasks = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Add the task to the list
            tasks.Add(taskInput.Text);

            // Clear the input field
            taskInput.Text = "";

            // Update the list display
            UpdateList();
        }

        private void UpdateList()
        {
            // Clear the current display
            taskList.Items.Clear();

            // Add all tasks in the list to the display
            foreach (string task in tasks)
            {
                taskList.Items.Add(task);
            }
        }

        private void crossOffButton_Click(object sender, EventArgs e)
        {
            // Get the selected index
            int index = taskList.SelectedIndex;

            // Make sure an item is selected
            if (index != -1)
            {
                // Cross off the task by adding a strikethrough font
                taskList.Items[index] = new ListViewItem.ListViewSubItem(taskList.SelectedItems[0], tasks[index], SystemColors.WindowText, SystemColors.Window, new Font(taskList.Font, FontStyle.Strikeout));
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Get the selected index
            int index = taskList.SelectedIndex;

            // Make sure an item is selected
            if (index != -1)
            {
                // Remove the task from the list
                tasks.RemoveAt(index);

                // Update the list display
                UpdateList();
            }
        }
    }
}
