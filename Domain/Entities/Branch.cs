﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Branch : Address
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }

        public List<BranchEmployee> BranchEmployees { get; set; } = new List<BranchEmployee>();

        public List<Offer> Offers { get; set; } = new List<Offer>();
    }
}
