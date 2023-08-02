using System;
using System.Collections.Generic;
using System.Text;

namespace Stream.Core.Data
{
    public partial class Streamchat
    {
        public decimal Id { get; set; }
        public decimal? sender { get; set; }
        public decimal? receiver { get; set; }
        public string? message { get; set; }
        public DateTime? sent_at { get; set; }
        
    }
}
