using System;
using System.Collections.Generic;

#nullable disable

namespace Stream.Core.Data
{
    public partial class Streamuser
    {
        public Streamuser()
        {
            Streamfavs = new HashSet<Streamfav>();
            Streamlogins = new HashSet<Streamlogin>();
            Streamwatchlaters = new HashSet<Streamwatchlater>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Streamfav> Streamfavs { get; set; }
        public virtual ICollection<Streamlogin> Streamlogins { get; set; }
        public virtual ICollection<Streamwatchlater> Streamwatchlaters { get; set; }
    }
}
