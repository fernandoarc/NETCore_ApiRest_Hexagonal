using Application.Common.Interfaces;
using System.Threading.Tasks;

namespace Application.Marca.Create
{
    public class CreateMarca
    {
        private readonly IApiDbContext _context;

        public CreateMarca(IApiDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Marca.Entity.Marca> Create(Domain.Marca.Entity.Marca marca)
        {
            _context.Marca.Add(marca);
            await _context.SaveChangesAsync();
            return marca;
        }
    }
}
