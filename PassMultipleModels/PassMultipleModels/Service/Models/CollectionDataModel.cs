using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassMultipleModels.Service.Models
{
    public class CollectionDataModel
    {
        public List<CategoriesModel> Categories { get; set; }
        public List<BooksModel> Books { get; set; }
    }
}
