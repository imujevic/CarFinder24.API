using Domain.Entities.Billding;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IPurchaseAgreementRepository
    {
        Task<PurchaseAgreement> GetByIdAsync(Guid agreementId, CancellationToken cancellationToken = default);
        Task<IEnumerable<PurchaseAgreement>> GetAllAsync(CancellationToken cancellationToken = default);
        Task CreatePurchaseAgreementAsync(PurchaseAgreement agreement); // Asinkrona metoda
        Task UpdatePurchaseAgreementAsync(PurchaseAgreement agreement); // Asinkrona metoda
        Task DeletePurchaseAgreementAsync(PurchaseAgreement agreement, CancellationToken cancellationToken = default); // Asinkrona metoda
    }
}
