using Autofac;
using CSharpDDD.Application;
using CSharpDDD.Application.Interfaces;
using CSharpDDD.Application.Interfaces.Mappers;
using CSharpDDD.Application.Mappers;
using CSharpDDD.Domain.Core.Interface.Repositories;
using CSharpDDD.Domain.Core.Interface.Services;
using CSharpDDD.Domain.Services;
using CSharpDDD.Infrastructure.Data.Repositories;

namespace CSharpDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion IOC
        }
    }
}