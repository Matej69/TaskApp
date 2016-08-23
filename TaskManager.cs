using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ManagementSystem
{
    class TaskManager
    {
        public List<Task> tasks = new List<Task>();
        public XmlDocument myxml;

        public TaskManager(ref ComboBox comboBox) {
            tasks.Add(new Task(type_day.MONDAY));
            tasks.Add(new Task(type_day.TUESDAY));
            tasks.Add(new Task(type_day.WEDNESDAY));
            tasks.Add(new Task(type_day.THURSDAY));
            tasks.Add(new Task(type_day.FRIDAY));
            tasks.Add(new Task(type_day.SATURDAY));
            tasks.Add(new Task(type_day.SUNDAY));
            InitComboBox(ref comboBox);
            OpenXML("tasks.xml");
            LoadXML();            
        }
        public void InitComboBox(ref ComboBox comboBox) {
            foreach( Task task in tasks){
                comboBox.Items.Add(task.day.ToString());
            }
        }
        public void PrintTask(type_day day, ref ListBox list) {
            foreach(Task task in tasks) { 
                if(day == task.day) {
                    task.PrintAllTasks(ref list);
                   }
            }
        }
        public void PrintTask(string day, ref ListBox list) {
            foreach (Task task in tasks) {
                if (day == task.day.ToString()) {
                    task.PrintAllTasks(ref list);
                }
            }
        }
        public Task GetTask(string day)  {
            foreach (Task task in tasks) {
                if (day == task.day.ToString()) {
                    return task;
                }                
            }
            return tasks[0];
        }

        //-------------- XML ----------------------------
        public void OpenXML(string _name) {
            myxml = new XmlDocument();
            myxml.Load(_name);
        }
        public void LoadXML() {
            foreach (XmlNode tasks in myxml.DocumentElement.ChildNodes)  {
                string day = tasks.Attributes["day"].Value.ToString();                
                foreach (XmlNode task in tasks)  {
                    string text = task.InnerText;
                    GetTask(day).taskList.Add(text);
                }
            }
        }
        public void AddXMLTask(string textForNode, string day)
        {
            foreach (XmlNode tasks in myxml.DocumentElement.ChildNodes) {
                string NodeDay = tasks.Attributes["day"].Value.ToString();                
                int numOfChildNodes = tasks.SelectNodes("descendant::*").Count;

                XmlNode nodeToAdd = myxml.CreateNode(XmlNodeType.Element, "Task", null);
                nodeToAdd.InnerText = textForNode;                                

                if (NodeDay == day)     
                       tasks.AppendChild(nodeToAdd);
                }       
            myxml.Save("tasks.xml");
        }
        public void RemoveXMLTask(string textOfRemoved, string day)
        {
            foreach (XmlNode tasks in myxml.DocumentElement.ChildNodes)
            {
                string NodeDay = tasks.Attributes["day"].Value.ToString();
                int numOfChildNodes = tasks.SelectNodes("descendant::*").Count;

                if (NodeDay == day) {
                    foreach (XmlNode task in tasks) {
                        if (task.InnerText == textOfRemoved)
                            task.ParentNode.RemoveChild(task);
                    }
                }
            }
            myxml.Save("tasks.xml");
        }


    }
}
