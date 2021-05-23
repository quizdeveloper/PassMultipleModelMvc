using PassMultipleModels.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassMultipleModels.Service.Category
{
    public interface ICategoriesBo
    {
        List<CategoriesModel> Categories();
    }
}
