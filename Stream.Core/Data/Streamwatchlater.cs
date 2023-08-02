using System;
using System.Collections.Generic;

#nullable disable

namespace Stream.Core.Data
{
    public partial class Streamwatchlater
    {
        public decimal Id { get; set; }
        public decimal? Movieid { get; set; }
        public decimal? Seriesid { get; set; }
        public decimal? Episodeid { get; set; }
        public decimal? Userid { get; set; }

        public virtual Streamepisode Episode { get; set; }
        public virtual Streammovie Movie { get; set; }
        public virtual Streamseries Series { get; set; }
        public virtual Streamuser User { get; set; }
    }
}
