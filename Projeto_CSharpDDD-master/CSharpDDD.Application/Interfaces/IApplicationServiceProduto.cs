﻿using CSharpDDD.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto produtoDto);
        void Update(ProdutoDto produtoDto);
        void Remove(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> GetAll();
        ProdutoDto GetById(int id);

    }
}
