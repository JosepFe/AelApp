using System;
using System.Collections.Generic;

#nullable disable

namespace Devon4Net.WebAPI.Implementation.Domain.Entities
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Dni { get; set; }
        
        public virtual UserTown UserTown { get; set; }
    }
}
