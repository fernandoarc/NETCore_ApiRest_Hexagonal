using Application.Common.Interfaces;
using System.Threading.Tasks;

namespace Application.Marca.Get
{
    public class GetMarcaById
    {
        private readonly IApiDbContext _context;

        public GetMarcaById(IApiDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Marca.Entity.Marca> Get(int MarcaId)
        {
            return await _context.Marca.FindAsync(MarcaId);
        }
    }
}
