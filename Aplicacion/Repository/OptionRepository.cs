using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class OptionRepository : GenericRepo<Option>, IOption
    {
        private readonly ApiContext _context;

        public OptionRepository(ApiContext context) : base (context)
        {
            _context = context;
        }
    }
}