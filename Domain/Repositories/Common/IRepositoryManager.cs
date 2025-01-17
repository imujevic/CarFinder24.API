namespace Domain.Repositories
{
    public interface IRepositoryManager
    {
        IUserRepository UserRepository { get; }
        IDealerRepository DealerRepository { get; }
        ICarRepository CarRepository { get; }
        IListingRepository ListingRepository { get; }
        IBookingRepository BookingRepository { get; }
        IReviewRepository ReviewRepository { get; }
        IPaymentRepository PaymentRepository { get; }
        INotificationRepository NotificationRepository { get; }
        IPurchaseAgreementRepository PurchaseAgreementRepository { get; }
        ICarFeatureRepository CarFeatureRepository { get; }
        IUnitOfWork UnitOfWork { get; }
    }
}
