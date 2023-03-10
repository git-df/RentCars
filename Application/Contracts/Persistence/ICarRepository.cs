using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Persistence
{
    public interface ICarRepository : IAsyncRepository<Car>
    {
        Task<List<Car>> GetByModel(string brandName = null, string modelName = null);
    }
}
