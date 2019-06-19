using CatalogCRUD.Data;
using CatalogCRUD.Models;
using CatalogCRUD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogCrud.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CrudContext _context;

        public CategoryRepository(CrudContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> Categories => _context.Categories;
    }
}
