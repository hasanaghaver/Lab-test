using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_31._03.Models
{
    interface ICardService
    {
        void AddCard(Card card);
        Card FindIndex(string cartNumber);
    }
}
