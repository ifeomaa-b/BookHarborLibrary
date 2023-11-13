using E_commerce.Data.Repository.IRepository;
using E_Commerce.Data;
using E_Commerce.Models;

namespace E_commerce.Data.Repository
{
    public class GenreRepository : Repository<Genre>, IGenre
    {
        private AppDbContext _db;

        public GenreRepository(AppDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Update(Genre genre)
        {
           _db.Genres.Update(genre);
        }
    }
}
