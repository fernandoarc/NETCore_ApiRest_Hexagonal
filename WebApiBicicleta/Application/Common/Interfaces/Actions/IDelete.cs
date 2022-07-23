using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces.Actions
{
    public interface IDelete
    {
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}
