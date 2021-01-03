using System;
using System.Collections.Generic;

#nullable disable

namespace Devon4Net.WebAPI.Implementation.Domain.Entities
{
    public partial class User
    {
        public User()
        {
            UserTowns = new HashSet<UserTown>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Dni { get; set; }
        public string Adress { get; set; }

        public virtual ICollection<UserTown> UserTowns { get; set; }
    }
}
