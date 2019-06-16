using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CatalogCRUD.Models;
using CatalogCRUD.Data;

namespace CatalogCRUD.Controllers
{
    public class BookController : Controller
    {
        private readonly CrudContext _context;
        public BookController(CrudContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Books.ToList());
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book book = _context.Books.SingleOrDefault(x => x.ID == id);

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


        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book book = _context.Books.SingleOrDefault(x => x.ID == id);

            if (book == null)
            {
                return NotFound();
            }

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

            Book book = _context.Books.SingleOrDefault(x => x.ID == id);

            if (book == null)
            {
                return NotFound();
            }

            _context.Remove(book);
            _context.SaveChanges();

            TempData["message"] = "Book deleted!";

            return RedirectToAction("Index");
        }
    }
}