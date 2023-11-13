using E_commerce.Models.Models;
using E_commerce.Models.ViewModels;
using Microsoft.AspNetCore.Http;

namespace BookHarbor.Core.Services.Interface
{
    public interface IBookService
    {
        BookViewModels CreateNewBookViewModel();
        BookViewModels GetBookViewModel(int? id);
        void UpdateBook(Book book);
        void AddBook(Book book);
        void DeleteBookImage(string imageUrl);
        string UploadBookImage(IFormFile file);
    }
}
