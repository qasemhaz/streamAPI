using System;
using System.Collections.Generic;

#nullable disable

namespace Stream.Core.Data
{
    public partial class Streamcategory
    {
        public Streamcategory()
        {
            Streammovies = new HashSet<Streammovie>();
            Streamseries = new HashSet<Streamseries>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Streammovie> Streammovies { get; set; }
        public virtual ICollection<Streamseries> Streamseries { get; set; }
    }
}
