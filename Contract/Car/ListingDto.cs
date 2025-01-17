using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Car
{
    public class ListingDto
    {
        public Guid ListingId { get; set; }
        public Guid DealerId { get; set; }
        public Guid CarId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime DateListed { get; set; }
        public bool IsAvailable { get; set; }
    }

    public class ListingCreateDto
    {
        public Guid DealerId { get; set; }
        public Guid CarId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime DateListed { get; set; }
    }

    public class UpdateListingDto
    {
        public Guid ListingId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
    }
}
