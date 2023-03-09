using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ModelOfCars
    {
        public int Id { get; set; }
        public string BrandName { get; set; } = string.Empty;
        public string ModelName { get; set; } = string.Empty;
        public string Generation { get; set; } = string.Empty;

        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
