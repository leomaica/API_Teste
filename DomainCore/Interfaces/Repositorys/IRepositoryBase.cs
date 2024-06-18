using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainCore.Interfaces.Repositorys
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update (TEntity entity);
        void Remove (TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);


    }
}
