using BookHarbor.Core.Services.Interface;
using E_commerce.Data.Repository.IRepository;
using E_commerce.Models.Models;
using E_commerce.Models.ViewModels;
using E_commerce.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace E_Commerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class BookController : Controller
    {
        private readonly IUnitOfWork _db;
        private readonly IWebHostEnvironment _webEnvironment;
        private readonly IBookService _bookService;
        public BookController(IUnitOfWork db, IWebHostEnvironment webEnvironment, IBookService bookService)
        {
            _db = db;
            _webEnvironment = webEnvironment;
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            var getAll = _db.Book.GetAll(includeProperties:"Genre").ToList();
            
            return View(getAll);
        }

        //public IActionResult Upsert(int? id)
        //{
        //    BookViewModels productVm = new()
        //    {
        //        GenreList = _db.Genre.GetAll()
        //        .Select(x => new SelectListItem
        //        {
        //            Text = x.Name,
        //            Value = x.Id.ToString()
        //        }),
        //        Book = new Book()
        //    };
        //    if (id==null || id==0)
        //    {
        //        //Create
        //        return View(productVm);
        //    }
        //    else
        //    {
        //        //Update
        //        productVm.Book = _db.Book.Get(x=>x.Id==id);
        //        return View(productVm);
        //    }            
        //}

        public IActionResult Upsert(int? id)
        {
            BookViewModels productVm;

            if (id == null || id == 0)
            {
                productVm = _bookService.CreateNewBookViewModel();
            }
            else
            {
                productVm = _bookService.GetBookViewModel(id);
            }

            return View(productVm);
        }




        //[HttpPost]
        //public IActionResult Upsert(BookViewModels category, IFormFile? file)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        string wwwRootPath = _webEnvironment.WebRootPath;
        //        if (file != null)
        //        {
        //            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
        //            string productPath =Path.Combine(wwwRootPath, @"images\product");

        //            if (!string.IsNullOrEmpty(category.Book.ImageUrl))
        //            {
        //                //delete the old image
        //                var oldImagePath = 
        //                    Path.Combine(wwwRootPath, category.Book.ImageUrl.TrimStart('\\'));
        //                if (System.IO.File.Exists(oldImagePath))
        //                {
        //                    System.IO.File.Delete(oldImagePath);
        //                }
        //            }

        //            using (var filestream = new FileStream(Path.Combine(productPath,fileName),FileMode.Create))
        //            {
        //                file.CopyTo(filestream);
        //            }
        //            category.Book.ImageUrl = @"\images\product\" + fileName;
        //        }

        //        if (category.Book.Id==0)
        //        {
        //            _db.Book.Add(category.Book);
        //        }
        //        else
        //        {
        //            _db.Book.Update(category.Book);
        //        }


        //        _db.Save();
        //        TempData["Success"] = "Book created successfully";
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        category.GenreList = _db.Genre.GetAll()
        //       .Select(x => new SelectListItem
        //       {
        //           Text = x.Name,
        //           Value = x.Id.ToString()
        //       });
        //        return View(category);
        //    }


        //}

        //public IActionResult Delete(int Id)
        //{
        //    if (Id == null || Id == 0)
        //    {
        //        return NotFound();
        //    }
        //    var category = _db.Book.Get(c => c.Id == Id);
        //    if (category == null)
        //    {
        //        return BadRequest();
        //    }
        //    return View(category);
        //}
        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeletePost(int Id)
        //{
        //    var category = _db.Book.Get(x => x.Id == Id);
        //    if (category == null)
        //    {
        //        return NotFound();
        //    }
        //    _db.Book.Remove(category);
        //    _db.Save();
        //    TempData["Success"] = "Book Deleted successfully";
        //    return RedirectToAction("Index");

        //}

        [HttpPost]
        public IActionResult Upsert(BookViewModels books, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string imagePath = _bookService.UploadBookImage(file);
                    if (!string.IsNullOrEmpty(books.Book.ImageUrl))
                    {
                        _bookService.DeleteBookImage(books.Book.ImageUrl);
                    }
                    books.Book.ImageUrl = imagePath;
                }

                if (books.Book.Id == 0)
                {
                    _bookService.AddBook(books.Book);
                }
                else
                {
                    _bookService.UpdateBook(books.Book);
                }

                TempData["Success"] = "Book created successfully";
                return RedirectToAction("Index");
            }
            else
            {
                books.GenreList = _db.Genre.GetAll()
                    .Select(x => new SelectListItem
                    {
                        Text = x.Name,
                        Value = x.Id.ToString()
                    });
                return View(books);
            }
        }



        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var getAll = _db.Book.GetAll(includeProperties: "Genre").ToList();
            return Json(new
            {
                data = getAll
            });
        } 
        
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            var productToBeDeleted = _db.Book.Get(x => x.Id == Id);
            if (productToBeDeleted == null)
            {
                return Json(new {success = false, message = "Error while deleting"});
            }
            var oldImagePath =
                           Path.Combine(_webEnvironment.WebRootPath,
                           productToBeDeleted.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _db.Book.Remove(productToBeDeleted);
            _db.Save();

            return Json(new
            {
                success = true, message ="Deleted successfully"
            });
        }


        #endregion
    }
}
