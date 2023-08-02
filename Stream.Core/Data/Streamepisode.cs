using System;
using System.Collections.Generic;

#nullable disable

namespace Stream.Core.Data
{
    public partial class Streamepisode
    {
        public Streamepisode()
        {
            Streamfavs = new HashSet<Streamfav>();
            Streamsources = new HashSet<Streamsource>();
            Streamwatchlaters = new HashSet<Streamwatchlater>();
        }

        public decimal Id { get; set; }
        public decimal? Seriesid { get; set; }
        public decimal? Episodenum { get; set; }

        
        public virtual ICollection<Streamfav> Streamfavs { get; set; }
        public virtual ICollection<Streamsource> Streamsources { get; set; }
        public virtual ICollection<Streamwatchlater> Streamwatchlaters { get; set; }
    }
}
