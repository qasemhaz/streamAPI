using System;
using System.Collections.Generic;

#nullable disable

namespace Stream.Core.Data
{
    public partial class Streamseries
    {
        public Streamseries()
        {
            Streamfavs = new HashSet<Streamfav>();
            Streammovieseriescrews = new HashSet<Streammovieseriescrew>();
            Streamwatchlaters = new HashSet<Streamwatchlater>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public decimal? Rate { get; set; }
        public string Duraation { get; set; }
        public DateTime? Productionyear { get; set; }
        public string Image { get; set; }
        public string Trailer { get; set; }
        public string Trailerlink { get; set; }
        public string Discreption { get; set; }
        public string Reviews { get; set; }
        public decimal? Categoryid { get; set; }
        public decimal? Numofviews { get; set; }

        public virtual Streamcategory Category { get; set; }
        public virtual ICollection<Streamfav> Streamfavs { get; set; }
        public virtual ICollection<Streammovieseriescrew> Streammovieseriescrews { get; set; }
        public virtual ICollection<Streamwatchlater> Streamwatchlaters { get; set; }
    }
}
