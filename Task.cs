using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{

    enum type_day{
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY,
        SUNDAY
    };
    class Task
    {
        public type_day day;
        public List<string> taskList = new List<string>();

        public Task(type_day _day){
            day = _day;
        }
        public void AddTask(string _task){
            taskList.Add(_task);
        }
        public void RemoveTask(string _task) {
            foreach(string task in taskList) {
                if(task == _task) {
                    taskList.Remove(task);
                    break;
                }
            }
        }
        public void PrintAllTasks(ref ListBox list) {
            foreach (string task in taskList) {
                list.Items.Add(task);
            }
        }



    }
}
