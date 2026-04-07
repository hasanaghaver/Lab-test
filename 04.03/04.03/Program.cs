using _04._03.Extension;
using _04._03.Models;

namespace _04._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Test
            //Book book = new Book { Title = "1", Author = "Adam", PageCount = 300, Genre = EGenre.Novel, Price = 200, StockCount = 3 };
            //Book book2 = new Book { Title = "1", Author = "Adam112", PageCount = 100, Genre = EGenre.Novel, Price = 100, StockCount = 1 };
            //BookService bookService = new BookService();
            //bookService.Add(book);
            //bookService.Add(book2);
            //Console.WriteLine(bookService.GetById(1));
            //Console.WriteLine(bookService.CountByGenre(EGenre.Novel));
            //List<Book> books = bookService.GetByGenre(EGenre.Novel);
            //foreach (var item in books)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(bookService.GetCheapestBook());

            //Console.WriteLine(book.GetShortInfo());
            //book2.ApplyDiscount(20);
            //Console.WriteLine(book2.Price);

            //Console.WriteLine(bookService.GetMostExpensiveBook());
            #endregion
            #region Ders
            Book book1 = new Book()
            {
                Title = "Xosrov",
                Author = "Nizami",
                PageCount = 200,
                Price = 20,
                StockCount = 10,
                Genre = EGenre.Romance
            };
            Book book2 = new Book()
            {
                Title = "Seyfeli",
                Author = "Nizami",
                PageCount = 300,
                Price = 30,
                StockCount = 15,
                Genre = EGenre.Romance
            }; Book book3 = new Book()
            {
                Title = "Seyfeli12",
                Author = "Nizami12",
                PageCount = 300,
                Price = 30,
                StockCount = 15,
                Genre = EGenre.Romance
            };
            BookService bookService = new BookService();
            bookService.ReadFromFile();
            bookService.Add(book3);

            //Console.WriteLine(bookService.GetById(1));


            //Console.WriteLine(BookExtensions.GetShortInfo(book1));
            //Console.WriteLine(book1.GetShortInfo());
            #endregion

            bookService.WriteToFile();

        }
    }
}
