using Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default);
        Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default);
        Task CreateUserAsync(User user); // Asinkrona metoda
        Task UpdateUserAsync(User user); // Asinkrona metoda
        Task DeleteUserAsync(User user, CancellationToken cancellationToken = default); // Asinkrona metoda
    }
}
