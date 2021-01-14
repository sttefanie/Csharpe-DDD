using CSharpDDD.Domain.Core.Interface.Repositories;
using CSharpDDD.Domain.Core.Interface.Services;
using CSharpDDD.Domain.Entities;

namespace CSharpDDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}