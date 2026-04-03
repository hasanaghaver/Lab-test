using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03.Models
{
    interface IBookService
    {
        //        Add(Book book) -> kitab əlavə et
        //GetById(int id) -> id-yə görə kitab qaytar
        //GetByGenre(Genre genre) -> janra görə filter
        //GetMostExpensiveBook() -> ən bahalı kitab
        //GetCheapestBook() -> ən ucuz kitab
        //GetAveragePrice() -> orta qiymət
        //CountByGenre(Genre genre) -> janra görə say
        //GetByPriceRange(double min, double max) -> qiymət aralığına görə filter
        void Add(Book book);
        Book GetById(int id);
        List<Book> GetByGenre(EGenre genre);
        Book GetMostExpensiveBook();
        Book GetCheapestBook();
        double GetAveragePrice();
        int CountByGenre(EGenre genre);
        List<Book> GetByPriceRange(double min, double max);
    }
}
