using Application.Common.Interfaces;
using Application.Common.Interfaces.Actions;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Marca.Create
{
    public class CreateMarca : IAdd<Domain.Marca.Entity.Marca>
    {
        private readonly IApiDbContext _context;

        public CreateMarca(IApiDbContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Domain.Marca.Entity.Marca item, CancellationToken cancellationToken)
        {
            _context.Marca.Add(item);
            await _context.SaveChangesAsync(cancellationToken);
            return item.IdBicicletaMarca;
        }

    }
}
