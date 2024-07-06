using AkeelApp.Data;
using AkeelApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AkeelApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db) {
            _db=db;
        
        }
        public IActionResult Index()
        {
            List<Category> objectCategoryList=_db.categories.ToList();
            return View();
        }
    }
}
