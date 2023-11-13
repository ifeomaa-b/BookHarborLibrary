using E_commerce.Data.Repository.IRepository;
using E_Commerce.Data;

namespace E_commerce.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGenre Genre { get; private set; }
        public IBook Book { get; private set; }
        private AppDbContext _db;

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            Genre = new GenreRepository(_db);
            Book = new BookRepository(_db);
        }

        public void Save()
        {
           _db.SaveChanges();       
        }
    }
}
