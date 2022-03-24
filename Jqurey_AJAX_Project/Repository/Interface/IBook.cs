using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jqurey_AJAX_Project.Repository.Interface
{
    interface IBook
    {
    }
        
        public interface GenricInterface<T>
        {
            List<T> GetData();
        }
    
}
