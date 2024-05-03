﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CompanyOffer : Entity
    {
        public string OfferInformation { get; set; } = string.Empty;
        [Required]
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        [Required]
        public int CareerCenterId { get; set; }
        [ForeignKey("CareerCenterId")]
        public CareerCenter CareerCenter { get; set; }
    }
}