using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class ShellLineDimecoL0
    {
        public int Id { get; set; }
        public string PartNumber { get; set; }
        public string BatchNumber { get; set; }
        public string CodeCoil { get; set; }
        public string CodeLot { get; set; }
        public string CodeBlankPalet { get; set; }
        public float? WeightCoil { get; set; }
        public float? WeightBlank { get; set; }
        public int? PartsProduced { get; set; }
        public int? PartsRemaining { get; set; }
        public bool? CanUsed { get; set; }
        public int? FrameSeq { get; set; }
        public long? FrameTime { get; set; }
        public DateTime? DtOperacji { get; set; }
    }
}
