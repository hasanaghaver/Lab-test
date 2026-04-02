using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._02_lab.Exceptions
{
    class ConflictException : Exception
    {
        public ConflictException():base("This task alredy added")
        {
            
        }
    }
}
