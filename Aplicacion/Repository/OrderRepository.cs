using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class OrderRepository : GenericRepo<Order>, IOrder
    {
        private readonly ApiContext _context;

        public OrderRepository(ApiContext context) : base (context)
        {
            _context = context;
        }
    }
}