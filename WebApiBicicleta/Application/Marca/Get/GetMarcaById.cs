using Application.Common.Interfaces;
using System.Threading.Tasks;

namespace Application.Marca.Get
{
    public class GetMarcaById : Common.Interfaces.Actions.IGetById<Domain.Marca.Entity.Marca>
    {
        private readonly IApiDbContext _context;

        public GetMarcaById(IApiDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Marca.Entity.Marca> GetById(int id)
        {
            return await _context.Marca.FindAsync(id);
        }
    }
}
