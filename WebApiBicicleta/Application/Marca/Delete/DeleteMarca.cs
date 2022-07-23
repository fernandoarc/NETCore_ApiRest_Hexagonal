using Application.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Marca.Delete
{
    public class DeleteMarca : Common.Interfaces.Actions.IDelete
    {
        private readonly IApiDbContext _contex;

        public DeleteMarca(IApiDbContext contex)
        {
            _contex = contex;
        }
        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var marca = await _contex.Marca.FindAsync(id);
            _contex.Marca.Remove(marca);
            await _contex.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
