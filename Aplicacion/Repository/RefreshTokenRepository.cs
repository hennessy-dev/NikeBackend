using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository
{
    public class RefreshTokenRepository : GenericRepo<RefreshToken>, IRefreshToken
    {
        private readonly ApiContext _context;

        public RefreshTokenRepository(ApiContext context) : base (context)
        {
            _context = context;
        }
    }
}