using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Offer
    {
        public int Id { get; set; }
        public decimal PricePreDay { get; set; }
        public decimal PricePerHour { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public int? CarId { get; set; }
        public Car Car { get; set; } = new Car();

        public int? BranchId { get; set; }
        public Branch Branch { get; set; } = new Branch();
    }
}
