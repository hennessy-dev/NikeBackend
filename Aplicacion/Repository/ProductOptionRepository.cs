using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class ProductOptionRepository : GenericRepo<ProductOption>, IProductOption
    {
        private readonly ApiContext _context;

        public ProductOptionRepository(ApiContext context) : base (context)
        {
            _context = context;
        }
    }
}