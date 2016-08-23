using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

using System.Xml;

namespace ManagementSystem
{
    public partial class App : Form
    {
        TaskManager taskManager;


        public App()
        {
            InitializeComponent();
            taskManager = new TaskManager(ref drop_ChoseDay);
             
        }

        private void AddOnClick(object sender, EventArgs e)
        {
            string selectedTask = drop_ChoseDay.GetItemText(drop_ChoseDay.SelectedItem);        
              
            taskManager.GetTask(selectedTask).AddTask(textbox_newTask.Text);            
            listbox_tasksDisplay.Items.Clear();
            taskManager.GetTask(selectedTask).PrintAllTasks(ref listbox_tasksDisplay);
                        
            taskManager.AddXMLTask(textbox_newTask.Text, selectedTask);
        }
        private void button_removeTask_Click(object sender, EventArgs e)
        {
            string s_taskToRemove = listbox_tasksDisplay.GetItemText(listbox_tasksDisplay.SelectedItem);
            string selectedTask = drop_ChoseDay.GetItemText(drop_ChoseDay.SelectedItem);

            taskManager.GetTask(selectedTask).RemoveTask(s_taskToRemove);
            listbox_tasksDisplay.Items.Remove(listbox_tasksDisplay.SelectedItem);

            taskManager.RemoveXMLTask(s_taskToRemove, selectedTask);
        }

        private void OnChange(object sender, EventArgs e)
        {            
            listbox_tasksDisplay.Items.Clear();
            string selectedTask = drop_ChoseDay.GetItemText(drop_ChoseDay.SelectedItem);
            taskManager.PrintTask(selectedTask, ref listbox_tasksDisplay);

        }

       
    }
}
