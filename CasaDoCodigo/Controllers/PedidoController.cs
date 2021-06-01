using CasaDoCodigo.Models;
using CasaDoCodigo.Repositories;
using CasaDoCodigo.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
       // private readonly IPedidoRepository pedidoRepository;

        public PedidoController(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
            //this.pedidoRepository = pedidoRepository;
        }

        public IActionResult Carrossel()
        {
            return View(produtoRepository.GetProdutos());
        }

        public IActionResult Carrinho()
        {
           // Pedido pedido = pedidoRepository.GetPedido();
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Resumo()
        {
            return View();
        }
    }
}
