using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Common.Interfaces.Actions
{
    public interface IGet<T>
    {
        public Task<List<T>> Get();
    }
}
