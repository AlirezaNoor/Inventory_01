using System.Linq.Expressions;
using Invetory01.Infrastructure.GnericReposetory;
using Microsoft.EntityFrameworkCore;

namespace Framework.GnericReposetory
{
    public class GenericReposetores<T, Tkey> : IGenericReposetores<T,Tkey> where T : class
    {
        private readonly DbContext _context;

        public GenericReposetores(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(Tkey id)
        {
            return _context.Find<T>(id);
        }

        public void Insert(T obj)
        {
            _context.Add<T>(obj);
        }

        public void Delete(Tkey id)
        {
            var test = _context.Find<T>(id);
            _context.Remove(test);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        public bool Exists(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }
    }
}
