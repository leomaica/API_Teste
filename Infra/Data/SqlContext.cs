using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domains.Entities;

namespace Infra.Data
{
    public class SqlContext:DbContext
    {
        public SqlContext()
        {
        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Produtos> Produtos { get; set; }

        public override int SaveChanges()
        {
            //foreach(var entry in ChangeTracker.Entries().ToList())
            //{
            //   if (entry.State == EntityState.Deleted)
            //    {
            //        entry.Property("SituacaoProduto").IsModified = false;
            //    }
            //}

            return base.SaveChanges();        
        }


    }
}
