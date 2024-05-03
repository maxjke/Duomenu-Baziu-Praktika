﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CareerCenter : Entity
    {
        public ICollection<CompanyOffer> CompanyOffers { get; set; } = new List<CompanyOffer>();
    }
}
