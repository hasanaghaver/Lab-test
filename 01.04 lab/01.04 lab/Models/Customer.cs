using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._04_lab.Models
{
    class Customer
    {
        private static int count;
        public int Id;
        public string Name { get; set; }
        public string City { get; set; }

        public Customer()
        {
            count++;
            Id = count;
        }
    }
}
