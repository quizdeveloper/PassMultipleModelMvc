using PassMultipleModels.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassMultipleModels.Service.Category
{
    public class CategoriesBo : ICategoriesBo
    {
        public List<CategoriesModel> Categories()
        {
            return new List<CategoriesModel>()
            {
                new CategoriesModel(){ Id = 1, CateName ="Programming", CreatedDate = DateTime.Now},
                new CategoriesModel(){ Id = 2, CateName ="Life", CreatedDate = DateTime.Now}
            };
        }
    }
}
