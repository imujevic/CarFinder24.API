using Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IDealerRepository
    {
        Task<Dealer> GetByIdAsync(Guid dealerId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Dealer>> GetAllAsync(CancellationToken cancellationToken = default);
        Task CreateDealerAsync(Dealer dealer); // Asinkrona metoda
        Task UpdateDealerAsync(Dealer dealer); // Asinkrona metoda
        Task DeleteDealerAsync(Dealer dealer, CancellationToken cancellationToken = default); // Asinkrona metoda
    }
}
