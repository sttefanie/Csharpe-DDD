using CSharpDDD.Domain.Core.Interface.Repositories;
using CSharpDDD.Domain.Core.Interface.Services;
using CSharpDDD.Domain.Entities;

namespace CSharpDDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}