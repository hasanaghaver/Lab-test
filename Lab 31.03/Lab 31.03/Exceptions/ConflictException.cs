using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_31._03.Exceptions
{
    class ConflictException:Exception
    {
        public ConflictException() : base("This card alredy exist") { }
        
    }
}
