using System;
using System.Collections.Generic;

namespace FactApp.Models
{
    public partial class Fact
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
