using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Data
{
    public partial class Streamreview
    {
        public decimal Id { get; set; }
        public string? Comments { get; set; }
        public decimal? Iduser { get; set; }
        public decimal? Idmovie { get; set; }
        public decimal? Idseries { get; set; }
      
    }
}
