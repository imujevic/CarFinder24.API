namespace Domain.Entities
{
    public class Booking
    {
        public Guid BookingId { get; set; }
        public Guid UserId { get; set; }
        public Guid CarId { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }
    }
}
