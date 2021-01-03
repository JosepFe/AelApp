using System;
using System.Collections.Generic;

#nullable disable

namespace Devon4Net.WebAPI.Implementation.Domain.Entities
{
    public partial class UserTown
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid TownId { get; set; }
        public DateTime RegisterDate { get; set; }

        public virtual Town Town { get; set; }
        public virtual User User { get; set; }
    }
}
