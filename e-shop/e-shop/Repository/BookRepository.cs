using e_shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_shop.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public List<BookModel> GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).ToList();
        }
        public List<BookModel> SearchBook(string title , string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author == authorName).ToList();
        }


        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id=1, Title="MvC" , Author="Dinuka" , Description="This is a good Book"},
                new BookModel(){ Id=2, Title="Dot Net" , Author="Imasha" , Description="This is a good Book"},
                new BookModel(){ Id=3, Title="Java" , Author="Sandaru", Description="This is a good Book"},
                new BookModel(){ Id=4, Title="C++" , Author="Chalani", Description="This is a good Book"},
                new BookModel(){ Id=5, Title="Dart" , Author="Achini", Description="This is a good Book"},
                new BookModel(){ Id=6, Title="React" , Author="Gayan", Description="This is a good Book"}

            };
        }
    }
}
