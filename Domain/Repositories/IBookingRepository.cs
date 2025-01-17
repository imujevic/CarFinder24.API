using Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IBookingRepository
    {
        Task<Booking> GetByIdAsync(Guid bookingId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Booking>> GetAllAsync(CancellationToken cancellationToken = default);
        Task CreateBookingAsync(Booking booking); // Asinkrona metoda
        Task UpdateBookingAsync(Booking booking); // Asinkrona metoda
        Task DeleteBookingAsync(Booking booking, CancellationToken cancellationToken = default); // Asinkrona metoda
    }
}
