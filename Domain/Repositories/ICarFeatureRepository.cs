using Domain.Entities;
using Domain.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ICarFeatureRepository
    {
        Task<CarFeature> GetByIdAsync(Guid featureId, CancellationToken cancellationToken = default);
        Task<IEnumerable<CarFeature>> GetAllAsync(CancellationToken cancellationToken = default);
        Task CreateCarFeatureAsync(CarFeature carFeature); // Asinkrona metoda
        Task UpdateCarFeatureAsync(CarFeature carFeature); // Asinkrona metoda
        Task DeleteCarFeatureAsync(CarFeature carFeature, CancellationToken cancellationToken = default); // Asinkrona metoda
    }
}
