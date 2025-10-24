using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class Hr12ufReworkL6
    {
        public int Id { get; set; }
        public string NrKodu { get; set; }
        public string WadaJakosciowa { get; set; }
        public string IdOperatora { get; set; }
        public DateTime? DtOperacji { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public string Model { get; set; }
    }
}
