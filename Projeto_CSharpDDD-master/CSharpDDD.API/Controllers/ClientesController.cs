using CSharpDDD.Application;
using CSharpDDD.Application.Dtos;
using CSharpDDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;

        public ClientesController(IApplicationServiceCliente ApplicationServiceCliente)
        {
            _applicationServiceCliente = ApplicationServiceCliente;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCliente.GetAll());
        }

        [HttpGet("{Id}")]

        public ActionResult<string> Get(int Id)
        {
            return Ok(_applicationServiceCliente.GetById(Id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Add(clienteDto);
                return Ok("Sucesso! Cliente cadastrado");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Update(clienteDto);
                return Ok("Cliente atualizado!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete()]

        public ActionResult Delete([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicationServiceCliente.Remove(clienteDto);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       
    }
}
