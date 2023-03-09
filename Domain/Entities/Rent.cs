using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Rent
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public RentStatus Status { get; set; } = RentStatus.New;

        public int? ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = new ApplicationUser();

        public Payment Payment { get; set; } = new Payment();

        public int? CarId { get; set; }
        public Car Car { get; set; } = new Car();
    }
}
