using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class CategoryRepository : GenericRepo<Category>, ICategory
    {
        private readonly ApiContext _context;

        public CategoryRepository(ApiContext context) : base (context)
        {
            _context = context;
        }
    }
}