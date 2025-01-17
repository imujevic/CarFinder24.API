using Domain.Entities.Billding;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IPaymentRepository
    {
        Task<Payment> GetByIdAsync(Guid paymentId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Payment>> GetAllAsync(CancellationToken cancellationToken = default);
        Task CreatePaymentAsync(Payment payment); // Asinkrona metoda
        Task UpdatePaymentAsync(Payment payment); // Asinkrona metoda
        Task DeletePaymentAsync(Payment payment, CancellationToken cancellationToken = default); // Asinkrona metoda
    }
}
