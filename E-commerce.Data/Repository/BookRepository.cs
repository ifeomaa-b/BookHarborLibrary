using E_commerce.Data.Repository.IRepository;
using E_commerce.Models.Models;
using E_Commerce.Data;
using E_Commerce.Models;
using System.Linq.Expressions;

namespace E_commerce.Data.Repository
{
    public class BookRepository : Repository<Book>, IBook
    {
        private readonly AppDbContext _db;

        public BookRepository(AppDbContext db) : base(db) 
        {
            _db = db;
        }       

        public void Update(Book book)
        {
           var bookfromDb = _db.Books.FirstOrDefault(u=>u.Id == book.Id);

            if (bookfromDb != null)
            {
                bookfromDb.Title = book.Title;
                bookfromDb.ISBN = book.ISBN;
                bookfromDb.PublishedDate = book.PublishedDate;
                bookfromDb.Publisher = book.Publisher;
                bookfromDb.UpdatedAt = DateTime.UtcNow;
                bookfromDb.TotalPageCount = book.TotalPageCount;
                bookfromDb.Description = book.Description;
                bookfromDb.GenreId = book.GenreId;
                bookfromDb.Author = book.Author;
                bookfromDb.BookContent = book.BookContent;
                if (bookfromDb.ImageUrl != null)
                {
                    bookfromDb.ImageUrl = book.ImageUrl;
                }
            }
        }

       
    }
}
