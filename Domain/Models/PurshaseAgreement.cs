using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    internal class PurshaseAgreement
    {
        public Guid ContractId { get; set; }
        public Guid BuyerId { get; set; }
        public Guid SellerId { get; set; }
        public Guid CarId { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfAgreement { get; set; }
        public string ContractDetails { get; set; }
    }
}
