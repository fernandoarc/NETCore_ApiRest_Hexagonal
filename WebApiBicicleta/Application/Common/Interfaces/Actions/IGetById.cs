using System.Threading.Tasks;

namespace Application.Common.Interfaces.Actions
{
    public interface IGetById<T>
    {
        public Task<T> GetById(int id);
    }
}
