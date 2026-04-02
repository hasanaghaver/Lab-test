using _04._02_lab.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////Id
//Başlıq
//İzahat
//Created
//DeadLine (tarix və saat olaraq)
//TaskStatus (enum)
//Id dəyəri Constructor vasitəsilə statik olaraq avtomatik veriləcək, Created dəyəri constructor-da hazırki vaxtı göstərəcək.
//ToString() override edilməli
//Id dəyəri Constructor vasitəsilə statik olaraq avtomatik veriləcək, Created dəyəri constructor-da hazırki vaxtı göstərəcək.
//ToString() override edilməli
namespace _04._02_lab.Models
{
    class MyTask
    {
        private static int _count ;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Explantion { get; set; }
        public DateTime Created { get; set; }
        public DateTime DeadLine { get; set; }
        public ETaskStatus taskStatus { get; set; }

        public MyTask()
        {
            _count++;
            Id = _count;
            Created = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{Id}  {Title}  {Created}  {taskStatus}";
        }

    }
}
