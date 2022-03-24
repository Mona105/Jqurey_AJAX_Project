using Jqurey_AJAX_Project.Repository.Interface;
using Jqurey_AJAX_Project.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jqurey_AJAX_Project.Controllers
{
    public class BooksController : Controller
    {
        public GenricInterface<BookWithAuthor> BookService { get; set; }
        public BooksController(GenricInterface<BookWithAuthor> _book)
        {
            BookService = _book;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetBooks()
        {
            var books = BookService.GetData();
            return Json(books);
        }
    }
}
