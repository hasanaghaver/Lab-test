using _04._02_lab.Enums;
using _04._02_lab.Helper;
using _04._02_lab.Models;
using System.Reflection;

namespace _04._02_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyTask task1 = new MyTask {Title ="01", DeadLine = DateTime.Now.AddHours(2),taskStatus = ETaskStatus.ToDo };
            MyTask task2 = new MyTask {Title ="02", DeadLine = DateTime.Now.AddHours(1),taskStatus = ETaskStatus.Done };

            TaskService taskService = new();

            

            try
            {
                taskService.AddTask(task1);
                taskService.AddTask(task2);

                taskService.FindStatus(ETaskStatus.ToDo);
                taskService.FindTitle("02");
                taskService.RemoveId(1);
            }
            catch (Exception ex)
            {

                throw;
            }
            task1.endTime();
            task2.Time();
        }
    }
}
