using E_commerce.Data.Repository.IRepository;
using E_commerce.Utility;
using E_Commerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =SD.Role_Admin)]
    public class GenreController : Controller
    {
        private readonly IUnitOfWork _db;

        public GenreController(IUnitOfWork db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var getAll = _db.Genre.GetAll().ToList();
            return View(getAll);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Genre category)
        {
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "name and displayorder cannot match.");
            }
            if (ModelState.IsValid)
            {
                _db.Genre.Add(category);
                _db.Save();
                TempData["Success"] = "Genre created successfully";
                return RedirectToAction("Index");
            }
            return View();

        }
        public IActionResult Edit(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var category = _db.Genre.Get(c => c.Id == Id);
            if (category == null)
            {
                return BadRequest();
            }
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Genre category)
        {

            if (ModelState.IsValid)
            {
                _db.Genre.Update(category);
                _db.Save();
                TempData["Success"] = "Genre Updated successfully";
                return RedirectToAction("Index");
            }
            return View();

        }
        public IActionResult Delete(int Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var category = _db.Genre.Get(c => c.Id == Id);
            if (category == null)
            {
                return BadRequest();
            }
            return View(category);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int Id)
        {
            var category = _db.Genre.Get(x => x.Id == Id);
            if (category == null)
            {
                return NotFound();
            }
            _db.Genre.Remove(category);
            _db.Save();
            TempData["Success"] = "Genre Deleted successfully";
            return RedirectToAction("Index");

        }
    }
}
