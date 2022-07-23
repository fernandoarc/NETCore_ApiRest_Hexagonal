using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces.Actions
{
    public interface IAdd<T>
    {
        public Task<int> Add(T item, CancellationToken cancellationToken);
    }
}
