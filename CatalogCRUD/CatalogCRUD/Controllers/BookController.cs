using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogCrud.Repository;
using CatalogCRUD.Data;
using CatalogCRUD.Models;
using CatalogCRUD.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CatalogCrud.Controllers
{
    public class BookController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IBookRepository _bookRepository;
        private readonly CrudContext _context;
        public BookController(IBookRepository bookrepository, ICategoryRepository categoryrepository, CrudContext context)
        {
            _bookRepository = bookrepository;
            _categoryRepository = categoryrepository;
            _context = context;

        }
        public IActionResult Index()
        {
            var books = _bookRepository.Books;
            return View(books);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book book = _bookRepository.Books.SingleOrDefault(x => x.ID == id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book book = _bookRepository.Books.SingleOrDefault(x => x.ID == id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, Book book)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(book);
                _context.SaveChanges();

                TempData["message"] = "Book edited!";

                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "There have been errors.");
            return View(book);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {                
                _context.Add(book);
                _context.SaveChanges();

                TempData["message"] = "Book created!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "There have been errors.");
            return View(book);

        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book book = _bookRepository.Books.SingleOrDefault(x => x.ID == id);

            if (book == null)
            {
                return NotFound();
            }

            _context.Remove(book);
            _context.SaveChanges();

            TempData["message"] = "Book deleted!";

            return RedirectToAction("Index");
        }

        
        public JsonResult GetCategories()
        {
            using  (_context)
            {
                var res = _context.Categories.OrderBy(x => x.Name).ToList();                
                return Json(res);
            }          
            
        }

        [Produces("application/json")]
        [HttpGet("categories")]
        public JsonResult SearchCategories()
        {
            string term = HttpContext.Request.Query["term"].ToString();
            var names = _context.Categories.Where(x => x.Name.Contains(term)).Select(x => x.Name).ToList();
            return Json(names);
        }

        public JsonResult GetCurrentCategory(int categoryId)
        {
            using (_context)
            {
                var category = _context.Categories.Where(x => x.ID == categoryId).Select(x => new
                {
                    x.ID, x.Name
                }).ToList();
                return Json(category);
            }
        }


        /*Get list of all books. Ordered by creation date*/
        public JsonResult GetBooks()
        {
            using (_context)
            {
                var books = _context.Books.Select(x => new
                {
                    x.ID,
                    x.Name,
                    x.Author,
                    x.CategoryName,
                    x.Description,
                    x.CreationDate,
                    x.Price,
                    x.PagesNumber

                }).ToList().OrderByDescending(x=> x.CreationDate);
                return Json(books);
            }
        }

        /*Get books ordered by Name*/
        public JsonResult GetAllBooks()
        {
            using (_context)
            {
                var books = _context.Books.Select(x => new
                {
                    x.ID,
                    x.Name,
                    x.Author,
                    x.CategoryName,
                    x.Description,
                    x.CreationDate,
                    x.Price,
                    x.PagesNumber

                }).OrderBy(x => x.Name).ToList();
                return Json(books);
            }

        }
    }
}