using Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IReviewRepository
    {
        Task<Review> GetByIdAsync(Guid reviewId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Review>> GetAllAsync(CancellationToken cancellationToken = default);
        Task CreateReviewAsync(Review review); // Asinkrona metoda
        Task UpdateReviewAsync(Review review); // Asinkrona metoda
        Task DeleteReviewAsync(Review review, CancellationToken cancellationToken = default); // Asinkrona metoda
    }
}
