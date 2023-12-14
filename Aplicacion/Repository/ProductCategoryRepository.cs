using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class ProductCategoryRepository : GenericRepo<ProductCategory>, IProductCategory
    {
        private readonly ApiContext _context;

        public ProductCategoryRepository(ApiContext context) : base (context)
        {
            _context = context;
        }
    }
}