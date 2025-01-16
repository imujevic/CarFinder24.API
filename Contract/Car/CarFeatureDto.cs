using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Car
{
    // CarFeatureDto.cs
    public class CarFeatureDto
    {
        public Guid FeatureId { get; set; }
        public Guid CarId { get; set; }
        public string FeatureName { get; set; }
        public string Description { get; set; }
    }

    // CarFeatureCreateDto.cs
    public class CarFeatureCreateDto
    {
        public Guid CarId { get; set; }
        public string FeatureName { get; set; }
        public string Description { get; set; }
    }

    // UpdateCarFeatureDto.cs
    public class UpdateCarFeatureDto
    {
        public Guid FeatureId { get; set; }
        public string FeatureName { get; set; }
        public string Description { get; set; }
    }

}
