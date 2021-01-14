using CSharpDDD.Application.Dtos;
using CSharpDDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CSharpDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutosController(IApplicationServiceProduto ApplicationServiceProduto)
        {
            _applicationServiceProduto = ApplicationServiceProduto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProduto.GetAll());
        }

        [HttpGet("{Id}")]
        public ActionResult<string> Get(int Id)
        {
            return Ok(_applicationServiceProduto.GetById(Id));
        }

        [HttpPost]

        public ActionResult Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();


                _applicationServiceProduto.Add(produtoDto);
                return Ok("Produto cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut]

        public ActionResult Put([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Update(produtoDto);
                return Ok("O produto foi atualizado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete()]

        public ActionResult Delete([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicationServiceProduto.Remove(produtoDto);
                return Ok("O produto foi removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
      
    }
}
