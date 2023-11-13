using BookHarbor.Core.Services.Interface;
using E_commerce.Data.Repository.IRepository;
using E_commerce.Models.Models;
using E_commerce.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BookHarbor.Core.Services.Implementation
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _db;
        private readonly IWebHostEnvironment _webEnvironment;

        public BookService(IUnitOfWork db, IWebHostEnvironment webEnvironment)
        {
            _db = db;
            _webEnvironment = webEnvironment;
        }

        public BookViewModels CreateNewBookViewModel()
        {
            var productVm = new BookViewModels
            {
                GenreList = _db.Genre.GetAll()
                    .Select(x => new SelectListItem
                    {
                        Text = x.Name,
                        Value = x.Id.ToString()
                    }),
                Book = new Book()
            };

            return productVm;
        }

        public BookViewModels GetBookViewModel(int? id)
        {
            var productVm = new BookViewModels
            {
                GenreList = _db.Genre.GetAll()
                    .Select(x => new SelectListItem
                    {
                        Text = x.Name,
                        Value = x.Id.ToString()
                    }),
                Book = _db.Book.Get(x => x.Id == id)
            };

            return productVm;
        }

        public string UploadBookImage(IFormFile file)
        {
            string wwwRootPath = _webEnvironment.WebRootPath;
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string productPath = Path.Combine(wwwRootPath, "images", "product");

            using (var filestream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
            {
                file.CopyTo(filestream);
            }

            return @"\images\product\" + fileName;
        }

        public void DeleteBookImage(string imageUrl)
        {
            string wwwRootPath = _webEnvironment.WebRootPath;
            var imagePath = Path.Combine(wwwRootPath, imageUrl.TrimStart('\\'));

            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
        }

        public void AddBook(Book book)
        {
            _db.Book.Add(book);
            _db.Save();
        }

        public void UpdateBook(Book book)
        {
            _db.Book.Update(book);
            _db.Save();
        }
    }
}
