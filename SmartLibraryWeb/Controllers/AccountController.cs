using Microsoft.AspNetCore.Mvc;
using SmartLibraryWeb.Data;
using SmartLibraryWeb.Models;
namespace SmartLibraryWeb.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login() => View(new LoginViewModel());
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (DatabaseHelper.ValidateLogin(model.Username, model.Password))
            {
                HttpContext.Session.SetString("IsLoggedIn", "true");
                HttpContext.Session.SetString("Username", model.Username);
                TempData["Message"] = "Login successful.";
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Invalid username or password."; return View(model);
        }
        public IActionResult Logout(){ HttpContext.Session.Clear(); return RedirectToAction("Login"); }
    }
}
