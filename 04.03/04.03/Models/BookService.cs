using _04._03.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _04._03.Models
{
    class BookService : IBookService
    {
        //        Daxildə statik List<Book> saxlasın
        //Eyni Title + Author ilə kitab əlavə olunarsa ConflictException atılsın
        //Tapılmayan id üçün NotFoundException atılsın
        public static List<Book> books = new List<Book>();
        private string _filePath = "C:\\Users\\Classtime.PC_6_213_17\\Desktop\\Hasan\\04.03\\04.03\\Data.json";
           
        public void Add(Book book)
        {
            Book titleExsist = books.Find(x => x.Title == book.Title);
            Book autorExsist = books.Find(x => x.Author == book.Author);
            if (titleExsist != null && autorExsist != null)
            {
                throw new ConflictException();
            }
            books.Add(book);

        }
        public Book GetById(int id)
        {
            Book book = books.Find(x => x.Id == id);
            if (book == null)
            {
                throw new NotFoundException();
            }
            return book;
        }

        public int CountByGenre(EGenre genre)
        {
            return books.Count(i => i.Genre == genre);
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
            if (count > 0) return a / count;
            return 0;
        }

        public List<Book> GetByGenre(EGenre genre)
        {
            return books.FindAll(x => x.Genre == genre).ToList();
        }

        public List<Book> GetByPriceRange(double min, double max)
        {
            return books.FindAll(x => x.Price > min && x.Price > max).ToList(); }

        public Book GetCheapestBook()
        {
            return books.MinBy(i => i.Price);
        }

        public Book GetMostExpensiveBook()
        {
            return books.MaxBy(i => i.Price);
        }

        public void WriteToFile()
        {
            using FileStream fileStream = new FileStream(_filePath, FileMode.OpenOrCreate);
            using StreamWriter streamWriter = new StreamWriter(fileStream);
            string json = JsonSerializer.Serialize(books);
            streamWriter.Write(json);
            Console.WriteLine("Dataya melumatlar oturuldu");
            
        }
        public void ReadFromFile()
        {
            using FileStream fileStream = new FileStream(_filePath, FileMode.OpenOrCreate);
            using StreamReader streamReader = new StreamReader(fileStream);
            string json = streamReader.ReadToEnd();
            books = JsonSerializer.Deserialize<List<Book>>(json);
        }
    }
}
