using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IApiDbContext
    {
        DbSet<Domain.Marca.Entity.Marca> Marca { get; set; }

        Task<int> SaveChangesAsync();
    }
}
