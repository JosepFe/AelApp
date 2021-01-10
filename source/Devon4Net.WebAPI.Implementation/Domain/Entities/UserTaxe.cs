﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Devon4Net.WebAPI.Implementation.Domain.Entities
{
    public partial class UserTaxe
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid TaxId { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool Paid { get; set; }
        public int BaseAmount { get; set; }
        public DateTime? PaymentDeadlineDate { get; set; }
        public int? AmountToPay { get; set; }

        public virtual Taxes Tax { get; set; }
        public virtual User User { get; set; }
    }
}
