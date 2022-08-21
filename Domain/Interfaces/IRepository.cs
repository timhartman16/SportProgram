using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Create(T item);
        //void Update(T item);
        void Delete(Guid id);
        void Save();
    }
}
