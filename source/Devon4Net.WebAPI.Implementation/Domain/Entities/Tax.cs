using System;
using System.Collections.Generic;

#nullable disable

namespace Devon4Net.WebAPI.Implementation.Domain.Entities
{
    public partial class Tax
    {
        public Tax()
        {
            UserTaxes = new HashSet<UserTax>();
        }

        public Guid Id { get; set; }
        public string TaxName { get; set; }
        public string Year { get; set; }
        public DateTime TaxDeadlineDate { get; set; }

        public virtual ICollection<UserTax> UserTaxes { get; set; }
    }
}
