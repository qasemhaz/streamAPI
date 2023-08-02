using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Data
{
    public partial class Streampricinguser
    {
        public decimal Id { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Planid { get; set; }
        public DateTime? Activedate { get; set; }
    }
}
