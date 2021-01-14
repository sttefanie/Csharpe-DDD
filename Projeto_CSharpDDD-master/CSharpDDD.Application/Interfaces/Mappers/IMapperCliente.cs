using CSharpDDD.Application.Dtos;
using CSharpDDD.Domain.Entities;
using System.Collections.Generic;

namespace CSharpDDD.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);

        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);

        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}
