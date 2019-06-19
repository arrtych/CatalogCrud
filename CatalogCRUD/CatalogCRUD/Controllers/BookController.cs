using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogCrud.Repository;
using CatalogCRUD.Data;
using CatalogCRUD.Models;
using CatalogCRUD.Repository;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Edit(int? id, Book person)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(person);
                _context.SaveChanges();

                TempData["message"] = "Book edited!";

                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "There have been errors.");
            return View(person);

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
    }
}