using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Contract
{
    public class BookingDto
    {
        public Guid BookingId { get; set; }
        public Guid UserId { get; set; }
        public Guid CarId { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }
    }

    // BookingCreateDto.cs
    public class BookingCreateDto
    {
        public Guid UserId { get; set; }
        public Guid CarId { get; set; }
        public DateTime BookingDate { get; set; }
    }

    // UpdateBookingDto.cs
    public class UpdateBookingDto
    {
        public Guid BookingId { get; set; }
        public string Status { get; set; }
    }

    // ReviewDto.cs
    public class ReviewDto
    {
        public Guid ReviewId { get; set; }
        public Guid UserId { get; set; }
        public Guid CarId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
