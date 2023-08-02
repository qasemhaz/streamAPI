using System;
using System.Collections.Generic;

#nullable disable

namespace Stream.Core.Data
{
    public partial class Streamrole
    {
        public Streamrole()
        {
            Streamcrews = new HashSet<Streamcrew>();
            Streamlogins = new HashSet<Streamlogin>();
            Streamsources = new HashSet<Streamsource>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Streamcrew> Streamcrews { get; set; }
        public virtual ICollection<Streamlogin> Streamlogins { get; set; }
        public virtual ICollection<Streamsource> Streamsources { get; set; }
    }
}
