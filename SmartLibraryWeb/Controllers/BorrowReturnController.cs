using Microsoft.AspNetCore.Mvc;
using SmartLibraryWeb.Data;
using SmartLibraryWeb.Models;
namespace SmartLibraryWeb.Controllers
{
    public class BorrowReturnController : Controller
    {
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("IsLoggedIn")!="true"){ TempData["Message"]="Please log in to access Borrow/Return."; return RedirectToAction("Login","Account"); }
            ViewBag.Records=DatabaseHelper.GetBorrowRecords(); return View(new BorrowRecord());
        }
        [HttpPost]
        public IActionResult Index(BorrowRecord record)
        {
            if(HttpContext.Session.GetString("IsLoggedIn")!="true") return RedirectToAction("Login","Account");
            try{ DatabaseHelper.AddBorrowRecord(record); TempData["Message"]="Borrow/return record saved."; return RedirectToAction("Index"); }
            catch{ ViewBag.Error="Record could not be saved. Check that Member ID and Book ID exist."; ViewBag.Records=DatabaseHelper.GetBorrowRecords(); return View(record); }
        }
    }
}
