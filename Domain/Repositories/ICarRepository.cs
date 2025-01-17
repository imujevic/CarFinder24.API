using Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ICarRepository
    {
        Task<Car> GetByIdAsync(Guid carId, CancellationToken cancellationToken = default);
        Task<IEnumerable<Car>> GetAllAsync(CancellationToken cancellationToken = default);
        Task CreateCarAsync(Car car); // Asinkrona metoda
        Task UpdateCarAsync(Car car); // Asinkrona metoda
        Task DeleteCarAsync(Car car, CancellationToken cancellationToken = default); // Asinkrona metoda
    }
}
