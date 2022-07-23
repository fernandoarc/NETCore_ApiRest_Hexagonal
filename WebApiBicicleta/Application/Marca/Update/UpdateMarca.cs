using Application.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Marca.Update
{
    public class UpdateMarca : Common.Interfaces.Actions.IUpdate<Domain.Marca.Entity.Marca>
    {
        private readonly IApiDbContext _contex;

        public UpdateMarca(IApiDbContext contex)
        {
            _contex = contex;
        }

        public async Task<bool> Update(Domain.Marca.Entity.Marca item, CancellationToken cancellationToken)
        {
            _contex.Marca.Update(item);
            await _contex.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
