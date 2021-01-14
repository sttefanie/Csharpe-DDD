using System;

namespace CSharpDDD.Application.Dtos
{
    public class ProdutoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Decimal Valor { get; set; }
    }
}