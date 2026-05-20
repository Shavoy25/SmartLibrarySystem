using Microsoft.AspNetCore.Mvc;
using SmartLibraryWeb.Data;
namespace SmartLibraryWeb.Controllers { public class CatalogController : Controller { public IActionResult Index() => View(DatabaseHelper.GetBooks()); } }
