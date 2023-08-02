using System;
using System.Collections.Generic;

#nullable disable

namespace Stream.Core.Data
{
    public partial class Streamsource
    {
        public decimal Id { get; set; }
        public string Video { get; set; }
        public string Quality { get; set; }
        public string Player { get; set; }
        public string Languagee { get; set; }
        public DateTime? Dateadded { get; set; }
        public decimal? Movieid { get; set; }
        public decimal? Episodeid { get; set; }

        public virtual Streamepisode Episode { get; set; }
        public virtual Streamrole Movie { get; set; }
    }
}
