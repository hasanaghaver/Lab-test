using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._04_lab.Models
{
    class Courier
    {
        private static int count;
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }

        public Courier()
        {
            count++;
            Id = count;
        }
    }
}
