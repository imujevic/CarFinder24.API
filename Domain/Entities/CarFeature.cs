using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CarFeatureDto
    {
        public Guid FeatureId { get; set; }
        public Guid CarId { get; set; }
        public string FeatureName { get; set; }
        public string Description { get; set; }
    }
}
