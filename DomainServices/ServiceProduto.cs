using Domains.Entities;
using DomainCore.Interfaces.Repositorys;
namespace DomainCore.Interfaces.Services
{
    public class ServiceProduto : ServiceBase<Produtos>, IServicoProduto
    {
        private readonly IRepositoryProduto _repositoryProduto;
        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this._repositoryProduto = repositoryProduto;
        }



    }
}
