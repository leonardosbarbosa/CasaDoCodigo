using CasaDoCodigo.Models;
using CasaDoCodigo.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationContext context) : base(context)
        {
        }

        public Pedido GetPedido()
        {
            throw new NotImplementedException();
        }
    }
}
