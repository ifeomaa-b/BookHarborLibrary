using E_Commerce.Models;

namespace E_commerce.Data.Repository.IRepository
{
    public interface IGenre : IRepository<Genre>
    {
        void Update(Genre genre); 
       
    }
}
