using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class OrderDetailRepository : GenericRepo<OrderDetail>, IOrderDetail
    {
        private readonly ApiContext _context;

        public OrderDetailRepository(ApiContext context) : base (context)
        {
            _context = context;
        }
    }
}