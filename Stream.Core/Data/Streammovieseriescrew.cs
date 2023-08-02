using System;
using System.Collections.Generic;

#nullable disable

namespace Stream.Core.Data
{
    public partial class Streammovieseriescrew
    {
        public decimal Id { get; set; }
        public decimal? Crewid { get; set; }
        public decimal? Movieid { get; set; }
        public decimal? Seriesid { get; set; }

        public virtual Streamcrew Crew { get; set; }
        public virtual Streammovie Movie { get; set; }
        public virtual Streamseries Series { get; set; }
    }
}
