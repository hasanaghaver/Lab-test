using _04._03.Extension;
using _04._03.Models;

namespace _04._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book {Title ="1",Author ="Adam", PageCount = 300, Genre =EGenre.Novel, Price = 200, StockCount =3 };
            Book book2 = new Book {Title ="1",Author ="Adam112", PageCount = 100, Genre =EGenre.Novel, Price = 100, StockCount =1 };
            BookService bookService = new BookService();
            bookService.Add(book);
            bookService.Add(book2);
            Console.WriteLine(bookService.GetById(1));
            Console.WriteLine(bookService.CountByGenre(EGenre.Novel));
            List<Book> books = bookService.GetByGenre(EGenre.Novel);
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(bookService.GetCheapestBook());
            Console.WriteLine(book.GetShortInfo());
            book2.ApplyDiscount(20);
            Console.WriteLine(book2.Price);
        }
    }
}
