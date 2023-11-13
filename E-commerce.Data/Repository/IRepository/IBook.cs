using E_commerce.Models.Models;

namespace E_commerce.Data.Repository.IRepository
{
    public interface IBook : IRepository<Book>
    {
        void Update(Book product); 
               
    }
}
