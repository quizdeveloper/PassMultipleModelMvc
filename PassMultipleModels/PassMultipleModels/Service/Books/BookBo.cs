using PassMultipleModels.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassMultipleModels.Service.Books
{
    public class BookBo : IBookBo
    {
        public List<BooksModel> Books()
        {
            return new List<BooksModel>() {
              new BooksModel(){ Id = 1, Author ="Mr.Jonh A", BookName="Programming in c#", CateId = 1, PublishDate = DateTime.Now },
              new BooksModel(){ Id = 2, Author ="Mr.Jonh B", BookName="Asp.net core 3 pro", CateId = 1, PublishDate = DateTime.Now },
              new BooksModel(){ Id = 3, Author ="Mr.Jonh C", BookName="Love and friend", CateId = 2, PublishDate = DateTime.Now },
              new BooksModel(){ Id = 4, Author ="Mr.Jonh D", BookName="Feeling in front wind", CateId = 2, PublishDate = DateTime.Now }
            };
        }
    }
}
