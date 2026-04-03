using _04._03.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03.Models
{
    class BookService : IBookService
    {
        //        Daxildə statik List<Book> saxlasın
        //Eyni Title + Author ilə kitab əlavə olunarsa ConflictException atılsın
        //Tapılmayan id üçün NotFoundException atılsın
        public static List<Book> books = new List<Book>();

        public void Add(Book book)
        {
            Book titleExsist = books.Find(x => x.Title == book.Title);
            Book autorExsist = books.Find(x => x.Author == book.Author);
            if (titleExsist != null && autorExsist !=null )
            {
                throw new ConflictException();
            }
            books.Add(book);

        }
        public Book GetById(int id)
        {
            Book book= books.Find(x => x.Id == id);
            if (book == null )
            {
                throw new NotFoundException();
            }
            return book;
        }

        public int CountByGenre(EGenre genre)
        {
            int a =books.FindAll(x=> x.Genre == genre).Count;
            return a;
        }

        public double GetAveragePrice()
        {
            double a = 0;
            int count = 0;
            foreach (Book book in books)
            {
                a += book.Price;
                count++;
            }
            if(count > 0) return a/count;
            return 0;
        }

        public List<Book> GetByGenre(EGenre genre)
        {
            return books.FindAll(x=>x.Genre == genre).ToList();
        }

        public List<Book> GetByPriceRange(double min, double max)
        {
            return books.FindAll(x => x.Price> min && x.Price>max).ToList();  }

        public Book GetCheapestBook()
        {
            Book cheapest = books[0];
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Price < cheapest.Price)
                {
                    cheapest = books[i];
                }
            }
            return cheapest;
        }

        public Book GetMostExpensiveBook()
        {
            Book expensive = books[0];
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Price < expensive.Price)
                {
                    expensive = books[i];
                }
            }
            return expensive;
        }
    }
}
