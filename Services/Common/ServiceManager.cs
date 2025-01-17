global using Contract;
global using Domain.Entities;
global using Domain.Repositories;
global using Mapster;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.Extensions.Configuration;
global using Microsoft.IdentityModel.Tokens;
global using Services.Abstractions;
global using System.IdentityModel.Tokens.Jwt;
global using System.Security.Claims;
global using System.Security.Cryptography;
global using System.Text;

namespace Services
{
    public class ServiceManager(
        IRepositoryManager repositoryManager,
        UserManager<User> userManager,
        RoleManager<AccountRole> roleManager,
        ITokenService tokenService) : IServiceManager
    {
        private readonly Lazy<IUserService> _lazyUserService = new(() => new UserService(repositoryManager, userManager, tokenService));

        private readonly Lazy<IDealerService> _lazyDealerService = new(() => new DealerService(repositoryManager));

        private readonly Lazy<ICarService> _lazyCarService = new(() => new CarService(repositoryManager));

        private readonly Lazy<IListingService> _lazyListingService = new(() => new ListingService(repositoryManager));

        private readonly Lazy<IBookingService> _lazyBookingService = new(() => new BookingService(repositoryManager));

        private readonly Lazy<IReviewService> _lazyReviewService = new(() => new ReviewService(repositoryManager));

        private readonly Lazy<IPaymentService> _lazyPaymentService = new(() => new PaymentService(repositoryManager));

        private readonly Lazy<INotificationService> _lazyNotificationService = new(() => new NotificationService(repositoryManager));

        private readonly Lazy<IPurchaseAgreementService> _lazyPurchaseAgreementService = new(() => new PurchaseAgreementService(repositoryManager));

        public IUserService UserService => _lazyUserService.Value;

        public IDealerService DealerService => _lazyDealerService.Value;

        public ICarService CarService => _lazyCarService.Value;

        public IListingService ListingService => _lazyListingService.Value;

        public IBookingService BookingService => _lazyBookingService.Value;

        public IReviewService ReviewService => _lazyReviewService.Value;

        public IPaymentService PaymentService => _lazyPaymentService.Value;

        public INotificationService NotificationService => _lazyNotificationService.Value;

        public IPurchaseAgreementService PurchaseAgreementService => _lazyPurchaseAgreementService.Value;
    }
}
