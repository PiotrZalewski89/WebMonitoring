using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class ReworkOslonHr10L1
    {
        public int Id { get; set; }
        public string NrShella { get; set; }
        public string NrGrawerkaKodDet { get; set; }
        public string NrGrawerkaKodGpf { get; set; }
        public DateTime? DtOperacji { get; set; }
        public string NrLinii { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
        public int? FrameSeq3 { get; set; }
        public int? FrameSeq2 { get; set; }
        public long? FrameTime2 { get; set; }
        public long? FrameTime3 { get; set; }
    }
}
