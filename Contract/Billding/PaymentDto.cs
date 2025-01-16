using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Billding
{
    public class PaymentDto
    {
        public Guid PaymentId { get; set; }
        public Guid BookingId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }
    }

    // PaymentCreateDto.cs
    public class PaymentCreateDto
    {
        public Guid BookingId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }

    // UpdatePaymentDto.cs
    public class UpdatePaymentDto
    {
        public Guid PaymentId { get; set; }
        public string Status { get; set; }
    }
}
