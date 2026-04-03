using _04._03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03.Extension
{
     static class BookExtensions
    {
        public static string GetShortInfo(this Book book)
        {
            return $"{book.Title} - {book.Author} - {book.Price} AZN" ;
        }
        
        public static bool IsInStock(this Book book)
        {
            return book.StockCount > 0 ;
        }
        public static void ApplyDiscount(this Book book, double percent)
        {
            book.Price -= book.Price /100 *percent;
        }
    }
}
