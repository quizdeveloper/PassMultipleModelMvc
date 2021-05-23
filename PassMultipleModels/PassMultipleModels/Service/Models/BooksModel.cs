using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassMultipleModels.Service.Models
{
    public class BooksModel
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int CateId { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
