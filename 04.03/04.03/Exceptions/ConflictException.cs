using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03.Exceptions
{
    class ConflictException : Exception
    {
        public ConflictException():base("You alredy added this book")
        {
            
        }
    }
}
