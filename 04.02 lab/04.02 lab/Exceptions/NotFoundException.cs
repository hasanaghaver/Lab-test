using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._02_lab.Exceptions
{
    class NotFoundException : Exception
    {
        public NotFoundException():base("Title is not found")
        {
            
        }
    }
}
