using System;
using System.Collections.Generic;

#nullable disable

namespace Devon4Net.WebAPI.Implementation.Domain.Entities
{
    public partial class Taxes
    {
        public Taxes()
        {
            UserTaxes = new HashSet<UserTaxe>();
        }

        public Guid Id { get; set; }
        public string TaxName { get; set; }
        public string Year { get; set; }
        public DateTime TaxDeadlineDate { get; set; }

        public virtual ICollection<UserTaxe> UserTaxes { get; set; }
    }
}
