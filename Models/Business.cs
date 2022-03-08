using System;
using System.Collections.Generic;

namespace MattiaBertozziCVOnline.Models
{
    public partial class Business
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? Sede { get; set; }
        public string? Commenti { get; set; }
    }
}
