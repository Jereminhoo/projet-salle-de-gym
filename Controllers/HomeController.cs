using Microsoft.AspNetCore.Mvc;
using Projet.Data;
using Projet.Core.Domain;

namespace Projet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var produits = _context.Produits.ToList();
            return View(produits);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
