﻿using CasaDoCodigo.Models;
using CasaDoCodigo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext context;

        public ProdutoRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IList<Produto> GetProdutos()
        {
            return context.Set<Produto>().ToList();
        }

        public void SaveProdutos(List<Livro> livros)
        {
            foreach (var livro in livros)
            {
                context.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
            }
            context.SaveChanges();
        }
    }
}
