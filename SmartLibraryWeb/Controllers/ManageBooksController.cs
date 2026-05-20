using Microsoft.AspNetCore.Mvc;
using SmartLibraryWeb.Data;
using SmartLibraryWeb.Models;
namespace SmartLibraryWeb.Controllers
{
    public class ManageBooksController : Controller
    {
        private bool IsLoggedIn()=>HttpContext.Session.GetString("IsLoggedIn")=="true";
        public IActionResult Index(){ if(!IsLoggedIn()) return RedirectToAction("Login","Account"); ViewBag.Books=DatabaseHelper.GetBooks(); return View(new Book()); }
        [HttpPost]
        public IActionResult Index(Book book){ if(!IsLoggedIn()) return RedirectToAction("Login","Account"); try{ book.AvailableCopies=book.Quantity; DatabaseHelper.AddBook(book); TempData["Message"]="Book added successfully."; return RedirectToAction("Index"); }catch{ ViewBag.Error="Book could not be added. The Book Code may already exist."; ViewBag.Books=DatabaseHelper.GetBooks(); return View(book); } }
        public IActionResult Edit(int id){ if(!IsLoggedIn()) return RedirectToAction("Login","Account"); var book=DatabaseHelper.GetBookById(id); return book==null?RedirectToAction("Index"):View(book); }
        [HttpPost]
        public IActionResult Edit(Book book){ if(!IsLoggedIn()) return RedirectToAction("Login","Account"); DatabaseHelper.UpdateBook(book); TempData["Message"]="Book updated successfully."; return RedirectToAction("Index"); }
        public IActionResult Delete(int id){ if(!IsLoggedIn()) return RedirectToAction("Login","Account"); DatabaseHelper.DeleteBook(id); TempData["Message"]="Book deleted."; return RedirectToAction("Index"); }
    }
}
