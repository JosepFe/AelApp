using System;
using System.Collections.Generic;

#nullable disable

namespace Devon4Net.WebAPI.Implementation.Domain.Entities
{
    public partial class Town
    {
        public Town()
        {
            UserTowns = new HashSet<UserTown>();
        }

        public Guid Id { get; set; }
        public string TownName { get; set; }
        public string Community { get; set; }

        public virtual ICollection<UserTown> UserTowns { get; set; }
    }
}
