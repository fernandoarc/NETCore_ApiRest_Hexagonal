using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Marca.Get
{
    public class GetMarca
    {
        private readonly IApiDbContext _contex;

        public GetMarca(IApiDbContext contex)
        {
            _contex = contex;
        }

        public async Task<List<Domain.Marca.Entity.Marca>> Get()
        {
            return await _contex.Marca.ToListAsync();
        }
    }
}
