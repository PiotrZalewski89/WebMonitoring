using System;
using System.Collections.Generic;

#nullable disable

namespace WebMonitoring.Table.V50
{
    public partial class V50Ws2Shell
    {
        public string ShellSerialNum { get; set; }
        public int? Id { get; set; }
        public DateTime? DtMeasure { get; set; }
        public string Pass { get; set; }
        public string PartNum { get; set; }
        public long? FrameTime { get; set; }
        public int? FrameSeq { get; set; }
    }
}
