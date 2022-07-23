using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces.Actions
{
    public interface IUpdate<T>
    {
        public Task<bool> Update(T item, CancellationToken cancellationToken);
    }
}
