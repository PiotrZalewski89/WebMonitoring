using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class M260ReprintL4
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public DateTime? DtOperacji { get; set; }
        public string IdOperatora { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
    }
}
