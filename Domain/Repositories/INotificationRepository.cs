using Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface INotificationRepository
    {
        Task<Notification> GetByIdAsync(Guid notificationId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Notification>> GetAllAsync(CancellationToken cancellationToken = default);
        Task CreateNotificationAsync(Notification notification); // Asinkrona metoda
        Task UpdateNotificationAsync(Notification notification); // Asinkrona metoda
        Task DeleteNotificationAsync(Notification notification, CancellationToken cancellationToken = default); // Asinkrona metoda
    }
}
