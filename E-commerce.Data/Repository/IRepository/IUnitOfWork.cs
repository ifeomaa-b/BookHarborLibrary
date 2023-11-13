namespace E_commerce.Data.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IGenre Genre { get; }
        IBook Book { get; }
        void Save();


    }
}
