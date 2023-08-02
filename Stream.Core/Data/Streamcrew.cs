using System;
using System.Collections.Generic;

#nullable disable

namespace Stream.Core.Data
{
    public partial class Streamcrew
    {
        public Streamcrew()
        {
            Streammovieseriescrews = new HashSet<Streammovieseriescrew>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Descip { get; set; }
        public string Image { get; set; }
        public string Facebook { get; set; }
        public string Twiter { get; set; }
        public string Instagram { get; set; }
        public string Age { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Placeofbirth { get; set; }
        public decimal? Roleid { get; set; }

        public virtual Streamrole Role { get; set; }
        public virtual ICollection<Streammovieseriescrew> Streammovieseriescrews { get; set; }
    }
}
