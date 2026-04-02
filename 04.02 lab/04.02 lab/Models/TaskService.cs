using _04._02_lab.Enums;
using _04._02_lab.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _04._02_lab.Models
{
    class TaskService : ITaskService
    {
        public static List<MyTask> tasks = new List<MyTask>();

        public void AddTask(MyTask newTask)
        {
            MyTask exsist = null;
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].Title == newTask.Title)
                {
                    exsist = tasks[i];
                }
            }
            if(exsist == null)
            {
                tasks.Add(newTask);
            }
            else
            {
                throw new ConflictException();
            }
        }

        public void FindTitle(string title)
        {
            MyTask exsist = null;
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].Title== title)
                {
                    exsist = tasks[i];
                    break;
                }
            }
            if (exsist != null)
            {
                Console.WriteLine(exsist);
            }
            else
            {
                throw new NotFoundException();
            }
        }

        public void FindStatus(ETaskStatus status)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].taskStatus == status)
                {
                    Console.WriteLine(tasks[i]);
                }
            }
        }
        //3.4 Göndərilən Id-də olan elementi siyahıdan silmək üçün metod
        public void RemoveId(int Id)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].Id == Id)
                {
                    tasks.Remove(tasks[i]);
                    Console.WriteLine("Task silindi");
                }
            }
        }

    }
}
