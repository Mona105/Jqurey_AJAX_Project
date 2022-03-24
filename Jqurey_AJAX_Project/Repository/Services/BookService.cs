using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jqurey_AJAX_Project.Models;
using Jqurey_AJAX_Project.Repository.Interface;
using Jqurey_AJAX_Project.ViewModel;

namespace Jqurey_AJAX_Project.Repository.Services
{
    public class BookService:GenricInterface<BookWithAuthor>
    {
        private MSDbContext dbContext;
        public BookService()
        {
            dbContext = new MSDbContext();
        }

        public List<BookWithAuthor> GetData()
        {
            var books = (from book in dbContext.Books
                         join
                         author in dbContext.Author
                         on book.Author_Id equals author.Id
                         select new BookWithAuthor()
                         {
                             Id = book.Id,
                             Title = book.Title,
                             Price = book.Price,
                             Quantity = book.Quantity,
                             Published_On = book.Published_On,
                             Author_Name = author.Name,
                             Author_Email=author.Email,
                             Author_Mobile=author.Mobile
                         }).ToList();
            return books;
        }
    }
}
