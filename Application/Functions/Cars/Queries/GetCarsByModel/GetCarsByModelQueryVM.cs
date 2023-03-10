using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Cars.Queries.GetCarsByModel
{
    public class GetCarsByModelQueryVM
    {
        public string Color { get; set; } = string.Empty;
        public FuelType Fuel { get; set; }
        public int Year { get; set; }
        public ModelInGetCarsByModelQueryVM Model { get; set; }
    }

    public class ModelInGetCarsByModelQueryVM
    {
        public string BrandName { get; set; } = string.Empty;
        public string ModelName { get; set; } = string.Empty;
        public string Generation { get; set; } = string.Empty;
    }
}
