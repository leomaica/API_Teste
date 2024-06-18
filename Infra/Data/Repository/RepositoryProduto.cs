using DomainCore.Interfaces.Repositorys;
using Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repository
{
    public class RepositoryProduto : RepositoryBase<Produtos>, IRepositoryProduto
    {
        private readonly SqlContext _context;
        public RepositoryProduto(SqlContext context) : base(context)
        {
            this._context = context;

        }
    }
}
