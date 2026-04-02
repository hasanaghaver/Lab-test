using _04._02_lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._02_lab.Helper
{
    //    Task-ın bitməyinə nə qədər müddət qaldığını qaytaran metod
    //Task üçün nə qədər vaxt ayrıldığını göstərən metod
    static class TaskHelper
    {
        public static void endTime(this MyTask task)
        {
            Console.WriteLine(task.DeadLine-DateTime.Now);
        }
        public static void Time(this MyTask task)
        {
            Console.WriteLine(task.DeadLine-task.Created);
        }
    }
}
