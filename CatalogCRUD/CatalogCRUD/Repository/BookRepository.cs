using CatalogCRUD.Data;
using CatalogCRUD.Models;
using CatalogCRUD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CatalogCrud.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly CrudContext _context;
        public BookRepository(CrudContext context)
        {
            _context = context;

        }

        public IEnumerable<Book> Books => _context.Books.Include(c => c.CategoryName);
        public Book GetBookByID(int bookId) => _context.Books.FirstOrDefault(b => b.ID == bookId);
    }
}
