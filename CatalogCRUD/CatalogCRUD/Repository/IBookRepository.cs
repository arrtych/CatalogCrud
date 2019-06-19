using CatalogCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogCRUD.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> Books { get; }

        Book GetBookByID(int bookId);
    }
}
