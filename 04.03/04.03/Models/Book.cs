using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03.Models
{
    class Book
    {
        //        Id(statik olaraq artacaq)
        //Title
        //Author
        //PageCount
        //Price
        //StockCount
        //Genre(enum)
        //CreatedAt(default olaraq indiki vaxt)

        private static int count;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }
        public int StockCount { get; set; }
        public EGenre Genre { get; set; }
        public DateTime CreatedAt { get; set; }

        public Book()
        {
            count++;
            Id = count;
            CreatedAt = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{Id} {Title} {Author} {PageCount} {Price} {StockCount} {Genre} {CreatedAt}";
        }
    }
}
