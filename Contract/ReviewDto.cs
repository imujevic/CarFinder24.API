using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public class ReviewDto
    {
        public Guid ReviewId { get; set; }
        public Guid UserId { get; set; }
        public Guid CarId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }

    public class ReviewCreateDto
    {
        public Guid UserId { get; set; }
        public Guid CarId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }

    public class UpdateReviewDto
    {
        public Guid ReviewId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
