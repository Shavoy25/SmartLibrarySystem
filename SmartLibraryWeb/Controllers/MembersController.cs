using Microsoft.AspNetCore.Mvc;
using SmartLibraryWeb.Data;
using SmartLibraryWeb.Models;
namespace SmartLibraryWeb.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Register() => View(new Member());
        [HttpPost]
        public IActionResult Register(Member member)
        {
            if (string.IsNullOrWhiteSpace(member.MemberCode)||string.IsNullOrWhiteSpace(member.FirstName)||string.IsNullOrWhiteSpace(member.LastName)||string.IsNullOrWhiteSpace(member.UserType))
            { ViewBag.Error="Please complete Member ID, First Name, Last Name, and User Type."; return View(member); }
            try{ DatabaseHelper.AddMember(member); TempData["Message"]="Member registered successfully."; return RedirectToAction("Login","Account"); }
            catch{ ViewBag.Error="Registration failed. The Member ID may already exist."; return View(member); }
        }
    }
}
