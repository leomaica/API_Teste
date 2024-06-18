using Application;
using Application.Interfaces;
using Autofac;
using Autofac.Core;
using DomainCore.Interfaces.Repositorys;
using DomainCore.Interfaces.Services;
using Infra.CrossCutting.Mapper;
using Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {

        public static void Load(ContainerBuilder container )
        {
            container.RegisterType<ApplicationServiceProduto>().As<IAppicationServiceProduto>();
            container.RegisterType<ServiceProduto>().As<IServicoProduto>();
            container.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            container.RegisterType<MapperProduto>().As<IMapperProduto>();
           

        }


    }

}
