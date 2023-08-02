using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Data
{
    public partial class Streampricing
    {
        public decimal Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public decimal? Periodd { get; set; }
    }
}
