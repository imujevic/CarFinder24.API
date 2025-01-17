using Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IListingRepository
    {
        Task<Listing> GetByIdAsync(Guid listingId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Listing>> GetAllAsync(CancellationToken cancellationToken = default);
        Task CreateListingAsync(Listing listing); // Asinkrona metoda
        Task UpdateListingAsync(Listing listing); // Asinkrona metoda
        Task DeleteListingAsync(Listing listing, CancellationToken cancellationToken = default); // Asinkrona metoda
    }
}
