using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.1 Title - a görə Siyahıdan task-i tapan metod
//3.2. Siyahıya Task əlavə etmək üçün metod. (eyni başlıqlı Task artırılsa ConflictException qaytaracaq)
namespace _04._02_lab.Models
{
    interface ITaskService
    {
        void FindTitle(string title);
        void AddTask(MyTask newTask);
    }
}
