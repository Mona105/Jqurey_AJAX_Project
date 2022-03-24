using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jqurey_AJAX_Project.ViewModel
{
    public class BookWithAuthor
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Published_On { get; set; }
        public string Author_Name { get; set; }
        public string Author_Mobile { get; set; }
        public string Author_Email { get; set; }

    }
}
