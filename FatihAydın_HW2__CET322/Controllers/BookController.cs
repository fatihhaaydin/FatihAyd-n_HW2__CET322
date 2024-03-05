using FatihAydın_HW2__CET322.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace FatihAydın_HW2__CET322.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            FakeDb fakeDB = new FakeDb();
            var allbooks = fakeDB.GetAllBooks();
            return View(allbooks);
        }

        public IActionResult Detail(int? id)
        {
            if (!id.HasValue) return BadRequest();
            FakeDb db = new FakeDb();
            var book = db.GetBookById(id.Value);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        public IActionResult Delete(int? id)
        {
            if (!id.HasValue) return BadRequest();
            FakeDb db = new FakeDb();
            var result = db.DeleteBook(id.Value);
            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                FakeDb db = new FakeDb();
                db.CreateBook(book);
                return RedirectToAction("Index");
            }
            else
            {
                return View(book);
            }
        }
    }
}
