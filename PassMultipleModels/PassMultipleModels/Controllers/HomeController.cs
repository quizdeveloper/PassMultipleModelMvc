using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PassMultipleModels.Models;
using PassMultipleModels.Service.Books;
using PassMultipleModels.Service.Category;
using PassMultipleModels.Service.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace PassMultipleModels.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookBo bookBo;
        private readonly ICategoriesBo categoriesBo;
        public HomeController(ILogger<HomeController> logger, IBookBo bookBo, ICategoriesBo categoriesBo)
        {
            _logger = logger;
            this.bookBo = bookBo;
            this.categoriesBo = categoriesBo;
        }

        public IActionResult Index()
        {
            CollectionDataModel model = new CollectionDataModel();
            model.Categories = categoriesBo.Categories();
            model.Books = bookBo.Books();

            return View(model);
        }

        public IActionResult ViewBags()
        {
            ViewBag.Categories = categoriesBo.Categories();
            ViewBag.Books = bookBo.Books();

            return View();
        }

        public IActionResult ViewDatas()
        {
            ViewData["Categories"] = categoriesBo.Categories();
            ViewData["Books"] = bookBo.Books();

            return View();
        }

        public IActionResult Tuples()
        {
            var categories = categoriesBo.Categories();
            var books = bookBo.Books();

            var tupleModel = new Tuple<List<CategoriesModel>, List<BooksModel>>(categories, books);
            return View(tupleModel);
        }

        public IActionResult DynamicModel()
        {
            dynamic resultModel = new ExpandoObject();

            resultModel.Categories = categoriesBo.Categories();
            resultModel.Books = bookBo.Books();

            return View(resultModel);
        }

    }
}
