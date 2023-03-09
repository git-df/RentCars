using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public PaymentStatus Status { get; set; } = PaymentStatus.Unpaid;

        public int? RentId { get; set; }
        public Rent Rent { get; set; } = new Rent();
    }
}
