using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01.Models;

namespace TP01.Repository.Interface
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        void add(Book book);
    }
}
