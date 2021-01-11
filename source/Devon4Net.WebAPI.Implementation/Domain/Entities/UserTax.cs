using System;
using System.Collections.Generic;

#nullable disable

namespace Devon4Net.WebAPI.Implementation.Domain.Entities
{
    public partial class UserTax
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid TaxId { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool Paid { get; set; }
        public double BaseAmount { get; set; }
        public DateTime PaymentDeadlineDate { get; set; }
        public double AmountToPay { get; set; }
        public string Reference { get; set; }

        public virtual Tax Tax { get; set; }
        public virtual User User { get; set; }
    }
}
