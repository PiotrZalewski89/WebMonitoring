using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.StorageStation
{
    public partial class ShellLineWeilL0
    {
        public int Id { get; set; }
        public string PartNumber { get; set; }
        public string CodeBlank { get; set; }
        public string CodeCan { get; set; }
        public int? PartsProduced { get; set; }
        public int? PartsRemaining { get; set; }
        public bool? CanUsed { get; set; }
        public int? FrameSeq { get; set; }
        public long? FrameTime { get; set; }
        public DateTime? DtOperacji { get; set; }
    }
}
