using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Car
{
    // CarDto.cs
    public class CarDto
    {
        public Guid CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Guid DealerId { get; set; }
    }

    // CarCreateDto.cs
    public class CarCreateDto
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Guid DealerId { get; set; }
    }

    // UpdateCarDto.cs
    public class UpdateCarDto
    {
        public Guid CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

}
