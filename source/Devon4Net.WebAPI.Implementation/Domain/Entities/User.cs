using System;
using System.Collections.Generic;

#nullable disable

namespace Devon4Net.WebAPI.Implementation.Domain.Entities
{
    public partial class User
    {
        public User()
        {
            UserTaxes = new HashSet<UserTax>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Dni { get; set; }
        
        public virtual UserTown UserTown { get; set; }
        public virtual ICollection<UserTax> UserTaxes { get; set; }
    }
}
