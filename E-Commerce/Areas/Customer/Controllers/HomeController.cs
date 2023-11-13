using E_commerce.Data.Repository.IRepository;
using E_commerce.Models.Models;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_Commerce.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _db;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Book> bookList = _db.Book.GetAll(includeProperties: "Genre");
            return View(bookList);
        }
        public IActionResult Details(int id)
        {
            Book book = _db.Book.Get(x=>x.Id==id,includeProperties: "Genre");
            return View(book);
        }
        public IActionResult ReadMore(int id)
        {
            Book book = _db.Book.Get(x=>x.Id==id,includeProperties: "Genre");
            return View(book);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}