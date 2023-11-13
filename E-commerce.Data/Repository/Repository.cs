using E_commerce.Data.Repository.IRepository;
using E_Commerce.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace E_commerce.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        internal DbSet<T> DbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            this.DbSet = _context.Set<T>();
            _context.Books.Include(u => u.Genre);
        }

        public void Add(T entity)
        {
           DbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter, string includeProperties = null)
        {
            IQueryable<T> search = DbSet;
            search = search.Where(filter);
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var item in includeProperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    search = search.Include(item);
                }
            }
            return search.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(string includeProperties = null)
        {
            IQueryable<T> search = DbSet;
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var item in includeProperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    search = search.Include(item);
                }
            }
            return search.ToList();
        }

        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            DbSet.RemoveRange(entity);
        }
    }
}
