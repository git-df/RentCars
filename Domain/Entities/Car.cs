using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string PlaceNumber { get; set; } = string.Empty;
        public string VIN { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public FuelType Fuel { get; set; }
        public int Year { get; set; }

        public List<CarAttribute> carAttributes { get; set; } = new List<CarAttribute>();

        public int? ModelOfCarsId { get; set; }
        public ModelOfCars ModelOfCars { get; set; } = new ModelOfCars();

        public List<Offer> Offers { get; set; } = new List<Offer>();

        public List<Rent> Rents { get; set; } = new List<Rent>();
    }
}
