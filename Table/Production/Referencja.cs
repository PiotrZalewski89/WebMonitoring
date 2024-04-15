using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.Production
{
    public partial class Referencja
    {
        public int Id { get; set; }
        public string ReferencjaKatcon { get; set; }
        public string ReferencjaKlient { get; set; }
        public string Model { get; set; }
    }
}
