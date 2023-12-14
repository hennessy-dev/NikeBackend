using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class ProductRepository : GenericRepo<Product>, IProduct
    {
        private readonly ApiContext _context;

        public ProductRepository(ApiContext context) : base (context)
        {
            _context = context;
        }
    }
}