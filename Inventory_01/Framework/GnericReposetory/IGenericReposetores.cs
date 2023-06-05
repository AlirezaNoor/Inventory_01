using System.Linq.Expressions;

namespace Invetory01.Infrastructure.GnericReposetory
{
    public interface IGenericReposetores<T,Tkey> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(Tkey id);
        void Insert(T obj);
        void Delete(Tkey id);
        bool Exists(Expression<Func<T, bool>> expression);
        void Save();
    }
}
