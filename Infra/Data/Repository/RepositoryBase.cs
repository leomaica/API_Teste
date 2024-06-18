using DomainCore.Interfaces.Repositorys;
using Microsoft.EntityFrameworkCore;


namespace Infra.Data.Repository
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _context;

        public RepositoryBase(SqlContext context)
        {
            this._context = context;
        }

        public void Add(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Add(entity);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            try
            {                
               
                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Update(TEntity entity)
        {
                try
                {
                    _context.Entry(entity).State = EntityState.Modified;
                    _context.SaveChanges();

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
    }
}
