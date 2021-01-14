using CSharpDDD.Application.Dtos;
using System.Collections.Generic;

namespace CSharpDDD.Application.Interfaces
{
    public interface IApplication
    {
        void Add(ClienteDto clienteDto);

        void Update(ClienteDto clienteDto);

        void Remove(ClienteDto clienteDto);

        IEnumerable<ClienteDto> GetAll();

        ClienteDto GetById(int id);
    }
}