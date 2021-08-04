using System;
using System.Collections.Generic;

#nullable disable

namespace Covid19_Reg.Models
{
    public partial class DailyCheckin
    {
        public string Name { get; set; }
        public bool Changed { get; set; }
        public string ChangedContent { get; set; }
        public DateTime Date { get; set; }
        public double Temperature { get; set; }
        public int Id { get; set; }
    }
}
