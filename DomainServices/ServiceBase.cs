﻿using DomainCore.Interfaces.Repositorys;


namespace DomainCore.Interfaces.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;
        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {  
            _repositoryBase = repositoryBase;
        }

        public void Add(TEntity entity)
        {
            _repositoryBase.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }
             

        public void Update(TEntity entity)
        {
            _repositoryBase.Update(entity);
        }
    }
}
